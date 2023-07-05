namespace ejercicioseudoprueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio :");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el altura :");
            double altura = double.Parse(Console.ReadLine());
            if (altura > 0 && altura < 100)
            {
                if (radio > 0 && radio < 100)
                {
                    double generatriz = resultadogene(altura, radio);
                    double area = informacionarea(radio, generatriz);
                    double volumen = informacionvolumen(radio, altura);
                    Console.WriteLine($"El volumen del cono es {volumen}");
                    Console.WriteLine($"El area del cono es {area}");
                }
                else
                {
                    Console.WriteLine("El radio es menor a 0 o es mayor a 100");
                }
            }
            else 
            {
                Console.WriteLine("El altura es menor a 0 o es mayor a 100");
            }
        }

        private static double informacionvolumen(double radio, double altura) 
        {
            return (Math.PI * Math.Pow(radio,2) * altura) / 3;
        }

        private static double informacionarea(double radio, double generatriz)
        {
            return Math.PI * radio * (radio+generatriz);
        }

        private static double resultadogene(double altura, double radio)
        {
            return Math.Sqrt(Math.Pow(altura,2)+Math.Pow(radio,2));
        }
    }
}