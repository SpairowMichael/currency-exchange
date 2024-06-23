using System;
using System.Collections.Concurrent;
using System.Text;

namespace learn
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Currency Exchanger
            // Currencies: UAH, USD, EUR

            // exchange rate by 23.06.2024

            // Moneys in wallet
            float hryvniasInWallet;
            float dollarsInWallet;
            float eurosInWallet;

            // rates
            int uahToUsd = 40, usdToUah = 40;
            int uahToEur = 43, eurToUah = 43;
            float eurToUsd = 1.07f, usdToEur = 0.94f;

            float exchangeCurrencyCount;

            string desiredExchange;
            string desiredOperation;

            Console.WriteLine("Welcome to currency exchange.");
            
            Console.Write("UAH ballance: ");
            hryvniasInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("USD ballance: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("EUR ballance: ");
            eurosInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - UAH-USD");
            Console.WriteLine("2 - UAH-EUR");
            Console.WriteLine("3 - EUR-USD");

            Console.WriteLine("Choose the desired exchange: ");
            desiredExchange = Console.ReadLine();

            switch (desiredExchange) 
            {
                //uah-usd
                case "1":
                    Console.WriteLine("1 - UAH to USD");
                    Console.WriteLine("2 - USD to UAH");

                    Console.Write("Choose the desired operation: ");
                    desiredOperation = Console.ReadLine();

                    switch (desiredOperation)
                    {
                        case "1":
                            Console.WriteLine("UAH to USD");
                            Console.Write("How many you want to exchange: ");

                            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                            if (hryvniasInWallet >= exchangeCurrencyCount)
                            {
                                hryvniasInWallet -= exchangeCurrencyCount;
                                dollarsInWallet += exchangeCurrencyCount / uahToUsd;

                                Console.WriteLine($"{hryvniasInWallet} грн, ${dollarsInWallet}");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;

                        case "2":
                            Console.WriteLine("USD to UAH");
                            Console.Write("How many you want to exchange: ");

                            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                            if (dollarsInWallet >= exchangeCurrencyCount)
                            {
                                dollarsInWallet -= exchangeCurrencyCount;
                                hryvniasInWallet += exchangeCurrencyCount * usdToUah;

                                Console.WriteLine($"{hryvniasInWallet}грн, ${dollarsInWallet}");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;
                    }
                    break;

                //uah-eur
                case "2":
                    Console.WriteLine("1 - UAH to EUR");
                    Console.WriteLine("2 - EUR to UAH");

                    Console.Write("Choose the desired operation: ");
                    desiredOperation = Console.ReadLine();

                    switch (desiredOperation)
                    {
                        case "1":
                            Console.WriteLine("UAH to EUR");
                            Console.Write("How many you want to exchange: ");

                            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                            if (hryvniasInWallet >= exchangeCurrencyCount)
                            {
                                hryvniasInWallet -= exchangeCurrencyCount;
                                eurosInWallet += exchangeCurrencyCount / uahToEur;

                                Console.WriteLine($"{hryvniasInWallet} грн, E{eurosInWallet}");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;

                        case "2":
                            Console.WriteLine("EUR to UAH");
                            Console.Write("How many you want to exchange: ");

                            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                            if (eurosInWallet >= exchangeCurrencyCount)
                            {
                                eurosInWallet -= exchangeCurrencyCount;
                                hryvniasInWallet += exchangeCurrencyCount * eurToUah;

                                Console.WriteLine($"{hryvniasInWallet}грн, E{eurosInWallet}");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;
                    }
                    break;

                //eur-usd
                case "3":
                    Console.WriteLine("1 - EUR to USD");
                    Console.WriteLine("2 - USD to EUR");

                    Console.Write("Choose the desired operation: ");
                    desiredOperation = Console.ReadLine();

                    switch (desiredOperation)
                    {
                        case "1":
                            Console.WriteLine("EUR to USD");
                            Console.Write("How many you want to exchange: ");

                            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                            if (eurosInWallet >= exchangeCurrencyCount)
                            {
                                eurosInWallet -= exchangeCurrencyCount;
                                dollarsInWallet += Convert.ToSingle(exchangeCurrencyCount * eurToUsd);

                                Console.WriteLine($"E{eurosInWallet}, ${dollarsInWallet}");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;

                        case "2":
                            Console.WriteLine("USD to EUR");
                            Console.Write("How many you want to exchange: ");

                            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                            if (dollarsInWallet >= exchangeCurrencyCount)
                            {
                                dollarsInWallet -= exchangeCurrencyCount;
                                eurosInWallet += Convert.ToSingle(exchangeCurrencyCount * usdToEur);

                                Console.WriteLine($"E{eurosInWallet}, ${dollarsInWallet}");
                            }
                            else
                            {
                                Console.WriteLine("error");
                            }
                            break;
                    }
                    break;
            }
        }
    }
}