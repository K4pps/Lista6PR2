using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program;

            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("\nQual o programa que voce deseja executar? \nDigite 0 para finalizar\n");
                program = int.Parse(Console.ReadLine());

                if (program == 0)
                {
                    break;
                }

                switch (program)
                {
                    case 1:
                        int q, qt;
                        double v, vt;
                        qt = 0;
                        q = 0;
                        vt = 0;

                        for (i = 0; ; i++)
                        {
                            Console.WriteLine("Digite a quantidade de produtos que deseja comprar");
                            q = int.Parse(Console.ReadLine());
                            if (q == 0)
                            {
                                break;
                            }
                            qt = qt + q;
                            Console.WriteLine("Digite a valor do produto que deseja comprar (preço da unidade)");
                            v = double.Parse(Console.ReadLine());
                            v = q * v;
                            vt = vt + v;
                        }
                        Console.WriteLine("A quantidade total de produtos é: " + qt + " E o valor total é: " + vt);
                        break;

                    case 2:
                        double vl, qq, vtt, vm, u, vmm;
                        string nom, nm, nmm;

                        Console.WriteLine("Digite o nome do produto (digite 'parar' para parar)");
                        nom = Console.ReadLine();
                        if (nom == "parar")
                        {
                            break;
                        }
                        Console.WriteLine("Digite o valor do produto por unidade");
                        vl = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o a quantidade do produto");
                        qq = double.Parse(Console.ReadLine());
                        vtt = qq * vl;
                        vm = vtt;
                        nm = nom;
                        vmm = vtt;
                        nmm = nom;
                        for (i = 0; ; i++)
                        {
                            Console.WriteLine("Digite o nome do produto (digite 'parar' para parar)");
                            nom = Console.ReadLine();
                            if (nom == "parar")
                            {
                                break;
                            }
                            Console.WriteLine("Digite o valor do produto por unidade");
                            vl = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o a quantidade do produto");
                            qq = double.Parse(Console.ReadLine());

                            vtt = qq * vl;

                            if (vtt > vm)
                            {
                                nm = nom;
                            }
                            if (vtt < vmm)
                            {
                                nmm = nom;
                            }
                        }
                        Console.WriteLine("O produto com maior investimento é: " + nm + " Com um investimento de R$" + vm + " E o de menor investimento é: " + nmm + " Com um investimento de R$" + vmm);

                        break;

                    case 3:
                        double na, pa, pt;

                        Console.WriteLine("Quantas avaliações terão neste bimestre?");
                        na = double.Parse(Console.ReadLine());
                        pt = 0;
                        for (i = 0; i < na; i++)
                        {
                            Console.WriteLine("Qual o peso das avaliações (ex: 3)");
                            pa = double.Parse(Console.ReadLine());
                            pt = pt + pa;
                        }

                        pt = pt * 10;

                        if (pt > 100)
                        {
                            Console.WriteLine("\nOs pesos ultrapassam 100%");
                            break;
                        }
                        if (pt == 100)
                        {
                            Console.WriteLine("\nOs pesos resultam em 100%");
                            break;
                        }
                        if (pt > 100)
                        {
                            Console.WriteLine("\nOs pesos nao atingem 100%");
                            break;
                        }
                        break;

                    case 4:
                        string estado;

                        Console.WriteLine("Digite a sigla do estado");
                        estado = Console.ReadLine();

                        switch (estado)
                        {
                            case "AC":
                                Console.WriteLine("O estado correspondente é: Acre");
                                break;
                            case "AL":
                                Console.WriteLine("O estado correspondente é: Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("O estado correspondente é: Amapá");
                                break;
                            case "AM":
                                Console.WriteLine("O estado correspondente é: Amazonas");
                                break;
                            case "BA":
                                Console.WriteLine("O estado correspondente é: Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("O estado correspondente é: Ceará");
                                break;
                            case "DF":
                                Console.WriteLine("Distrito Federal não é um estado, mas uma unidade da federação que possui competência legislativa de Estado e de Município");
                                break;
                            case "ES":
                                Console.WriteLine("O estado correspondente é: Espírito Santo");
                                break;
                            case "GO":
                                Console.WriteLine("O estado correspondente é: Goiás");
                                break;
                            case "MA":
                                Console.WriteLine("O estado correspondente é: Maranhão");
                                break;
                            case "MT":
                                Console.WriteLine("O estado correspondente é: Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("O estado correspondente é: Mato Grosso do Sul");
                                break;
                            case "MG":
                                Console.WriteLine("O estado correspondente é: Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("O estado correspondente é: Pará");
                                break;
                            case "PB":
                                Console.WriteLine("O estado correspondente é: Paraíba");
                                break;
                            case "PR":
                                Console.WriteLine("O estado correspondente é: Paraná");
                                break;
                            case "PE":
                                Console.WriteLine("O estado correspondente é: Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("O estado correspondente é: Piauí");
                                break;
                            case "RJ":
                                Console.WriteLine("O estado correspondente é: Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("O estado correspondente é: Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("O estado correspondente é: Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("O estado correspondente é: Rondônia");
                                break;
                            case "RR":
                                Console.WriteLine("O estado correspondente é: Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("O estado correspondente é: Santa Catarina");
                                break;
                            case "SP":
                                Console.WriteLine("O estado correspondente é: São Paulo");
                                break;
                            case "SE":
                                Console.WriteLine("O estado correspondente é: Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("O estado correspondente é: Tocantins");
                                break;

                            default:
                                Console.WriteLine("Não existe estado com essa sigla");
                                break;
                        }

                        break;

                    case 5:
                        int m, d;

                        Console.WriteLine("Digite o numero do mês: ");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("A estação correspondente a este mês é: verão");
                                break;

                            case 2:
                                Console.WriteLine("A estação correspondente a este mês é: verão");
                                break;

                            case 3:
                                Console.WriteLine("Qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 20 && d > 1)
                                    Console.WriteLine("A estação correspondente a este mês é: verão");
                                if (d >= 20 && d < 31)
                                    Console.WriteLine("A estação correspondente a este mês é: outono");
                                break;

                            case 4:
                                Console.WriteLine("A estação correspondente a este mês é: verão");
                                break;

                            case 5:
                                Console.WriteLine("A estação correspondente a este mês é: verão");
                                break;

                            case 6:
                                Console.WriteLine("Qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 21 && d > 1)
                                    Console.WriteLine("A estação correspondente a este mês é: outono");
                                if (d >= 21 && d < 30)
                                    Console.WriteLine("A estação correspondente a este mês é: inverno");
                                break;

                            case 7:
                                Console.WriteLine("A estação correspondente a este mês é: inverno");
                                break;

                            case 8:
                                Console.WriteLine("A estação correspondente a este mês é: inverno");
                                break;

                            case 9:
                                Console.WriteLine("Qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 23 && d > 1)
                                    Console.WriteLine("A estação correspondente a este mês é: inverno");
                                if (d >= 23 && d < 30)
                                    Console.WriteLine("A estação correspondente a este mês é: primavera");
                                break;

                            case 10:
                                Console.WriteLine("A estação correspondente a este mês é: primavera");
                                break;

                            case 11:
                                Console.WriteLine("A estação correspondente a este mês é: primavera");
                                break;

                            case 12:
                                Console.WriteLine("Qual é o dia?");
                                d = int.Parse(Console.ReadLine());
                                if (d < 22 && d > 1)
                                    Console.WriteLine("A estação correspondente a este mês é: primavera");
                                if (d >= 22 && d < 30)
                                    Console.WriteLine("A estação correspondente a este mês é: verão");
                                break;

                            default:
                                Console.WriteLine("O valor digitado é invalido");
                                break;
                        }
                        break;

                    case 6:
                        double alt, kg, imc;

                        Console.WriteLine("Digite sua altura em metros: ");
                        alt = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu peso em kg: ");
                        kg = double.Parse(Console.ReadLine());

                        imc = kg / (alt * alt);

                        if (imc < 18.5)
                        {
                            Console.WriteLine("Você está abaixo do peso");
                            break;
                        }
                        if (imc >= 18.5 && imc <= 24.9)
                        {
                            Console.WriteLine("Você está no peso normal");
                            break;
                        }
                        if (imc >= 25 && imc <= 29.9)
                        {
                            Console.WriteLine("Você está com sobrepeso");
                            break;
                        }
                        if (imc >= 30 && imc < 34.9)
                        {
                            Console.WriteLine("Você está com obesidade grau 1");
                            break;
                        }
                        if (imc >= 35 && imc < 39.9)
                        {
                            Console.WriteLine("Você está com obesidade grau 2");
                            break;
                        }
                        if (imc >= 40)
                        {
                            Console.WriteLine("Você está com obesidade grau 3");
                            break;
                        }

                        break;

                    case 7:
                        int num;

                        Console.WriteLine("digite um numero");
                        num = int.Parse(Console.ReadLine());

                        for (i = 1; i < num; i++)
                        {
                            if (num % i == 0)
                                Console.WriteLine(i);
                            else
                                i++;
                        }
                        break;

                    default:
                        Console.WriteLine("Número inválido");
                        break;
                }
            }
        }
    }
}
