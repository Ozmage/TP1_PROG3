using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_1
{
    public partial class cargaPersonas : Form
    {
        public cargaPersonas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + txtNombre.Text + "\r\n" +
                            "Apellido: " + txtApellido.Text + "\r\n" +
                            "Fecha de Nacimiento: " + fechaNacimiento.Text + "\r\n" +
                            "Sexo: " + btnFemenino.Checked + "\r\n" +
                            "Edad: " + edadValor.Text + "\r\n" +
                            "Estilos musicales preferidos: " + lstMusica.Text + "\r\n" +
                            "Color favorito: " + txtColor.Text + "\r\n"
                             );
            Text = "Segunda Ventana";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            edadValor.Text = (DateTime.Today.AddTicks(-fechaNacimiento.Value.Ticks).Year - 1).ToString();


        }

        private void edadValor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string genero = btnFemenino.Checked == true ? "Femenino" : "Masculino";
            string musica = string.Empty;
            foreach (var item in lstMusica.SelectedItems)
            {
                musica += item.ToString() + ",";
            }

            string datos = $"Nombre: { txtNombre.Text}{Environment.NewLine}Apellido: { txtApellido.Text}{Environment.NewLine}Fecha de Nacimiento: { fechaNacimiento.Text}{Environment.NewLine}Edad: { edadValor.Text} años{Environment.NewLine}Sexo: { genero}{Environment.NewLine}Estilo musical favorito: {musica}{Environment.NewLine}Color preferido: {txtColor.Text}{Environment.NewLine}";
            MessageBox.Show(datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Portada ventana = new Portada();
            ventana.Show();
            this.Close();
        }

        private void cargaPersonas_Load(object sender, EventArgs e)
        {
            string[] myMusic = new string[] { "Cumbia", "Rock", "metal", "clasica", "Tango", "Reggae" };

            lstMusica.Items.AddRange(myMusic);
        }

        private void lstMusica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class persona
            {
            public persona()
            {

            }
            public string Nombre { get; set; }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}