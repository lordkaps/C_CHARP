using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bite_Bank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }   // metodo da classe e não do objeto
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }


        //construtor
        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
            TotalFuncionarios++;
        }

        // Abstract obriga as classes que herdam a criar metodo esses metodos para sobrescrever Colocando override.
        // Metodos abstratos só podem existir em classes abstratas. Pois só tem a declaração e não a implementação
        
        public abstract double GetBonificacao(); // Se vc criar uma classe que herda dessa tem que criar esse metodo.
        public abstract void AlmentarSalario(); // Mesma coisa

        // O virtual não obriga a sobrescrever o metodo nas classes que herdam dessa classe.
        // Se não possuir irá utilizar esse metodo nas classes filhas.
        public virtual void Teste()
        {
            return;
        }

    }
}
