using Banco.Model;

namespace Banco
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
           
            int opcao = 0;

            Conta c1 = new Conta(1,123, 1, "Gaspar", 1000000.00M);

            c1.Visualizar();
            c1.SetNumero(345);
            c1.Visualizar();

            c1.Sacar(1000);

            c1.Visualizar();

            c1.Depositar(5000);

            c1.Visualizar();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                                                        ");
                Console.WriteLine("                BANCO DO BRAZIL COM Z                   ");
                Console.WriteLine("                                                        ");
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                                                        ");
                Console.WriteLine("            1 - Criar Conta                             ");
                Console.WriteLine("            2 - Listar todas as contas                  ");
                Console.WriteLine("            3 - Buscar contas por numero                ");
                Console.WriteLine("            4 - Atualizar dados da conta                ");
                Console.WriteLine("            5 - Apagar Contas                           ");
                Console.WriteLine("            6 - Sacar                                   ");
                Console.WriteLine("            7 - Depositar                               ");
                Console.WriteLine("            8 - Transferir valores entre Contas         ");
                Console.WriteLine("            9 - Sair                                    ");
                Console.WriteLine("                                                        ");
                Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("Entre com a opção desejada:                             ");
                Console.WriteLine("                                                        ");

                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (opcao == 9)               
                {
                   Console.WriteLine("\nBanco do Brazil com Z - O seu Futuro começa aqui!");
                   Sobre();
                   System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Crie sua conta: \n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lista das contas criadas:\n\n ");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Busca das contas por números:\n\n ");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualização dos dados da conta:\n\n ");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar as contas:\n\n ");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Saque:\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Depósito:\n\n ");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 8:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Transferencia dos valores entre as contas:\n\n ");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção inválida");
                        Console.ResetColor();

                        KeyPress();
                        break;                    
                }
            }

        }
        static void Sobre()
        {
             Console.WriteLine("\n*********************************************************\n");
             Console.WriteLine("Projeto Desenvolvido por: Lucas Ribeiro Paixão");
             Console.WriteLine("lucasrib01@gmail.com");
             Console.WriteLine("github.com/apaixav");
             Console.WriteLine("\n*********************************************************");

        }

        static void KeyPress()
        {
            do
            {

                Console.WriteLine("Pressione enter para continuar!");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);

        }
    }
}