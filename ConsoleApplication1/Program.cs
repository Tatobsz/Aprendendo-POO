using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    class ProgramPrincipal
    {
        static void Main(string[] args)
        {           
            int opcao = 1;
            Conta conta = new Conta();

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Qual serviço deseja realizar");                
                Console.WriteLine("1 - Deposito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Verificar saldo");
                Console.WriteLine("4 - Abrir conta");
                Console.WriteLine("5 - Fechar conta");
                Console.WriteLine("0 - SAIR");
                int menu = Int32.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("----------DEPÓSITO----------\n");
                        Console.Write("Agência: ");
                        Int32 ag = Int32.Parse(Console.ReadLine());

                        Console.Write("Conta: ");
                        Int32 ct = Int32.Parse(Console.ReadLine());

                        conta.testeConta(ct, ag);

                        Console.Write("Digite o valor depositado: ");
                        conta.deposito(float.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("----------SAQUE----------\n");
                        Console.Write("Agência: ");
                        ag = Int32.Parse(Console.ReadLine());

                        Console.Write("Conta: ");
                        ct = Int32.Parse(Console.ReadLine());

                        conta.testeConta(ct, ag);

                        Console.Write("Digite o valor do saque: ");
                        conta.saque(float.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("----------SALDO----------\n");
                        Console.Write("Agência: ");
                        ag = Int32.Parse(Console.ReadLine());

                        Console.Write("Conta: ");
                        ct = Int32.Parse(Console.ReadLine());

                        conta.testeConta(ct, ag);                        
                        
                        Console.WriteLine("O seu saldo total é de: {0}", conta.saldo_C);
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("----------ABERTURA DE CONTA----------\n");
                        Console.Write("Digite seu nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite seu rg: ");
                        Int32 rg = Int32.Parse(Console.ReadLine());
                        conta.abrirConta(nome, rg);
                        Console.WriteLine("Senhor(a) {0}, sua conta foi aberta com sucesso", conta.nome_C);
                        Console.WriteLine("Agência numero: {0}\nConta numero: {1}",conta.agencia_C, conta.numero_C);
                        Console.ReadLine();
                        break;

                    case 5:
                        conta.fecharConta();
                        break;


                    case 0:
                        break;
                }
                Console.Clear();
                Console.WriteLine("1 - Voltar ao menu\n0 - Sair");
                opcao = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
