using Bite_Bank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bite_Bank.Funcionarios
{
    internal class Diretor : FuncionarioAutenticavel
    {
        public string CNPJ { get; private set; }
        public Diretor(string nome, string cpf, string cnpj ,double salario, string senha) 
            : base(nome, cpf, salario, senha)
        {
            CNPJ = cnpj;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AlmentarSalario()
        {
            //Salario = Salario + (Salario * 0.15);
            Salario *= 1.15; 
        }
    }
}
