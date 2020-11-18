using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
     public class Diretor : FuncionarioAutenticavel //Herança
    {

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //Variavel para sobreescrever o metodo da classe Funionario
        public override double GetBonificacao()
        {
            //base: A classe filha pode fazer referência aos membros da classe base com uso desta palavra reservada.
            return Salario * 0.5;
        }
    }
}
