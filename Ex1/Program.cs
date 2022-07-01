using System;

namespace Ex1.Entidades
{

    class Program
    {
        static void Main(string[] arg)
        {
            Empregados Vitor = new Empregados(01, "Vitor");
            Console.WriteLine(Vitor.nome);
            Vitor.Trabalhar(9);
            Vitor.IrEmbora(18);
            Vitor.TirarFolga("Quarta");

            SalarioEmpregado Brenda = new SalarioEmpregado(02,"Brenda",02,15.00);
            Console.WriteLine(Brenda.nome );
            Brenda.CalcularFolhaPagamento(30);

            Secretaria Josué = new Secretaria(03, "josué", 03, 15.00,3);
            Console.WriteLine(Josué.nome);
            Josué.AtenderCliente();
            Josué.RealizarLigacoes();


        }
    }
}