using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atidade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1: Crie uma classe de nome Carro e atribua a ela todas as propriedades que você acredita que um carro possua. Instancie a classe Carro e preencha 3 objetos distintos. \r\nImprima na tela do usuário todos os atributos dos três carros.\r\n");
            Console.WriteLine("");
            Console.WriteLine("Questão 2: Pesquise como um criar um método específico dentro de uma classe em C#. Crie dois métodos para a classe Carro criada na questão anterior. Um método chamado Acelerar(), que retorna a string “O carro está em movimento” como resposta e outro método Freiar() que também retorna uma string “O carro está parado” como resposta.\r\n");
            Console.WriteLine("");
            Console.WriteLine("Digite se gostaria de ir para atividade 1 ou 2");
            Carros Atividade = new Carros();
            Atividade.Ativ = int.Parse(Console.ReadLine());
            if (Atividade.Ativ == 1)
            {
                Carros carro1 = new Carros();
                carro1.indice = 1;
                carro1.Dados();

                Carros carro2 = new Carros();
                carro2.indice = 2;
                carro2.Dados();

                Carros carro3 = new Carros();
                carro3.indice = 3;
                carro3.Dados();

                Console.Clear();
                carro1.CarroX();
                carro2.CarroX();
                carro3.CarroX();
                Console.ReadKey();
            }
           
            else
            { while (Atividade.interrupitor == true)
                {
                    Console.WriteLine("Digite 'ACELERAR' para acelerar o carro ou 'FREAR' para frear: ");
                    Atividade.acao = Console.ReadLine();
                    Atividade.Acelerar();
                    Atividade.Frear();
                    Console.WriteLine("Deseja encerrar? Se sim digite 'SAIR' ");
                    Atividade.parada = Console.ReadLine();
                    Atividade.parada = Atividade.parada.ToUpper();
                    if (Atividade.parada == "SAIR")
                    { Atividade.interrupitor = false; }
                    else { Console.Clear(); }
                }
               
                
                
            }
           
        }
    }
}
