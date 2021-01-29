using System;
using System.Collections.Generic;
using System.Threading;

namespace Pepe_esercizio2_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire numero corrridori!");
            int c = int.Parse(Console.ReadLine());
            List<string> nomi = new List<string>();
            for(int i =0;i<=c;i++)
            {
                Console.WriteLine("inserisci il nome del concorente!");
                string nome = Console.ReadLine();
                nomi.Add(nome);
                Thread t = new Thread(() => Corri(nome));
                t.Start();
            }
        }
        static void Corri(string nome)
        {
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine($"Il partecipante {nome} è al km {i + 1}.");
            }
            Console.WriteLine($"Il partecipante {nome} è arrivato al km 100 e ha terminato la corsa.");

        }
    }
}
