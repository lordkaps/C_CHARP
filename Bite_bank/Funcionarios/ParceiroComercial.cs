using Bite_Bank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bite_Bank.Funcionarios
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; private set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public ParceiroComercial(string senha) { Senha = senha; }   
    }
}
