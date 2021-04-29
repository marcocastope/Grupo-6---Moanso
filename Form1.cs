using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoansoTarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            String sexo;
            sexo = cmbSexo.Text;

            var nombre = textBoxNombre.Text;
            var apellido = textBoxApellido.Text;
            var edad = textBoxEdad.Text; 

            if( nombre != "" && apellido != "")
            {
                MessageBox.Show("Se registró una persona");
                listViewDatos.Items.Add(nombre);
                listViewDatos.Items.Add(apellido);
                listViewDatos.Items.Add(edad);

                listViewDatos.Items.Add(sexo);

            } else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listViewDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
