using Bite_Bank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bite_Bank.Funcionarios
{
    internal class GerenteConta : FuncionarioAutenticavel
    {

        public GerenteConta(string nome, string cpf, double salario, string senha) 
            : base(nome, cpf, salario, senha)
        {}

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AlmentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
