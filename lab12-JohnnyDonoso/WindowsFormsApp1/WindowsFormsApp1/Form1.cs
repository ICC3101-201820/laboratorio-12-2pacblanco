using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo1;


namespace WindowsFormsApp1
{
    public delegate void AgregarComidaDelegate(string nombre, int proteina, int carbohidrato, int grasa);
   
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            int proteinas = Convert.ToInt16(textBox2.Text);
            int grasas = Convert.ToInt16(textBox3.Text);
            int carbohidratos = Convert.ToInt16(textBox4.Text);

            if(OnAgregarComida!= null)
            {
                OnAgregarComida.Invoke(nombre, proteinas, carbohidratos, grasas);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           
        }

        public void AgregarComida(Comida comida)
        {
            listBox1.Items.Add(comida.nombre+"(carbohidratos: "+Convert.ToString(comida.carbohidratos)+",proteinas: "+Convert.ToString(comida.proteinas)+" , grasas: "+Convert.ToString(comida.grasas)+", calorias: "+Convert.ToString(comida.Calorias())+")");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
        }

        

       
    }
}
