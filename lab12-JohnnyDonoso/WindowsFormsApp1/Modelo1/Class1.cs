namespace Modelo1
{
    public class Comida
    {
        public string nombre;
        public int carbohidratos, proteinas, grasas;

        public Comida(string nombre,int carbohidratos, int proteinas, int grasas)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.proteinas = proteinas;
            this.grasas = grasas;
        }

        public int Calorias()
        {
            int caloria = 4 * carbohidratos + 4 * proteinas + 9 * grasas;
            return caloria;
        }
    }
}
