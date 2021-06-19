using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao(); 

            UsarSistema();

            Console.ReadLine(); 
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor nico = new Diretor("159.753.398-04");
            nico.Nome = "nico";
            nico.Senha = "123";

            GerenteDeConta maria = new GerenteDeConta("326.985.628-89");
            maria.Nome = "Maria";
            maria.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(nico, "123"); 
            sistemaInterno.Logar(maria, "abc");
        }

        public static void CalcularBonificacao() 
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario nico = new Diretor("159.753.398-04");
            nico.Nome = "Nicoly";

            Funcionario william = new Auxiliar("981.198.778-53");
            william.Nome = "William";

            Funcionario maria = new GerenteDeConta("326.985.628-89");
            maria.Nome = "Maria";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20"); 
            guilherme.Nome = "Guilherme"; 

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(nico);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(maria);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}