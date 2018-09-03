namespace Trabajo_1
{
    partial class Form2
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
            this.btnAgregaItem = new System.Windows.Forms.Button();
            this.btnMoverIzquierda = new System.Windows.Forms.Button();
            this.btnTodosADerecha = new System.Windows.Forms.Button();
            this.txtCargaItem = new System.Windows.Forms.TextBox();
            this.lstListaIzquierda = new System.Windows.Forms.ListBox();
            this.lstListaDerecha = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnoADerecha = new System.Windows.Forms.Button();
            this.borrarDeDerecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregaItem
            // 
            this.btnAgregaItem.Location = new System.Drawing.Point(254, 34);
            this.btnAgregaItem.Name = "btnAgregaItem";
            this.btnAgregaItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregaItem.TabIndex = 0;
            this.btnAgregaItem.Text = "Agregar Item";
            this.btnAgregaItem.UseVisualStyleBackColor = true;
            this.btnAgregaItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMoverIzquierda
            // 
            this.btnMoverIzquierda.Location = new System.Drawing.Point(162, 276);
            this.btnMoverIzquierda.Name = "btnMoverIzquierda";
            this.btnMoverIzquierda.Size = new System.Drawing.Size(207, 23);
            this.btnMoverIzquierda.TabIndex = 1;
            this.btnMoverIzquierda.Text = "<-                Mover a la izquierda";
            this.btnMoverIzquierda.UseVisualStyleBackColor = true;
            this.btnMoverIzquierda.Click += new System.EventHandler(this.btnMoverDerecha_Click);
            // 
            // btnTodosADerecha
            // 
            this.btnTodosADerecha.Location = new System.Drawing.Point(162, 106);
            this.btnTodosADerecha.Name = "btnTodosADerecha";
            this.btnTodosADerecha.Size = new System.Drawing.Size(207, 23);
            this.btnTodosADerecha.TabIndex = 2;
            this.btnTodosADerecha.Text = "Mover TODO a la derecha             ->";
            this.btnTodosADerecha.UseVisualStyleBackColor = true;
            this.btnTodosADerecha.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCargaItem
            // 
            this.txtCargaItem.Location = new System.Drawing.Point(129, 36);
            this.txtCargaItem.Name = "txtCargaItem";
            this.txtCargaItem.Size = new System.Drawing.Size(119, 20);
            this.txtCargaItem.TabIndex = 3;
            // 
            // lstListaIzquierda
            // 
            this.lstListaIzquierda.FormattingEnabled = true;
            this.lstListaIzquierda.Location = new System.Drawing.Point(36, 96);
            this.lstListaIzquierda.Name = "lstListaIzquierda";
            this.lstListaIzquierda.Size = new System.Drawing.Size(120, 251);
            this.lstListaIzquierda.TabIndex = 5;
            // 
            // lstListaDerecha
            // 
            this.lstListaDerecha.FormattingEnabled = true;
            this.lstListaDerecha.Location = new System.Drawing.Point(375, 96);
            this.lstListaDerecha.Name = "lstListaDerecha";
            this.lstListaDerecha.Size = new System.Drawing.Size(120, 251);
            this.lstListaDerecha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUnoADerecha
            // 
            this.btnUnoADerecha.Location = new System.Drawing.Point(162, 135);
            this.btnUnoADerecha.Name = "btnUnoADerecha";
            this.btnUnoADerecha.Size = new System.Drawing.Size(207, 23);
            this.btnUnoADerecha.TabIndex = 8;
            this.btnUnoADerecha.Text = "Mover UNO a la derecha               ->";
            this.btnUnoADerecha.UseVisualStyleBackColor = true;
            this.btnUnoADerecha.Click += new System.EventHandler(this.btnUnoADerecha_Click);
            // 
            // borrarDeDerecha
            // 
            this.borrarDeDerecha.Location = new System.Drawing.Point(162, 305);
            this.borrarDeDerecha.Name = "borrarDeDerecha";
            this.borrarDeDerecha.Size = new System.Drawing.Size(207, 23);
            this.borrarDeDerecha.TabIndex = 9;
            this.borrarDeDerecha.Text = "BORRAR un item de la derecha       ->";
            this.borrarDeDerecha.UseVisualStyleBackColor = true;
            this.borrarDeDerecha.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 457);
            this.Controls.Add(this.borrarDeDerecha);
            this.Controls.Add(this.btnUnoADerecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstListaDerecha);
            this.Controls.Add(this.lstListaIzquierda);
            this.Controls.Add(this.txtCargaItem);
            this.Controls.Add(this.btnTodosADerecha);
            this.Controls.Add(this.btnMoverIzquierda);
            this.Controls.Add(this.btnAgregaItem);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregaItem;
        private System.Windows.Forms.Button btnMoverIzquierda;
        private System.Windows.Forms.Button btnTodosADerecha;
        private System.Windows.Forms.TextBox txtCargaItem;
        private System.Windows.Forms.ListBox lstListaIzquierda;
        private System.Windows.Forms.ListBox lstListaDerecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnoADerecha;
        private System.Windows.Forms.Button borrarDeDerecha;
    }
}