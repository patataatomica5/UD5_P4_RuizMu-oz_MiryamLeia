using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD5_P4_RuizMuñoz_MiryamLeia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        persona p1 = new persona();

        private void button1_Click(object sender, EventArgs e)
        {
            p1.setNombre(textBox1.Text);
            p1.setMarca(listBox1.SelectedItem.ToString());
            p1.setCilindrada(comboBox1.SelectedItem.ToString());

            if (radioButton1.Checked) {
                p1.setMotor("Diesel");
            } else if (radioButton2.Checked) {
                p1.setMotor("Electrico");
            } else if (radioButton3.Checked) {
                p1.setMotor("Gasolina");
            } else if (radioButton4.Checked) {
                p1.setMotor("Hibrido");
            }

            if (checkBox1.Checked) {
                p1.setMayorEdad(true);
            }

            p1.setFecha(maskedTextBox1.Text);

        }

        persona p2 = new persona();
        private void button2_Click(object sender, EventArgs e)
        {
            p2.setNombre(textBox1.Text);
            p2.setMarca(listBox1.SelectedItem.ToString());
            p2.setCilindrada(comboBox1.SelectedItem.ToString());

            if (radioButton1.Checked)
            {
                p2.setMotor("Diesel");
            }
            else if (radioButton2.Checked)
            {
                p2.setMotor("Electrico");
            }
            else if (radioButton3.Checked)
            {
                p2.setMotor("Gasolina");
            }
            else if (radioButton4.Checked)
            {
                p2.setMotor("Hibrido");
            }

            if (checkBox1.Checked)
            {
                p2.setMayorEdad(true);
            }

            p2.setFecha(maskedTextBox1.Text);

        }

        persona p3 = new persona();
        private void button3_Click(object sender, EventArgs e)
        {
            p3.setNombre(textBox1.Text);
            p3.setMarca(listBox1.SelectedItem.ToString());
            p3.setCilindrada(comboBox1.SelectedItem.ToString());

            if (radioButton1.Checked)
            {
                p3.setMotor("Diesel");
            }
            else if (radioButton2.Checked)
            {
                p3.setMotor("Electrico");
            }
            else if (radioButton3.Checked)
            {
                p3.setMotor("Gasolina");
            }
            else if (radioButton4.Checked)
            {
                p3.setMotor("Hibrido");
            }

            if (checkBox1.Checked)
            {
                p3.setMayorEdad(true);
            }

            p3.setFecha(maskedTextBox1.Text);
        }

        persona p4 = new persona();
        private void button4_Click(object sender, EventArgs e)
        {
            p4.setNombre(textBox1.Text);
            p4.setMarca(listBox1.SelectedItem.ToString());
            p4.setCilindrada(comboBox1.SelectedItem.ToString());

            if (radioButton1.Checked)
            {
                p4.setMotor("Diesel");
            }
            else if (radioButton2.Checked)
            {
                p4.setMotor("Electrico");
            }
            else if (radioButton3.Checked)
            {
                p4.setMotor("Gasolina");
            }
            else if (radioButton4.Checked)
            {
                p4.setMotor("Hibrido");
            }

            if (checkBox1.Checked)
            {
                p4.setMayorEdad(true);
            }

            p4.setFecha(maskedTextBox1.Text);
        }
        class persona{
            public String nombre;
            public String marca;
            public String cilindrada;
            public String motor;
            public Boolean mayorEdad;
            public String fecha;

            public persona() {
                
            }

            public void setNombre(String n) {
                nombre = n;
            }

            public void setMarca(String m) {
                motor = m;
            }

            public void setCilindrada(String c) {
                cilindrada = c;
            }

            public void setMotor(String mo)
            {
                motor = mo;
            }

            public void setMayorEdad(Boolean e)
            {
                mayorEdad = e;
            }

            public void setFecha(String f)
            {
                fecha = f;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
