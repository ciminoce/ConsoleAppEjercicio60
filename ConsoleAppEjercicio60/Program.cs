using System;

namespace ConsoleAppEjercicio60
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaPares = 0, contadorImpares = 0;
            int extremoInferior, extremoSuperior;
            Console.Write("Ingrese un extremo del intervalo:");
            var numeroN = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el otro extremo del intervalo:");
            var numeroM = int.Parse(Console.ReadLine());
            if (numeroN>numeroM)
            {
                extremoInferior = numeroM;
                extremoSuperior = numeroN;
            }
            else
            {
                extremoInferior = numeroN;
                extremoSuperior = numeroM;
            }
            for (int contador = extremoInferior; contador <= extremoSuperior; contador++)
            {
                if (EsPar(contador))
                {
                    sumaPares += contador;
                }
                else
                {
                    contadorImpares++;
                }
            }
            Console.WriteLine($"La suma de pares es {sumaPares}");
            Console.WriteLine($"La cantidad de nros impares es {contadorImpares}");
            Console.ReadLine();
        }

        private static bool EsPar(int contador) => contador % 2 == 0;
        //{
        //    return contador % 2 == 0;
        //}
    }
}
