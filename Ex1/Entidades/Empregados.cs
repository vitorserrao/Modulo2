using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entidades
{
     class Empregados
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Empregados(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public void Trabalhar(int hora)
        {
            Console.WriteLine($"Entrar {hora}h");
        }
        public void IrEmbora(int hora) 
        {
            Console.WriteLine($"Sair as {hora}h");
        }
        public void TirarFolga(string dia)
        {
            Console.WriteLine($"tirar folga no {dia}");
        }
    }
}
