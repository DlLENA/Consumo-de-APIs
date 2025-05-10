namespace Consumo_de_APIs
{
    partial class Gatitos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gatitos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ImgGato = new System.Windows.Forms.PictureBox();
            this.btnGato = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGato)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 566);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ImgGato);
            this.flowLayoutPanel1.Controls.Add(this.btnGato);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(898, 495);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ImgGato
            // 
            this.ImgGato.Location = new System.Drawing.Point(35, 35);
            this.ImgGato.Margin = new System.Windows.Forms.Padding(35, 35, 3, 3);
            this.ImgGato.Name = "ImgGato";
            this.ImgGato.Size = new System.Drawing.Size(570, 414);
            this.ImgGato.TabIndex = 0;
            this.ImgGato.TabStop = false;
            // 
            // btnGato
            // 
            this.btnGato.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGato.Location = new System.Drawing.Point(648, 130);
            this.btnGato.Margin = new System.Windows.Forms.Padding(40, 130, 3, 3);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(140, 71);
            this.btnGato.TabIndex = 1;
            this.btnGato.Text = "Mostrar Gato 😺";
            this.btnGato.UseVisualStyleBackColor = true;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click);
            // 
            // Gatitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 566);
            this.Controls.Add(this.panel1);
            this.Name = "Gatitos";
            this.Text = "Gatitos";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgGato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox ImgGato;
        private System.Windows.Forms.Button btnGato;
    }
}