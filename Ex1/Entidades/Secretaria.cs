using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entidades
{
     class Secretaria : SalarioEmpregado
    {
        public int qtdAnosEmpresa { get; set; }
        public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int qtdAnosEmpresa) : base(id, nome,codigoFuncionario, valorSalario)
        {
            this.qtdAnosEmpresa = qtdAnosEmpresa;
        }

        public void AtenderCliente() { Console.WriteLine("atendendo cliente...."); }
        public void RealizarLigacoes() { Console.WriteLine("fazendo ligações...."); }

    }
}
