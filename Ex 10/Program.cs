﻿namespace Ex_10
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                int dia, mes, ano;
                Console.Write("Entre com o dia: ");
                dia = Int32.Parse(Console.ReadLine());
                Console.Write("Entre com o mês: ");
                mes = Int32.Parse(Console.ReadLine());
                Console.Write("Entre com o ano: ");
                ano = Int32.Parse(Console.ReadLine());
                if (ano < 1900)
                {
                    Console.WriteLine("Ano inválido");
                    return;
                }

                switch (mes)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if ((dia < 1 || dia > 30))
                        {
                            Console.WriteLine("Dia inválido");
                        }
                        break;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if ((dia < 1 || dia > 31))
                        {
                            Console.WriteLine("Dia inválido");
                        }
                        break;
                    case 2:
                        if ((ano % 4) == 0)
                        {
                            if ((dia < 1 || dia > 29))
                            {
                                Console.WriteLine("Dia inválido");
                            }
                        }
                        else
                        {
                            if ((dia < 1 || dia > 28))
                            {
                                Console.WriteLine("Dia inválido");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Mês inválido");
                        break;

                }
            }
        }
    }

    
