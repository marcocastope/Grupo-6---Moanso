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
            labelNombre.ForeColor = Color.Red;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var nombre = textBoxNombre.Text;
            var apellido = textBoxApellido.Text;
            var edad = textBoxEdad.Text;
            if( nombre != "" && apellido != "")
            {
                MessageBox.Show("Se registró una persona");
                listViewDatos.Items.Add(nombre);
                listViewDatos.Items.Add(apellido);
                listViewDatos.Items.Add(edad);
            } else
            {
                MessageBox.Show("Todos los campos son requeridos");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
