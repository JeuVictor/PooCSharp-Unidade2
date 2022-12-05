using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atidade1
{
    internal class Carros
    {
		private string Placa;

		public string placa
		{
			get { return Placa; }
			set { Placa = value; }
		}
		private string Cor;

		public string cor
		{
			get { return Cor; }
			set { Cor = value; }
		}
		private string RENAVAM;

		public string renavam
		{
			get { return RENAVAM; }
			set { RENAVAM = value; }
		}
		private string Modelo;

		public string modelo
		{
			get { return Modelo; }
			set { Modelo = value; }
		}
		private string Marca;

		public string MyProperty
		{
			get { return Marca; }
			set { Marca = value; }
		}
		public int indice;
		private string ACAO;

		public string acao
		{
			get { return ACAO; }
			set { ACAO = value; }
		}
		public int Ativ;
		public bool interrupitor= true;
		public string parada;

		public void Dados()
		{
            Console.WriteLine("Digite a COR do "+indice+"° carro: " );
            this.Cor = Console.ReadLine();
            Console.WriteLine("Digite RENAVAM do " + indice + "° carro: ");
            this.RENAVAM = Console.ReadLine(); 
            Console.WriteLine("Digite a PLACA do " + indice + "° carro: ");
            this.Placa = Console.ReadLine();
            Console.WriteLine("Digite O MODELO do " + indice + "° carro: ");
            this.Modelo = Console.ReadLine();
            Console.WriteLine("Digite a MARCA do " + indice + "° carro: ");
            this.Marca = Console.ReadLine();
        }

		public void CarroX()
		{
			
			Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Placa:" + placa);
            Console.WriteLine("RENAVAM: " + renavam);
            Console.WriteLine("Cor: "+cor);
			Console.WriteLine("____________________________________");
			Console.WriteLine("");
        }
		public void Acelerar()
		{
			
			ACAO = ACAO.ToUpper();
			if (acao =="ACELERAR")
			{
				Console.WriteLine("O carro está acelerando");
			}

		}
		public void Frear()
		{
            acao = acao.ToUpper();
            if (acao == "FREAR")
            {
                Console.WriteLine("O carro está freando");
            }
			
        }




	}
}
