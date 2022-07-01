using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entidades
{
    class SalarioEmpregado : Empregados

    {
        public int codigoFuncionario { get; set; }
        public double valorSalario { get; set; }
    

        public SalarioEmpregado(int id, string nome,int codigoFuncionario, double valorSalario) : base(id,nome)
        {
            this.codigoFuncionario = codigoFuncionario;
            this.valorSalario = valorSalario;
        }

        public void CalcularFolhaPagamento(int dias)
        {
            double salario = dias * valorSalario;
            Console.WriteLine(salario);
        }
    }
}
