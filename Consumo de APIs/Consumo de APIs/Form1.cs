using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace Consumo_de_APIs
{
    public partial class Form1 : Form
    {
        //HttpClient es una clase que permite hacer peticiones http a una api
        private readonly HttpClient httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            //Tolower y trim para quitar espacios en blanco y evitar errores
            string NombrePokemon = txtPokemon.Text.ToLower().Trim();

            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{NombrePokemon}";
                string json = await httpClient.GetStringAsync(url); //Aqui se hace una peticion http a la api de pokemon y se guarda la respuesta en formato json
                JObject data = JObject.Parse(json); //convertir el json a un objeto JObject para acceder a sus propiedades

                //Muestra el nombre del pokemon en el label
                lblTitulo.Text = "Nombre: " + data["name"].ToString();

                //Mostrar la imagen del pokemon tomando la url y mostrandola en el picturebox
                string imageUrl = data["sprites"]["front_default"].ToString();
                ImgPokemon.Load(imageUrl);

                //Limpiar el datagrid antes de agregar nuevos datos
                dataGridStats.Rows.Clear();
               dataGridStats.Columns.Clear();

                // Crear columnas
                dataGridStats.Columns.Add("StatName", "Estadística");
                dataGridStats.Columns.Add("BaseStat", "Valor");

                // Agregar filas
                foreach (var stat in data["stats"])
                {
                    string statName = stat["stat"]["name"].ToString();
                    string baseStat = stat["base_stat"].ToString();
                    dataGridStats.Rows.Add(statName, baseStat);
                }


            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error de conexión. Verifica tu internet o la API.");
            }
            catch (Exception)
            {
                MessageBox.Show("Pokémon no encontrado. Verifica que el nombre este bien escrito.");
            }
        }

        //Limpia todos los campos de la aplicacion 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPokemon.Clear();
            lblTitulo.Text = "Nombre:";
            ImgPokemon.Image = null;
           dataGridStats.Rows.Clear();
        }

        //Abre la ventana de los gatitos
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Gatitos gato = new Gatitos();
            gato.Show();
        }

    }
}
