using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistema.Logar(parceiro, "123456");
            sistema.Logar(roberta, "1234");
            sistema.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("164.464.146-85");
            guilherme.Nome = "Guilherme";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(guilherme);

            Console.WriteLine("Total de bonificação do mês: " + gerenciador.GetTotalBonificacao());
        }
    }
}
