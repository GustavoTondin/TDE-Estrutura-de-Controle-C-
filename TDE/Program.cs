using Microsoft.VisualBasic;

Console.WriteLine("### Menu de Escolha ###");
Console.WriteLine("1 - Simulador de Caixa Eletrônico");
Console.WriteLine("2 - Calculadora Simples");
Console.WriteLine("3 - Jogo de Adivinhação");

Console.Write("Escolha uma opção: ");
int opc = Convert.ToInt32(Console.ReadLine());
switch (opc)
{
    case 1:
        double saldo_conta = 0.00;
        int op = 0;
        while (op != 4)
        {
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine($"O saldo da conta é: {saldo_conta}");
                    continue;
                case 2:
                        Console.Write("Quanto voce deseja sacar? : ");
                        double saque = Convert.ToDouble(Console.ReadLine());
                        if (saque > saldo_conta)
                        {
                            Console.WriteLine($"O valor de {saque} é maior que o seu saldo de: {saldo_conta}");
                        } else {
                            saldo_conta -= saque;
                            Console.WriteLine($"Saque realizado com sucesso!! O seu novo saldo é de: {saldo_conta}");
                        }
                    continue;
                case 3:
                    Console.Write("Quanto voce deseja Depositar? : ");
                    double depositar = Convert.ToDouble(Console.ReadLine());
                    saldo_conta += depositar;
                    Console.Write($"Deposito realizado com sucesso!! O novo saldo da conta é: {saldo_conta} \n");
                    continue;
                case 4:
                    Console.WriteLine("Fechando caixa.....");
                    break;
                default:
                    Console.WriteLine("Digite uma opção valida !!!");
                    continue;
            }
            break;
        }
        break;
    case 2:
        int operacao  = 0;
        while (true)
        {
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            operacao = Convert.ToInt32(Console.ReadLine());
            switch (operacao)
            {
            case 1:
                Console.Write("Digite um numero para somar: ");
                int s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite outro numero para somar: ");
                int s2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A soma dos numeros {s1} e {s2} é: {s1 + s2}");
                continue;
            case 2:
                Console.Write("Digite um numero para Multiplicar: ");
                int m1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite outro numero para multiplicar: ");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A multiplicação dos numeros {m1} e {m2} é: {m1 * m2}");
                continue;
            case 3:
                Console.Write("Digite um numero para Dividir: ");
                int d1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite outro numero para ser a base da divisão: ");
                int d2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A multiplicação dos numeros {d1} e {d2} é: {d1 / d2}");
                continue;
            case 4:
                Console.Write("Digite um numero para subtrair: ");
                int sub1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite outro numero para subtrair: ");
                int sub2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A subtração dos numeros {sub1} e {sub2} é: {sub1 - sub2}");
                continue;
            case 5:
                Console.WriteLine("Saind do programa...");
                break;
            default:
                Console.WriteLine("Digite uma opção valida !!!");
                continue;
            }
        break;
        }
        break;
    case 3:
        Random random = new Random();
        int contador = 10;
        int numero = random.Next(1, 100);  
        
        while (true)
        {
            Console.Write("Digite um número de 1 a 100 para adivinhar: ");
            string input = Console.ReadLine();
            

            if (!int.TryParse(input, out int escolha))
            {
                Console.WriteLine("Digite apenas números");
                continue;
            }

            if (escolha == numero)
            {
                Console.WriteLine($"Você acertou!! O número aleatório era {numero}");
                if (contador == 3)
                {
                    Console.WriteLine("Acertou de primeira, ta de hack!!");
                }
                break;
            }

            contador--;
            if (contador == 0)
            {
                Console.WriteLine("Você perdeu!!! Otario.");
                Console.WriteLine($"O número certo era {numero}");
                break;
            }

            if (escolha != numero)
            {
                Console.WriteLine($"Tente novamente! Você tem {contador} de vidas restantes");
                if (escolha > numero)
                {
                    Console.WriteLine($"O número aleatório é menor que {escolha}");
                }
                else if (escolha < numero)
                {
                    Console.WriteLine($"O número aleatório é maior que {escolha}");
                }
            }
        }
        break;
    default:
        Console.WriteLine("Digite uma opção valida !!!");
        break;
}