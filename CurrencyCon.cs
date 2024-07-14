using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class CurrencyCon
    {
        public static void CurrencyConv()
        {
            double input = 0;

            Console.WriteLine("\nChoose Currency Converter:");
            string[] currency = new string[] { "Php - Philippine Peso to USD - United States Dollar ($)",
"Php - Philippine Peso to EUR (€) - Euro",
"Php - Philippine Peso to GBP (£) - British Pound Sterling",
"Php - Philippine Peso to JPY (¥) - Japanese Yen",
"Php - Philippine Peso to CAD (A$) - Canadian Dollar",
"Php - Philippine Peso to AUD (C$) - Australian Dollar",
"Php - Philippine Peso to CHF (Fr) - Swiss Franc",
"Php - Philippine Peso to CNY (元) - Chinese Yuan Renminbi",
"Php - Philippine Peso to INR (₹) - Indian Rupee",
"Php - Philippine Pesoto SGD (S$) - Singapore Dollar",
"Php - Philippine Peso to MXN (Mex$) - Mexican Peso",
"Php - Philippine Peso to NZD (NZ$) - New Zealand Dollar",
"Php - Philippine Peso to HKD (HK$) - Hong Kong Dollar",
"Php - Philippine Peso to SEK (kr) - Swedish Krona",
"Php - Philippine Peso to KRW (₩) - South Korean Won"};
            Console.WriteLine("**********************************************************");

            for (int i = 0; i < currency.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {currency[i]}");
            }
            Console.WriteLine("**********************************************************");

            Console.WriteLine("\nSelect the number you want to use in Converting unit:");
            int convertc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nProcessing please wait..................");
            Console.WriteLine("**********************************************************");
            Console.Clear();
            string answer=Currencyresults(input, convertc);

            string[] historyconverter = new string[] { "\n**History Converter**",
                                                   "Category Converter: Currency Converter",
                                                   $"Time Converter selectionn you choose:{currency[convertc-1]}",
                                                   $"Number that the user input: {input}",
                                                   $"{answer}",
            "****************************************************"};


            foreach (var item in historyconverter)
            {
                Console.WriteLine(item);
            }

        }
        public static string Currencyresults(double input, int convertc )
        {
            string answer = "";
            switch (convertc)
            {
                case 1:
                    double USD = input * 50;
                    answer = $"The answer is $ {USD}, USD. ";
                    break;
                case 2:
                    double EUK = input * 0.016;
                    answer = $"The answer is € {EUK}, EUK. ";
                    break;
                case 3:
                    double GPB = input * 74.9758;
                    answer = $"The answer is £ {GPB}, GPB. ";
                    break;
                case 4:
                    double JPY = input * 2.15;
                    answer = $"The answer is ¥ {JPY}, JPY. ";

                    break;
                case 5:
                    double CAD = input * 0.019;
                    answer = $"The answer is C$ {CAD}, CAD. ";
                    break;
                case 6:
                    double AUD = input * 0.020;
                    answer = $"The answer is A$ {AUD}, AUD. ";

                    break;
                case 7:
                    double CHF = input * 0.015;
                    answer = $"The answer is Fr {CHF}, CHF. ";
                    break;
                case 8:
                    double CNY = input * 0.11;
                    answer = $"The answer is 元 {CNY}, CNY. ";
                    break;
                case 9:
                    double INR = input * 1.23;
                    answer = $"The answer is ₹ {INR}, INR. ";
                    break;
                case 10:
                    double SGD = input * 0.020;
                    answer = $"The answer is S$ {SGD}, SGD.";
                    break;
                case 11:
                    double MXN = input * 0.30;
                    answer = $"The answer is Mex$ {MXN}, SGDN.";
                    break;
                case 12:
                    double NZD = input * 0.021;
                    answer = $"The answer is NZ$ {NZD}, NZD.";
                    break;
                case 13:
                    double HKD = input * 0.12;
                    answer = $"The answer is HK$ {HKD}, HKD.";
                    break;
                case 14:
                    double SEK = input * 0.16;
                    answer = $"The answer is kr {SEK}, SEK.";
                    break;
                case 15:
                    double KRW = input * 2.24;
                    answer = $"The answer is ₩ {KRW}, KRW";
                    break;
                default:
                    Console.WriteLine("Invalid Input.......");
                    break;
            }
            return answer;
        }
    }
}
