Console.WriteLine("Digite o exercício de 1 a 10 OBS: o exercício 1 e 2, e o exercício 8 e 9 estão no mesmo case");
int exercio = int.Parse(Console.ReadLine());

switch (exercio)
{

    case 1:

        // Exercício 1 e Exercício 2

        string repetir;
        int negativo = 0, positivo = 0, zero = 0, num, cont1 = 0, cont2 = 0, cont3 = 0;

        do
        {
            Console.WriteLine("Digite algum número positivo, negativo ou zero");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                positivo = num;
                positivo++;
                cont1++;
            }
            if (num < 0)
            {
                negativo = num;
                negativo++;
                cont2++;
            }
            if (num == 0)
            {
                zero = num;
                zero++;
                cont3++;
            }

            Console.WriteLine("Deseja continuar? (Sim/Não ou S/N)");
            repetir = Console.ReadLine();

        } while ((repetir == "Sim") || (repetir == "S"));

        Console.WriteLine("Valor do número positivo " + positivo);
        Console.WriteLine("Valor do número negativo " + negativo);
        Console.WriteLine("Valor do zero " + zero);
        Console.WriteLine("O percentual de vezes que números positivos foram contadados é : " + cont1);
        Console.WriteLine("O percentual de vezes que números negativos foram contados é : " + cont2);
        Console.WriteLine("O percentual de vezes que os zeros foram contados é : " + cont3);
        break;

    case 2:

        // Exercício 3 

        int cont = 0;
        double nume;

        do
        {
            cont++;

            Console.WriteLine("Digite um número");
            nume = double.Parse(Console.ReadLine());

            if (((nume % 2) == 0) && ((nume % 5) == 0))
            {
                Console.WriteLine("Seu número é divisível por 2 e por 5");
            }
            if (((nume % 3) == 0) && ((nume % 9) == 0))
            {
                Console.WriteLine("Seu número é divisível por 3 e por 9");
            }
            else
            {
                Console.WriteLine("Seu número não é divisível por 2, por 3, por 5 e nem por 9");
            }
        } while (cont < 10);

        break;

    case 3:

        // Exercício 4 

        int fatorial = 0;

        Console.Write("Digite um número natural: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i > 0; i--)
        {
            fatorial *= i;
        }

        break;


    case 4:

        // Exercício 5 

        double e = 1, fatorial1 = 1;

        Console.Write("Digite um valor inteiro e positivo para N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                fatorial1 *= j;
            }
            e += 1 / fatorial1;
        }

        break;


    case 5:
        // Exercício 6 

        int habitantes, filhos, mediah, mediaf, percen = 0, maior = 0, soma = 0, clt;

        Console.WriteLine("Digite a quantidade de habitantes que a cidade possui");
        habitantes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade pessoas que trabalham na cidade");
        clt = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de filhos que a cidade possui");
        filhos = int.Parse(Console.ReadLine());

        mediaf = habitantes / filhos;

        for (int i = 1; i < clt; i++)
        {
            Console.WriteLine("Digite o seu salário");
            int salario = int.Parse(Console.ReadLine());
            soma += salario;

            if (maior < salario)
            {
                maior = salario;
            }

            if (salario == 100)
            {
                percen++;
            }
        }

        Console.WriteLine("A média do salário dos habitates é : " + soma);
        Console.WriteLine("A média de filhos entre os habitantes é : " + mediaf);
        Console.WriteLine("O maior salário é : " + maior);
        Console.WriteLine("O percentual de pessoa com salário de 100 é : " + percen);
        break;


    case 6:

        // Exercício 7 

        int soma2 = 0, quant, termo;

        Console.WriteLine("Digite a quantidade de divisões");
        quant = int.Parse(Console.ReadLine());

        for (int i = 1; i < quant; i++)
        {
            termo = 1 / i;
            soma2 += termo;
        }

        Console.WriteLine("O valor do calculo das divisões é de : " + soma2);

        break;


    case 7:
        // Exercício 8 e Exercício 9

        int l, a = 0, b = 1, temp, somaFibonacci = 0;

        Console.WriteLine("Digite a quantidade de números da série de Fibonacci");
        l = int.Parse(Console.ReadLine());

        for (int i = 0; i < l; i++)
        {
            somaFibonacci += a;
            temp = a;
            a = b;
            b = temp + b;

            Console.WriteLine("O valor de b é : " + b);
        }

        Console.WriteLine("A soma da série Fibonacci é : " + somaFibonacci);

        break;


    case 8:

        // Exercício 10

        int compra = 1, somaCompra = 0, venda, somaVenda = 0, lucro, lucroTotal = 0;
        int contaluc1 = 0, contaluc2 = 0, contaluc3 = 0;

        while (compra == 0)
        {
            Console.WriteLine("Digite o valor da compra");
            compra = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do venda");
            venda = int.Parse(Console.ReadLine());

            somaCompra += compra;
            somaVenda += venda;

            lucro = ((venda - compra) / compra) * 100;


            if (lucro < 10)
            {
                contaluc1++;
                Console.WriteLine("A quantidade de mercadorias que tiveram o lucro menor que 10% é : " + contaluc1);
            }
            else if ((lucro >= 10) && (lucro <= 20))
            {
                contaluc2++;
                Console.WriteLine("A quantidade de mercadorias que tiveram o lucro entre 10% e 20% é : " + contaluc2);
            }
            else
            {
                contaluc3++;
                Console.WriteLine("A quantidade de mercadorias que tiveram o lucro maior que 20% é : " + contaluc3);
            }

            lucroTotal = ((somaVenda - somaCompra) / somaCompra) * 100;
            Console.WriteLine("O lucro total é de : " + lucroTotal);
            Console.WriteLine("A quantidade de compra total é de : " + somaCompra);
            Console.WriteLine("A quantidade de venda total é de : " + somaVenda);
        }
        break;


    case 9:

        // Exercício 11

        string votos;
        int votacao, cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, vn = 0, veb = 0; // Cand (São os candidatos), Vn (É voto nulo) e Veb (Votos em brancos)

        do
        {
            Console.WriteLine("Você deseja vota em qual candidato (Digite 1 / 2 / 3 / 4), caso deseja votar nulo (Digite 5), mas caso deseja votar em branco (Digite 6)");
            votacao = int.Parse(Console.ReadLine());

            if (votacao == 1)
            {
                cand1++;
            }
            if (votacao == 2)
            {
                cand2++;
            }
            if (votacao == 3)
            {
                cand3++;
            }
            if (votacao == 4)
            {
                cand4++;
            }
            if (votacao == 5)
            {
                vn++;
            }
            if (votacao == 6)
            {
                veb++;
            }
            else
            {
                Console.WriteLine("Por favor digite uma das opções");
            }

            Console.WriteLine("Quantidades de votos para o Candidato1 : " + cand1);
            Console.WriteLine("Quantidades de votos para o Candidato2 : " + cand2);
            Console.WriteLine("Quantidades de votos para o Candidato3 : " + cand3);
            Console.WriteLine("Quantidades de votos para o Candidato4 : " + cand4);
            Console.WriteLine("Quantidades de votos nulos : " + vn);
            Console.WriteLine("Quantidades de votos em branco : " + veb);

            Console.WriteLine("Deseja continuar? (Sim/Não)(S/N)");
            votos = Console.ReadLine();

        } while ((votos == "Sim") || (votos == "S"));
        break;

    default:
        Console.WriteLine("Digite um número de 1 a 10");
        break;
}
