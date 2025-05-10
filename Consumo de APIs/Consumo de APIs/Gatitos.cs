using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Consumo_de_APIs
{
    public partial class Gatitos : Form
    {
        //HttpClient es una clase que permite hacer peticiones http a una api
        private readonly HttpClient httpClient = new HttpClient();
        public Gatitos()
        {
            InitializeComponent();
        }

        private async void btnGato_Click(object sender, EventArgs e)
        {
            //Llamar a la API de gatos y mostrar una imagen aleatoria
            string url = "https://api.thecatapi.com/v1/images/search";

            // Limpia headers anteriores
            httpClient.DefaultRequestHeaders.Clear(); 
            // Agregar el header de autenticación
            httpClient.DefaultRequestHeaders.Add("x-api-key", "live_8v0G1CsQ2dtTeDKAgvsOjG64k3Dyj9eOxLiE44R1xFKW0SLhGwKrAzmVCqikJ1BQ");

            try
            {
                string respuesta = await httpClient.GetStringAsync(url);//Llama a la api y guarda la respuesta en formato json
                JArray data = JArray.Parse(respuesta); //La respuesta es un array JSON con el objeto que contiene la url de la imagen 
                string imageUrl = data[0]["url"].ToString(); // Acceder a la URL de la imagen

                ImgGato.Load(imageUrl); // Cargar la imagen en el PictureBox
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Error de conexión con The Cat API.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener la imagen del gato: " + ex.Message);
            }
        }
    }
}
