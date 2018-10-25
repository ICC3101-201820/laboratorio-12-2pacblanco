using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo1
{
    public class ListaComida
    {
        public List<Comida> comidita;

        public ListaComida()
        {
            comidita = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            comidita.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            comidita.Remove(comida);
        }
    }
}
