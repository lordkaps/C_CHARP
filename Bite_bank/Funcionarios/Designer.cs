﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bite_Bank.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {}

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
        public override void AlmentarSalario()
        {
            Salario *= 1.11; 
        }
    }
}
