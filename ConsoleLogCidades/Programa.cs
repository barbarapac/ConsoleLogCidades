using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLogCidades
{
    public class Programa
    {
        private static List<Cidade> listaCidades;

        public class UF
        {
            public string Sigla { get; set; }
            public string NomeUF { get; set; }
        }
        public class Cidade
        {
            public UF UF { get; set; }
            public string Nome { get; set; }
        }

        public Programa()
        {
            listaCidades = new List<Cidade>();
            listaCidades.Add(new Cidade() { Nome = "Curitiba", UF = new UF() { Sigla = "PR" } });
            listaCidades.Add(new Cidade() { Nome = "São Paulo", UF = new UF() { Sigla = "SP" } });
            listaCidades.Add(new Cidade() { Nome = "Floripa", UF = new UF() { Sigla = "SC" } });
        }

        public static Cidade BuscaCidade(string uf)
        {
            var cidade = listaCidades.Where(a => a.UF.Sigla == uf).FirstOrDefault();
            if (cidade == null)
                throw new Exception("Cidade não encontrada!");
            return cidade;
        }
        public static void Consulta()
        {
            //Programa p = new Programa();
            var cidade = BuscaCidade("PR");
            Console.WriteLine("Cidade: " + cidade.Nome);
            var uf = cidade.UF;
            Console.WriteLine("Estado: " + uf.Sigla);
            uf = null; // Liberar memória
        }
    }
}
