int exe;
Console.WriteLine("Digite uma ativadade de 1 a 10");
exe = int.Parse(Console.ReadLine());

switch (exe)
{

    case 1:
        // Exercício 1
        int n1, n2;

        Console.WriteLine("Digite dois números");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine("O primeiro número é maior " + n1);
        }
        else
        {
            Console.WriteLine("O segundo número é maior " + n2);
        }

        break;

    case 2:
        // Exercício 2
        int nu1, nu2, soma, som;

        Console.WriteLine("Digite dois números");
        nu1 = int.Parse(Console.ReadLine());
        nu2 = int.Parse(Console.ReadLine());

        soma = nu1 + nu2;

        if (soma >= 10)
        {
            som = soma + 5;
            Console.WriteLine("O resultado é:" + som);
        }

        else
        {
            som = soma + 7;
            Console.WriteLine("O resultado é: " + som);
        }

        break;

    case 3:
        // Exercício 3
        double a, b, z;

        Console.WriteLine("Digite o valor de A");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B");
        b = double.Parse(Console.ReadLine());

        if ( a > 0 ){
            z = -b / a ;
            Console.WriteLine("O valor de Z é: " + z);
        }

        else {
            Console.WriteLine("O valor de A não pode ser 0");
        }
        
        break;

    case 4:
        // Exercício 4
        int ano, anoa, sub;
        string ani;

        Console.WriteLine("Digite o ano em que você nasceu ");
        ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ano atual ");
        anoa = int.Parse(Console.ReadLine());

        sub = anoa - ano;

        Console.WriteLine("Você fez aniversario este ano? Responda usando S ou N");
        ani = Console.ReadLine();

        if (ani == "N")
        {

            sub--;

            if (sub >= 18)
            {
                Console.WriteLine($"Sua idade é {sub} você pode tirar habilitação");
            }
            else
            {
                Console.WriteLine($"Sua idade é {sub} você não pode tirar habilitação");
            }
        }

        else if (ani == "S")
        {
            if (sub >= 18)
            {
                Console.WriteLine($"Sua idade é {sub} você pode tirar habilitação");
            }
            else
            {
                Console.WriteLine($"Sua idade é {sub} você não pode tirar habilitação");
            }
        }

        else
        {
            Console.WriteLine("Digite se você fez aniversario ou não, usando S ou N");
        }

        break;

    case 5:
        // Exercício 5
        int nota;

        Console.WriteLine("Digite uma nota de 0 a 10");
        nota = int.Parse(Console.ReadLine());

        if ((nota >= 8) && (nota <= 10))
        {
            Console.WriteLine("Ótimo");
        }
        else if ((nota >= 7) && (nota < 8))
        {
            Console.WriteLine("Bom");
        }
        else if ((nota >= 5) && (nota < 7))
        {
            Console.WriteLine("Regular");
        }
        else if ((nota < 5) && (nota >= 0))
        {
            Console.WriteLine("Insatisfatório");
        }
        else
        {
            Console.WriteLine("Nota inválida");
        }

        break;

    case 6:
        // Exercício 6
        double hotel, desc, diaria, hotelp = 75, valordesc1, valordesc2, diferenca;

        Console.WriteLine("Digite o valor da diária");
        hotel = double.Parse(Console.ReadLine());
        diaria = hotel - (hotel * 0.25);
        valordesc1 = (hotelp * 0.80) * diaria;
        valordesc2 = (hotelp * 0.50) * hotel;

        if (valordesc1 > valordesc2)
        {
            diferenca = valordesc1 - valordesc2;
            Console.WriteLine("O valor da diferença é : " + diferenca);
        }
        else 
        {
            diferenca = valordesc1 - valordesc2;
            Console.WriteLine("O valor da diferença é : " + diferenca);
        }

        Console.WriteLine("O valor da diária com desconto : " + diaria);
        Console.WriteLine("O valor da diária com 80% : " + valordesc1);
        Console.WriteLine("O valor da diária com 50% : " + valordesc2);

        break;        

    case 7:
        // Exercício 7

        double y, x;
        Console.WriteLine("Digite o valor de X");
        x = double.Parse(Console.ReadLine());

        if (x <= 1)
        {
            y = 1 ;
            Console.WriteLine("O valor de Y é : " + y);
        }
        else if ((x > 1)&&(x <= 2)) 
        {
            y = 2;
            Console.WriteLine("O valor de Y é : " + y);
        }
        else if ((x > 2)&&(x <= 3))
        {
            y = Math.Pow(x , 2);
            Console.WriteLine("O valor de Y é : " + y);
        }
        else 
        {
            y = Math.Pow(x , 3);
            Console.WriteLine("O valor de Y é : " + y);
        }

        break;

    case 8:
        // Exercício 8
        string sala;
        double sal, saln;

        Console.WriteLine("Digite o valor do seu salário atual");
        sal = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite qual tipo de aumento que você que ter entre A, B ou C");
        sala = Console.ReadLine();

        switch (sala)
        {
            case "A":
                saln = sal + (sal * 0.08);
                Console.WriteLine("Seu novo salário é de: {0:C}", saln);

                break;

            case "B":
                saln = sal + (sal * 0.11);
                Console.WriteLine("Seu novo salário é de: {0:C}", saln);

                break;

            case "C":
                if (sal <= 1000)
                {
                    saln = sal + 350;
                    Console.WriteLine("Seu novo salário é de: {0:C}", saln);
                }
                else
                {
                    saln = sal + 200;
                    Console.WriteLine("Seu novo salário é de: {0:C}", saln);
                }

                break;

            default:
                Console.WriteLine("Por favor digite entre A, B ou C");
                break;
        }
        break;

    case 9:
        // Exercício 9
        string sinal;

        Console.WriteLine("Digite algum destes sinais: /, *, -, + ");
        sinal = Console.ReadLine();

        switch (sinal)
        {
            case "*":
                Console.WriteLine("Sinal de multiplicação");
                break;

            case "/":
                Console.WriteLine("Sinal de divisão");
                break;

            case "-":
                Console.WriteLine("Sinal de subtração");
                break;

            case "+":
                Console.WriteLine("Sinal de adição");
                break;

            default:
                Console.WriteLine("Outro sinal");
                break;
        }

        break;

    case 10:
        int velo;

        Console.WriteLine("Digite a velocidade atingida na avenida, sendo que o limite é de 110Km/h");
        velo = int.Parse(Console.ReadLine());

        if (velo >= 111){
            if ((velo >= 111) && (velo <= 120))
            {
                Console.WriteLine("Sua multa é de R$50,00");
            }
            else if ((velo >= 121) && (velo <= 140))
            {
                Console.WriteLine("Sua multa é de R$100,00");
            }
            else {
                Console.WriteLine("Sua multa é de R$200,00");
            }
        }
        else if ((velo >= 65) && (velo <= 110)){
            Console.WriteLine("Motorista respeitou as lei de transito");
        }
        else {
            Console.WriteLine("A velocidade está abaixo da velocidade mínima");
        }

        break;

    default:
        Console.WriteLine("Por favor digite um número entre 1 e 10");
        break;
}
