using System;

namespace velocmedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("----------------------");
            Console.WriteLine("Calculando Velocidade!");
            Console.WriteLine("----------------------");
            Console.ResetColor();
            double dt,tg;
            double f;
            Console.Write("Distância percorrida ---> ");
            Console.ForegroundColor=ConsoleColor.Magenta;
            dt=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Tempo percorrido ---> ");
            Console.ForegroundColor=ConsoleColor.Magenta;
            tg=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            f=(dt/tg);
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("Velocidade média = "+f);
            Console.ResetColor();
            Console.Beep();

        }
    }
}
