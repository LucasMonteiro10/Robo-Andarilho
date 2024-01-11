using System;

namespace RoboAndarilho.Models;
class Program
{
    static void Main()
    {
        string velocidades = Console.ReadLine();

        int vmin = int.Parse(velocidades.Split(' ')[0]);
        int vmax = int.Parse(velocidades.Substring(velocidades.LastIndexOf(' ') + 1));

        Robo r = new Robo(vmin, vmax);

        string comandos = Console.ReadLine();

        for (int i = 0; i < comandos.Length; i++)
        {
            switch (comandos[i])
            {
                case 'A':
                    r.Acelerar();
                    break;
                case 'D':
                    r.Desacelerar();
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"{r.VelocidadeAtual}");
    }
}