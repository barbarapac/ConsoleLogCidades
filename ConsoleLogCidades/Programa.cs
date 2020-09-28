using System;
using System.Collections.Generic;

namespace ConsoleLogCidades
{
    public class Programa
    {
        private static List<Cidade> listaCidades = new List<Cidade> {
            (new Cidade() { Nome = "Curitiba", UF = new UF() { Sigla = "PR" } }),
            (new Cidade() { Nome = "Francisco Beltrão", UF = new UF() { Sigla = "PR" } }),
            (new Cidade() { Nome = "São Paulo", UF = new UF() { Sigla = "SP" } }),
            (new Cidade() { Nome = "Floripa", UF = new UF() { Sigla = "SC" } })
        };

        public static List<Cidade> BuscaCidade(string uf)
        {
            return listaCidades.FindAll(a => a.UF.Sigla == uf);
        }
        public static void Consulta()
        {
            string repetir = "0";
            do
            {
                Console.WriteLine("Digite uma UF: ");
                string uf = Console.ReadLine();

                List<Cidade> cidades = BuscaCidade(uf.ToUpper());
                if (cidades.Count > 0)
                {
                    foreach (Cidade cidade in cidades)
                    {
                        Console.WriteLine("Cidade: " + cidade.Nome + ", Estado: " + cidade.UF.Sigla);
                    }
                }
                else
                {
                    Console.WriteLine("Cidade não encontrada!");
                }

                Console.WriteLine("Deseja buscar mais cidade? Digite 1, caso contrario, digite 0!");
                repetir = Console.ReadLine();
            } while (repetir != "0");
        }
    }
}
