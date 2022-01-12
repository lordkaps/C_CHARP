using Bite_Bank.Funcionarios;
using Bite_Bank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bite_Bank
{
    internal class Program
    {
        // Metodo Main eh estatico da Classe programa e não do objeto Programa.
        // Com isso só pode chamar outros metodos estaticos da classe program.
        // Para poder chamar metodos  do Objeto tem que instanciar o objeto programa (new Program) 
        // Com isso todo metodo criado dentro da classe Program, tem que ser do tipo STATIC
        static void Main(string[] args) 
        {
            Auxiliar carlos = new Auxiliar("Carlos", "12345678910", 2000);
            Diretor marcelo = new Diretor("Marcelo", "98765432100", "123.456/7891-00", 10000, "123");
            Designer joao = new Designer("Joao", "12345678910", 5000);
            GerenteConta vitor = new GerenteConta("Vitor", "12345678910", 6000, "abc");

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(marcelo, "111");
            sistema.Logar(vitor, "abc");

            Console.WriteLine("Total de funcionario = " + Funcionario.TotalFuncionarios);

            double total = marcelo.GetBonificacao() + carlos.GetBonificacao() 
                            + joao.GetBonificacao() + vitor.GetBonificacao();

            Console.WriteLine("Bonificacao Carlos: " + carlos.GetBonificacao());
            Console.WriteLine("Bonificacao Marcelo: " + marcelo.GetBonificacao());
            Console.WriteLine("Bonificacao Joao: " + joao.GetBonificacao());
            Console.WriteLine("Bonificacao Vitor: " + vitor.GetBonificacao());
            Console.WriteLine("Total = " + total);

            ParceiroComercial magazine = new ParceiroComercial("123");

            sistema.Logar(magazine, "122");

            //Testando git

        }




    }
}
