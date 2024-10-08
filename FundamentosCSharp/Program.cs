using System;
using System.Globalization;

namespace FundamentosCSharp
{
    class Program
    {
        static void Main()
        {
            // Mensagem de boas-vindas
            Message message = new Message();

            Console.WriteLine("Olá, para que possamos te ajudar digite seu nome: ");
            message.Nome = Console.ReadLine();

            Console.WriteLine("Obrigada! Agora digite seu sobrenome: ");
            message.Sobrenome = Console.ReadLine();

            message.Welcome();
            Console.WriteLine("###################################################");

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Operações Matemáticas");
                Console.WriteLine("2. Contador de Caracteres");
                Console.WriteLine("3. Verificar Placa");
                Console.WriteLine("4. Exibir Data em Diferentes Formatos");
                Console.WriteLine("5. Sair");

                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 5)
                {
                    Console.WriteLine("Obrigado! Volte sempre.");
                    break;
                }

                switch (escolha)
                {
                    case 1:
                        OperacoesMatematicas();
                        break;
                    case 2:
                        ContadorDeCaracteres();
                        break;
                    case 3:
                        VerificarPlaca();
                        break;
                    case 4:
                        ExibirData();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("###################################################");
            }

            Console.WriteLine("Obrigado por usar nossos serviços.");
        }

        static void OperacoesMatematicas()
        {
            OperacoesMatematicas operacao = new OperacoesMatematicas();

            while (true)
            {
                Console.WriteLine("Agora vamos realizar uma 'Operação Matemática', escolha uma das opções.");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Média");
                Console.WriteLine("6. Voltar ao menu principal");

                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 6)
                {
                    break;
                }

                Console.WriteLine("Vamos começar, digite os números para realizar a operação.");
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (escolha)
                {
                    case 1:
                        resultado = operacao.Somar(num1, num2);
                        break;
                    case 2:
                        resultado = operacao.Subtracao(num1, num2);
                        break;
                    case 3:
                        resultado = operacao.Multiplicacao(num1, num2);
                        break;
                    case 4:
                        resultado = operacao.Divisão(num1, num2);
                        break;
                    case 5:
                        resultado = operacao.Media(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        continue;
                }

                Console.WriteLine($"O resultado da operação é: {resultado}");
            }
        }

        static void ContadorDeCaracteres()
        {
            ContadorString contador = new ContadorString();

            Console.WriteLine("Olá, agora digite uma ou mais palavras: ");
            string input = Console.ReadLine();

            int quantidadedeCaracteres = contador.ContarCaracteres(input);
            Console.WriteLine($"A quantidade de caracteres na palavra inserida é: {quantidadedeCaracteres} caracter(es).");
        }

        static void VerificarPlaca()
        {
            ValidaPlaca validaPlaca = new ValidaPlaca();

            Console.WriteLine("Digite a placa do seu veículo: ");
            string placa = Console.ReadLine();

            bool placaValida = validaPlaca.IsPlaca(placa);

            if (placaValida)
            {
                Console.WriteLine("Sua placa é válida!");
            }
            else
            {
                Console.WriteLine("Sua placa é inválida.");
            }
        }

        static void ExibirData()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção para exibir a data atual:");
                Console.WriteLine("1. Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
                Console.WriteLine("2. Apenas a data no formato '10/08/2024'");
                Console.WriteLine("3. Apenas a hora no formato de 24 horas");
                Console.WriteLine("4. A data com o mês por extenso");
                Console.WriteLine("5. Voltar ao menu principal");

                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 5)
                {
                    break;
                }

                DateTime dataAtual = DateTime.Now;

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss", new CultureInfo("pt-BR")));
                        break;
                    case 2:
                        Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));
                        break;
                    case 3:
                        Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm"));
                        break;
                    case 4:
                        Console.WriteLine("Data com o mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}
