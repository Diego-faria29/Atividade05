using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFutebol_01
{
    class Program
    {
        static void Main(string[] args)
        {


            Time time1 = new Time("Palmeiras");
            time1.contratarJogador(new Jogador("Alex",    20, 99, 1, 0));
            time1.contratarJogador(new Jogador("Pedro",   22, 96, 2, 0));
            time1.contratarJogador(new Jogador("Leandro", 27, 91, 3, 1));
            time1.contratarJogador(new Jogador("Bruno",   21, 90, 4, 0));
            time1.contratarJogador(new Jogador("Jorge",   23, 92, 5, 1));
            time1.contratarJogador(new Jogador("Eleno",   30, 97, 6, 3));
            time1.contratarJogador(new Jogador("Rodrigo", 33, 80, 7, 2));
            time1.contratarJogador(new Jogador("Antonio", 29, 88, 8, 0));
            time1.contratarJogador(new Jogador("Miguel",  25, 79, 9, 1));
            time1.contratarJogador(new Jogador("Luciano", 28, 98, 10, 0));
            time1.contratarJogador(new Jogador("Alencar", 38, 95, 11, 1));

            Time time2 = new Time("Santos");
            time2.contratarJogador(new Jogador("Juliano", 20, 99, 1, 1));
            time2.contratarJogador(new Jogador("Matias",  22, 96, 2, 0));
            time2.contratarJogador(new Jogador("Roberto", 27, 91, 3, 0));
            time2.contratarJogador(new Jogador("Carlos",  21, 90, 4, 0));
            time2.contratarJogador(new Jogador("Renato",  23, 92, 5, 0));
            time2.contratarJogador(new Jogador("Fabiano", 30, 97, 6, 0));
            time2.contratarJogador(new Jogador("Regis",   33, 80, 7, 0));
            time2.contratarJogador(new Jogador("Otavio",  29, 88, 8, 0));
            time2.contratarJogador(new Jogador("Marcio",  25, 79, 9, 0));
            time2.contratarJogador(new Jogador("Wilson",  28, 98, 10, 0));
            time2.contratarJogador(new Jogador("Marcos",  38, 95, 11, 0));

            
            Partida p1 = new Partida(DateTime.Now, time1, time2);
            Console.WriteLine("Jogando...");
            Console.WriteLine(p1.getPlacar());
            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores1();

            Console.WriteLine(time2.getStatus());
            time2.getDescricaoJogadores1();

            Console.ReadKey();
        }
    }
}
