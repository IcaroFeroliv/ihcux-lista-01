using System;

namespace ListaExercicios1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================");
            Console.WriteLine("        FAÇA SEU PEDIDO!        ");
            Console.WriteLine("================================");
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Gray;
            // Heurística #1 (Visibilidade do Status)
            Console.WriteLine("[Passo 1 de 3]");
            Console.ResetColor();
            Console.Write("Entrando no Sistema");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                // Console.Clear();
            }

            FazerPedido();

        }

        static void FazerPedido()
        {
            try
            {
                Console.Clear();
                // Heurística #1 (Visibilidade do Status)
                Console.WriteLine("===============================");
                Console.WriteLine("[Passo 2 de 3]");
                Console.WriteLine("===============================");
                Console.WriteLine(" ");
                Console.WriteLine("Informe o Produto que deseja comprar(Caso deseje sair selecione 0):");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Cachorro Quente");
                Console.WriteLine("2 - X-Salada");
                Console.WriteLine("3 - X-Burguer");
                Console.WriteLine("4 - Refri");
                Console.WriteLine("5 - Suco");
                Console.WriteLine(" ");
                Console.Write("Digite o código do produto: ");
                string input = Console.ReadLine();
                int codigoProduto = int.Parse(input);


                // Heurística #3 (Controle e Liberdade)
                if (codigoProduto == 0)
                {   
                    // Heurística #3: Validação de entrada para código do produto
                    Console.WriteLine("Saindo do sistema...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                if (codigoProduto < 1 || codigoProduto > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Código do produto invalido!");
                    Console.WriteLine("Codigo informado: " + codigoProduto);
                    Console.WriteLine("Nosso Código vão de 1 a 5. Informe um codigo Valido!");
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    FazerPedido(); 
                    
                }
                else
                {
                    InformarQuantidade();

                }

            }
            // Heurística #9 (Ajuda e Erros)
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Informe um codigo Valido!");
                Console.ResetColor();
                
                // Heurística #1 (Visibilidade do Status)
                Console.Write("Voltando para o menu");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                FazerPedido();
            }
        }

        static void InformarQuantidade()
        {
            Console.Clear();
            // Heurística #1 (Visibilidade do Status)
            Console.WriteLine("===============================");
            Console.WriteLine("[Passo 3 de 3]");
            Console.WriteLine("===============================");
            Console.WriteLine(" ");
           
            Console.Write("Informe a quantidade desejada do produto selecionado(caso deseje voltar selecione 0): ");
            string input = Console.ReadLine();
            int quantidade = int.Parse(input);
            try
            {
                // Heurística #3 (Controle e Liberdade)
                if (quantidade == 0)
                {
                    Console.Write("Voltando para Seleção do Produto");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    FazerPedido();
                }
                else if (quantidade < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quantidade Invalida!");
                    Console.WriteLine("Quantidade informada: " + quantidade);
                    Console.WriteLine("Informe uma quantidade maior que 0!");
                    // Heurística #1 (Visibilidade do Status)
                    Console.Write("Voltando para informa a quantidade");
                    for (int i = 0; i < 3; i++)                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    Console.ResetColor();
                    InformarQuantidade();
                }
                else
                {
                    FinalizarPedido();
                }
            }
            // Heurística #9 (Ajuda e Erros)
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Informe uma quantidade Valida!");
                Console.ResetColor();
                
                // Heurística #1 (Visibilidade do Status)
                Console.Write("Voltando para informa a quantidade");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                InformarQuantidade();
            }
        }

        static void FinalizarPedido()
        {

            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("       Finalizar Pedido!      ");
            Console.WriteLine("===============================");
            Console.WriteLine(" ");
            
            // Heurística #3 (Controle e Liberdade)
            Console.Write("Confirmar que deseja finalizar o pedido? (S/N): ");
            string input = Console.ReadLine();
            if (input == "S" || input == "s")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pedido Finalizado com Sucesso!");
                Console.ResetColor();
                // Heurística #3 (Controle e Liberdade)
                Console.WriteLine("Deseja voltar ou sair do sistema? (S para Sair / N para fazer um novo pedido)");
                string input2 = Console.ReadLine();
                if (input2 == "S" || input2 == "s")
                {
                    // Heurística #1 (Visibilidade do Status)
                    Console.Write("Saindo do sistema");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    Environment.Exit(0);
                }
                if (input2 == "N" || input2 == "n")
                {
                    // Heurística #1 (Visibilidade do Status)
                    Console.Write("Voltando para fazer um novo pedido");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    FazerPedido();
                }
                // Heurística #9 (Ajuda e Erros)
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada Invalida!");
                    Console.WriteLine("Entrada informada: " + input2);
                    Console.WriteLine("Informe S para Sair ou N para Voltar ao Menu!");
                    Console.ResetColor();
                    // Heurística #1 (Visibilidade do Status)
                    Console.Write("Voltando para finalizar o pedido");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                    FinalizarPedido();
                }
            }
            else if (input == "N" || input == "n")
            {   
                // Heurística #1 (Visibilidade do Status)
                Console.Write("Voltando para a quantidade do produto");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                InformarQuantidade();
            }
            // Heurística #9 (Ajuda e Erros)
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada Invalida!");
                Console.WriteLine("Entrada informada: " + input);
                Console.WriteLine("Informe S para Sim ou N para Não!");
                Console.ResetColor();
                // Heurística #1 (Visibilidade do Status)
                Console.Write("Voltando para finalizar o pedido");
                for (int i = 0; i < 3; i++)                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }

                FinalizarPedido();
            }
        }
            
    }
}

