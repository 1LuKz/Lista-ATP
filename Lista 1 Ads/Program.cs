int atividade;

Console.WriteLine("Digite o exercício que você deseja rodar de 1 a 8");
atividade = int.Parse(Console.ReadLine());

switch (atividade)
{
    case 1:
        // Exercício 1

        double alt, bas, dia, ar, pe;

        Console.WriteLine("Exercício 1");
        Console.WriteLine("Digite o valor da altura");
        alt = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da base");
        bas = double.Parse(Console.ReadLine());

        pe = 2 * (bas + alt);
        Console.WriteLine("O valor do perimetro é: " + pe);
        ar = (bas * alt);
        Console.WriteLine("O valor da area é: " + ar);
        dia = Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(alt, 2));
        Console.WriteLine("O valor da diagonal é: {0:F2}", dia);
        break;

    case 2:
        // Exercício 2

        double cat, cate, hip, catet, cateto;

        Console.WriteLine("Exercício 2");
        Console.WriteLine("Digite o valor do primeiro cateto");
        cat = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do segundo cateto");
        cate = double.Parse(Console.ReadLine());

        hip = Math.Sqrt(Math.Pow(cat, 2) + Math.Pow(cate, 2));
        Console.WriteLine("O valor da hipotenusa é: {0:F2}", hip);

        break;

    case 3:
        // Exercício 3

        double sm, qtd, kw, vp, vd;

        Console.WriteLine("Exercício 3");
        Console.WriteLine("Digite o valor do salário mínimo");
        sm = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de kilowatts do mês");
        qtd = double.Parse(Console.ReadLine());

        kw = (sm / 7) / 100;

        vp = qtd * kw;

        vd = 0.9 * vp;

        Console.WriteLine("O valor de Kw é: {0:F2}", kw);
        Console.WriteLine("O valor a pagar é: {0:F2}", vp);
        Console.WriteLine("O valor com desconto é: {0:F2}", vd);
        break;

    case 4:
        // Exercício 4

        double x1, x2, y1, y2, d;

        Console.WriteLine("Exercício 4");
        Console.WriteLine("Digite o valor do Primeiro X e o Primeiro Y");

        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do Segundo X e o Segundo Y");

        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Distância é: {0:F2}", d);
        break;

    case 5:
        // Exercício 5 

        double p, i, redimento;
        int n;

        Console.WriteLine("Exercício 5");
        Console.WriteLine("Digite o valor mensal");
        p = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a taxa");
        i = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade de meses");
        n = int.Parse(Console.ReadLine());

        redimento = p * ((Math.Pow(1 + i, n) - 1) / i);
        Console.WriteLine("Redimento final: {0:C2}", redimento);

        break;

    case 6:
        // Exercício 6

        int ax, a, b;

        Console.WriteLine("Exercício 6");
        Console.WriteLine("Digite o valor de A");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B");
        b = int.Parse(Console.ReadLine());

        ax = a;
        a = b;
        b = ax;

        Console.WriteLine("O valor de A agora é: " + a);
        Console.WriteLine("O valor de B agora é: " + b);
        break;

    case 7:
        // Exercício 7

        int diaa, mes, ano, tempo;

        Console.WriteLine("Exercício 7");
        Console.WriteLine("Digite o número de dias sem acidentes");
        tempo = int.Parse(Console.ReadLine());

        ano = tempo / 365;
        mes = (tempo % 365) / 30;
        diaa = (tempo % 365) % 30;

        Console.WriteLine($"São {ano} anos {mes} mêses e {diaa} dias");
        break;

    case 8:
        // Exercício 8

        int ce, de, un, numinv, num, soma, cen, deze, unid, som, mil, nuum;

        Console.WriteLine("Exercício 8");
        Console.WriteLine("Digite um número de 3 digitos");
        num = int.Parse(Console.ReadLine());

        ce = num / 100;
        de = (num % 100) / 10;
        un = num % 10;
        numinv = un * 100 + de * 10 + ce;
        soma = num + numinv;

        Console.WriteLine("A soma dos dois são " + soma);

        mil = soma / 1000;
        cen = (soma % 1000) / 100;
        deze = (soma % 100) / 10;
        unid = soma % 10;

        som = (mil * 0) + (cen * 1) + (deze * 2) + (unid * 3);

        Console.WriteLine("A soma dos números é: " + som);

        nuum = som % 10;

        Console.WriteLine("A multiplicações é: " + nuum);
        break;

    default:
        Console.WriteLine("Digite um número de 1 a 8");
        break;
}