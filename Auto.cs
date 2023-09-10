
namespace ConsoleApp1
{
    class Auto
    {
        public string? marca;
        public int modelo;


        //Sobre carga de Constructor

        public Auto(string marca, int modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public void imprimir()
        {
            Console.WriteLine($"Marca: {marca} , Modelo: {modelo}");
        }

        //Sobrecarga de Metodos
        public double velocidad = 0;

        public double acelerar()
        {
            return velocidad += 10;
        }
        public double acelerar(int valor)
        {
            return velocidad += valor;
        }

        public double acelerar(double coeficiente)
        {
            return velocidad += coeficiente;
        }

    }
}
