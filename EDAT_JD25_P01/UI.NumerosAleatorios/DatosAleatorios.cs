using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.NumerosAleatorios
{
    public partial class DatosAleatorios : Form
    {
        private DatosRandom Dr = new DatosRandom();
        public DatosAleatorios()
        {
            InitializeComponent();
        }

        private void DatosAleatorios_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Además, cambia la declaración de la lista en button1_Click para que use el nombre completo del tipo:
        private void button1_Click_Click(object sender, EventArgs e)
        {
            Dr.generar();
            List<Empleadoo.Empleado> l = Dr.listaempleados();

            if (l.Count > 0)
            {
                Empleadoo.Empleado e1 = l[0];

                tb_Numero.Text = e1.Numero.ToString();
                tb_Nombre.Text = e1.Nombre;
                sueldo.Text = e1.Salario.ToString();
                fecha.Value = e1.FechaNacimiento;
                comboBox1.Text = e1.Grupo.ToString();
                m.Checked = e1.Sexo;
                f.Checked = !e1.Sexo;
                sm.Checked = e1.Seguro;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
