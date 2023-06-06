using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaAula300523
{
    class Program
    {
        static void Main(string[] args)
        {
            string Primeiro_Nome;
            string Segundo_Nome;
            int idade;

            Console.WriteLine("Digite o seu Primeiro nome: ");
            Primeiro_Nome = Console.ReadLine();

            Console.WriteLine("Agora digite o seu Segundo nome: ");
            Segundo_Nome = Console.ReadLine();


            //Permite que o usurario escreva (Lê oque foi digitaldo)
            //sempre retorna um TEXTO
            Console.WriteLine("Agora digite o sua idade: ");
            idade = Int32.Parse (Console.ReadLine());

            //Converte numero em texto



            // Se vc quiser guardar um NUMERO que a pessoa digitou
            // Combine os Dois comandos
            //Int32.Parse(Console.ReadLine( ));

            Console.WriteLine($"Seja bem vindo {Primeiro_Nome} {Segundo_Nome} ");
            Console.WriteLine($"Você tem {idade} anos!");

            Console.ReadLine();
        }


        void Atividade()
        {
            float lanche = 8.00f;
            float salsicha = 1.50f;
            float hamburger = 2.00f;
            float requeijão = 1.50f;
            float bacon = 2.00f;

            float x_tudo = lanche + hamburger + bacon + salsicha;
            float cachorro_quente = lanche + salsicha + salsicha + requeijão;
            float A_moda_da_casa = lanche + salsicha + hamburger + requeijão + bacon;

            Console.WriteLine("Bem-Vindo ao catálogo digital do Conradito Lanches");
            Console.WriteLine("Confira os valores:");
            Console.WriteLine($"X-Tudo: hamburguer, bacon e salsicha - R$ {x_tudo}");
            Console.WriteLine($"Cachorro-quente cremoso: 2 salsichas e requeijão - R$ {cachorro_quente}");
            Console.WriteLine($"A moda da casa: salsicha, hamburger, requeijão e bcon - R$ {A_moda_da_casa}");

            Console.WriteLine("\n\n\n");


            Console.WriteLine($"COMBO: X-Tudo + Cachorro-quente cremoso + A moda da casa - R$ {x_tudo + cachorro_quente + A_moda_da_casa}");




            Console.Read();
        }

    }
}
