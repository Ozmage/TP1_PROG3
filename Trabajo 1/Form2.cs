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
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCargaItem.Text))
            {

                MessageBox.Show("Debe completar la informacion");
                return;
            }

            
            // Pregunto si en la lista de la izquierda existe lo que estoy ingresando
            if (lstListaIzquierda.Items.Contains(txtCargaItem.Text)==true) 
            {
                MessageBox.Show("Esta cosa ya existe, ingresá una nueva"); 
            }
            else // Si no existe
            {
                lstListaIzquierda.Items.Add(txtCargaItem.Text);       // Agrego el texto del txtbox a la lista
                txtCargaItem.Clear();                     // Borro el textbox
               
            }

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string listaIzquierda = lstListaIzquierda.GetItemText(lstListaIzquierda.SelectedItem);
            if (string.IsNullOrEmpty(listaIzquierda))
            {
                 // Si la lista de la izquierda no tiene items
                if (lstListaIzquierda.Items.Count == 0)
                {
                    MessageBox.Show("La lista de la izquierda está vacia");
                    return;
                }

            }

            //////////////////////////////////////////////////////////////////////////
            
            if (lstListaIzquierda.Items.Contains(lstListaDerecha.Items) == true)
                            
            {
                MessageBox.Show("Este item ya existe en la DERECHA");
                return;
            }
            else
            {
                lstListaDerecha.Items.AddRange(lstListaIzquierda.Items);    // Muevo TODO de izquierda a derecha
                lstListaIzquierda.Items.Clear();                            // Borro TODO de la Izquierda luego de copiarlo
            }
               
            
        }

        private void btnUnoADerecha_Click(object sender, EventArgs e)
        {
            //Creo una string con el contenido de la lista
            string listaIzquierda = lstListaIzquierda.GetItemText(lstListaIzquierda.SelectedItem);
            //Si la lista (seleccion) está vacia
            if (string.IsNullOrEmpty(listaIzquierda))
            {
                MessageBox.Show("Selecciona un item para mover");
                return;
            }
                       

            // Pregunto si en la lista de la DERECHA existe lo SELECCIONADO en la IZQUIERDA
            if (lstListaDerecha.Items.Contains(lstListaIzquierda.SelectedItem) == true)
            {
                MessageBox.Show("Este item ya existe en la DERECHA");
                return;
            }

            lstListaDerecha.Items.Add(lstListaIzquierda.SelectedItem);    // Muevo UNO de izquierda a derecha
            lstListaIzquierda.Items.Remove(lstListaIzquierda.SelectedItem); // BORRO EL SELECCIONADO QUE SE MOVIO
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstListaDerecha.Items.Remove(lstListaDerecha.SelectedItem); // BORRO EL SELECCIONADO 
        }

        private void btnMoverDerecha_Click(object sender, EventArgs e)
        {
            //Creo una string con el contenido de la lista
            string listaDerecha = lstListaDerecha.GetItemText(lstListaDerecha.SelectedItem);
            //Si la lista (seleccion) está vacia
            if (string.IsNullOrEmpty(listaDerecha))
            {
                MessageBox.Show("Selecciona un item para mover");
                return;
            }

            // Pregunto si en la lista de la IZQUIERDA existe lo SELECCIONADO en la DERECHA
            if (lstListaIzquierda.Items.Contains(lstListaDerecha.SelectedItem) == true)
            {
                MessageBox.Show("Este item ya existe en la IZQUIERDA");
                return;
            }


            lstListaIzquierda.Items.Add(lstListaDerecha.SelectedItem);    // Muevo UNO de izquierda a derecha
            lstListaDerecha.Items.Remove(lstListaDerecha.SelectedItem); // BORRO EL SELECCIONADO QUE SE MOVIO
        }
    }
}
