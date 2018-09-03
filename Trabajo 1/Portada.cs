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
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargaPersonas ventana = new cargaPersonas();
            ventana.Show();
        }
    }
}
