using System;

namespace arrayManipulation
{
    class Program
    {
        public static int SumaNumeros(int Numero1, int Numero2)
        {
            int Resultado;

            Resultado = Numero1 + Numero2;
            return Resultado;
        }
        static void Main(string[] args)
            
        {
            Console.WriteLine("Ingrese dos numeros: ");
            int Numero1 = Convert.ToInt32 (Console.ReadLine());
            int Numero2 = Convert.ToInt32 (Console.ReadLine());

            int Resultado = SumaNumeros(Numero1, Numero2);

            Console.WriteLine("El Resultado fue de:"+Resultado);


        }
    }
}
