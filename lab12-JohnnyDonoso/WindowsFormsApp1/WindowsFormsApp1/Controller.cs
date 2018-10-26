using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo1;

namespace WindowsFormsApp1
{
    public class Controller
    {
        public Form1 form1;
        public ListaComida lista;
        public Controller()
        {
            lista = new ListaComida();
        }

        public void OnAgregarComida(string nombre, int proteina, int carbohidrato, int grasa)
        {
            Comida comida = new Comida(nombre, carbohidrato, proteina, grasa);
            lista.Agregar(comida);
            form1.AgregarComida(comida);
        }   
    }
}
