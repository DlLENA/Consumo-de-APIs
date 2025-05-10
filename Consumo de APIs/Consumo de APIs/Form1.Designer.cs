namespace Consumo_de_APIs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPokemon = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ImgPokemon = new System.Windows.Forms.PictureBox();
            this.dataGridStats = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStats)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 545);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblTitulo);
            this.flowLayoutPanel1.Controls.Add(this.txtPokemon);
            this.flowLayoutPanel1.Controls.Add(this.btnBuscar);
            this.flowLayoutPanel1.Controls.Add(this.btnLimpiar);
            this.flowLayoutPanel1.Controls.Add(this.ImgPokemon);
            this.flowLayoutPanel1.Controls.Add(this.dataGridStats);
            this.flowLayoutPanel1.Controls.Add(this.btnSiguiente);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 102);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 406);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(15, 25, 3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre Pokemon";
            // 
            // txtPokemon
            // 
            this.txtPokemon.Location = new System.Drawing.Point(217, 25);
            this.txtPokemon.Margin = new System.Windows.Forms.Padding(40, 25, 0, 0);
            this.txtPokemon.Name = "txtPokemon";
            this.txtPokemon.Size = new System.Drawing.Size(260, 22);
            this.txtPokemon.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(492, 70);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(15, 70, 0, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 83);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(636, 70);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(20, 70, 0, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 83);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ImgPokemon
            // 
            this.ImgPokemon.Location = new System.Drawing.Point(15, 183);
            this.ImgPokemon.Margin = new System.Windows.Forms.Padding(15, 30, 0, 0);
            this.ImgPokemon.Name = "ImgPokemon";
            this.ImgPokemon.Size = new System.Drawing.Size(180, 129);
            this.ImgPokemon.TabIndex = 4;
            this.ImgPokemon.TabStop = false;
            // 
            // dataGridStats
            // 
            this.dataGridStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStats.Location = new System.Drawing.Point(220, 168);
            this.dataGridStats.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.dataGridStats.Name = "dataGridStats";
            this.dataGridStats.RowHeadersWidth = 51;
            this.dataGridStats.RowTemplate.Height = 24;
            this.dataGridStats.Size = new System.Drawing.Size(247, 208);
            this.dataGridStats.TabIndex = 7;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(610, 303);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(140, 150, 3, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(132, 73);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 545);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pokédex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion      

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPokemon;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox ImgPokemon;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dataGridStats;
    }
}

