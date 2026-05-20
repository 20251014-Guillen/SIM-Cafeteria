namespace ConsoleApp35
{
    class Bebida
    {

        // Atributos privados

        private string nombre;

        private string tamaño;

        private double precio;

        // Constructor

        public Bebida(string nombre, string tamaño, double precio)

        {

            this.nombre = nombre;

            this.tamaño = tamaño;

            this.precio = precio;

        }

        // Método que RETORNA el mensaje

        public string Preparar()

        {

            return "Preparando un " + nombre + " tamaño " + tamaño + "...";

        }

        // Método para aplicar descuento

        public void AplicarDescuento(double porcentaje)

        {

            double descuento = precio * (porcentaje / 100);

            precio = precio - descuento;

        }

        // Método que RETORNA descripción

        public string MostrarDescripcion()

        {

            return "Esto es un " + nombre +

                   " de tamaño " + tamaño +

                   " con un costo de $" + precio;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, tamaño;

            double precio;

            // ===== BEBIDA 1 =====

            Console.WriteLine("Ingrese el nombre de la bebida 1:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño:");

            tamaño = Console.ReadLine();

            Console.WriteLine("Ingrese el precio:");

            precio = Convert.ToDouble(Console.ReadLine());

            Bebida bebida1 = new Bebida(nombre, tamaño, precio);

            // ===== BEBIDA 2 =====

            Console.WriteLine("\nIngrese el nombre de la bebida 2:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño:");

            tamaño = Console.ReadLine();

            Console.WriteLine("Ingrese el precio:");

            precio = Convert.ToDouble(Console.ReadLine());

            Bebida bebida2 = new Bebida(nombre, tamaño, precio);

            // ===== BEBIDA 3 =====

            Console.WriteLine("\nIngrese el nombre de la bebida 3:");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tamaño:");

            tamaño = Console.ReadLine();

            Console.WriteLine("Ingrese el precio:");

            precio = Convert.ToDouble(Console.ReadLine());

            Bebida bebida3 = new Bebida(nombre, tamaño, precio);

            // Aplicar descuento

            bebida1.AplicarDescuento(10);

            // Mostrar preparación

            Console.WriteLine("\n" + bebida1.Preparar());

            Console.WriteLine(bebida2.Preparar());

            Console.WriteLine(bebida3.Preparar());

            // Mostrar descripción

            Console.WriteLine("\n--- DESCRIPCIÓN DE BEBIDAS ---");

            Console.WriteLine(bebida1.MostrarDescripcion());

            Console.WriteLine(bebida2.MostrarDescripcion());

            Console.WriteLine(bebida3.MostrarDescripcion());

            Console.ReadKey();

        }
    }
    
}
