using ConsumindoApi.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsumindoApi
{
     class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe o CEP:");
            int cep = int.Parse(Console.ReadLine());

            CepService cepServices = new CepService();

            CepModel cepEncontrado = await cepServices.Integracao(cep);

            if (!cepEncontrado.Verificacao)
            {
                Console.WriteLine("o Cep foi encontrado");

                Console.WriteLine($"Cep:{cepEncontrado.Cep}");
                Console.WriteLine($"Logradouro:{cepEncontrado.Logradouro}");
                Console.WriteLine($"Complemento:{cepEncontrado.Complemento}");
                Console.WriteLine($"Bairro:{cepEncontrado.Bairro}");
                Console.WriteLine($"Localidade:{cepEncontrado.Localidade}");
                Console.WriteLine($"UF:{cepEncontrado.UF}");
                Console.WriteLine($"IBGE:{cepEncontrado.IBGE}");
                Console.WriteLine($"GIA:{cepEncontrado.GIA}");
                Console.WriteLine($"DDD:{cepEncontrado.DDD}");
                Console.WriteLine($"Siafi:{cepEncontrado.Siafi}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"O cep {cep} não foi encontrado");
            }


        }
    }
}
