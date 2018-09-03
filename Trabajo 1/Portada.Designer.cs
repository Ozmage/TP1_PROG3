namespace Trabajo_1
{
    partial class Portada
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
            this.CargarListas = new System.Windows.Forms.Button();
            this.cargarPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargarListas
            // 
            this.CargarListas.Location = new System.Drawing.Point(128, 281);
            this.CargarListas.Name = "CargarListas";
            this.CargarListas.Size = new System.Drawing.Size(209, 71);
            this.CargarListas.TabIndex = 1;
            this.CargarListas.Text = "Cargar Items";
            this.CargarListas.UseVisualStyleBackColor = true;
            this.CargarListas.Click += new System.EventHandler(this.button2_Click);
            // 
            // cargarPersonas
            // 
            this.cargarPersonas.Location = new System.Drawing.Point(128, 80);
            this.cargarPersonas.Name = "cargarPersonas";
            this.cargarPersonas.Size = new System.Drawing.Size(209, 71);
            this.cargarPersonas.TabIndex = 2;
            this.cargarPersonas.Text = "Cargar Personas";
            this.cargarPersonas.UseVisualStyleBackColor = true;
            this.cargarPersonas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.cargarPersonas);
            this.Controls.Add(this.CargarListas);
            this.Name = "Portada";
            this.Tag = "Portada";
            this.Text = "Portada";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CargarListas;
        private System.Windows.Forms.Button cargarPersonas;
    }
}