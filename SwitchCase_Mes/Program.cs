using System;
using static System.Console;

namespace SwitchCase_Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;

            Write("Insira o mês do ano desejado: ");
            mes = Convert.ToInt32(ReadLine());

            switch(mes)
            {
                case 1:
                    WriteLine("Mês 01 -> Janeiro <- Com 31 dias");
                break;

                case 2:
                    WriteLine("Mês 02 -> Fevereiro <- Normalmente com 28 dias e 29 dias em ano bissexto");
                break;

                case 3:
                    WriteLine("Mês 03 -> Março <- Com 31 dias");
                break;

                case 4:
                    WriteLine("Mês 04 -> Abril <- Com 30 dias");
                break;

                case 5:
                    WriteLine("Mês 05 -> Maio <- Com 31 dias");
                break;

                case 6:
                    WriteLine("Mês 06 -> Junho <- Com 30 dias");
                break;

                case 7:
                    WriteLine("Mês 07 -> Julho <- Com 31 dias");
                break;

                case 8:
                    WriteLine("Mês 08 -> Agosto <- Com 31 dias");
                break;

                case 9:
                    WriteLine("Mês 09 -> Setembro <- Com 30 dias");
                break;

                case 10:
                    WriteLine("Mês 10 -> Outubro <- Com 31 dias");
                break;

                case 11:
                    WriteLine("Mês 11 -> Novembro <- Com 30 dias");
                break;

                case 12:
                    WriteLine("Mês 12 -> Dezembro <- Com 31 dias");
                break;

                default:
                    WriteLine("O mês inserido é inexistente!");
                break;
            }








        }
    }
}
