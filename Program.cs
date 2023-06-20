using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09EstoqueDeProdrutos
{
    class Program
    {
        static void Main(string[] args)
        {
            ///List<string> produtos = new List<string>();
            ///
            List<string> produtos = new List<string> {"Pepsi","Fanta" };

            

            Console.WriteLine(" \n\n Bem-Vindo ao Conradito Store");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();


                if (resposta == "1" )
                {
                    Console.WriteLine("Digite o nome do produto: ");
                    string produto = Console.ReadLine();

                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Este item já existe na lista...");
                    }


                    else
                    {


                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado");



                    }



                    
                }
                else
                {

                    string texto = "";

                    int contador = 0;
                    while (contador < produtos.Count)
                    {
                        texto += produtos[contador] + ", ";

                        Console.WriteLine(texto); 
                        contador++;
                    }
                   texto=  texto.Substring(0, texto.Length-2);

                    Console.WriteLine(texto);
                }

            }


            Console.ReadKey();
        }
    } 
}
