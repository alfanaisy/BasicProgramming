using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string confirm = "yes";
            while (confirm == "yes")
            {
                Console.WriteLine(
                    "------ Input Number from 1-4 ------" +
                    "\n1. Body Mass Index" +
                    "\n2. Reprint Name" +
                    "\n3. Print Even's Character" +
                    "\n4. Sum the inputted array"
                );
                Console.WriteLine("Choose menu:");
                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please input a number!");
                }
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("------ Body Mass Index ------");
                        float beratBadan = 0;
                        float tinggiBadan = 0;
                        try
                        {
                            Console.WriteLine("Input weight: ");
                            beratBadan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input height: ");
                            tinggiBadan = Convert.ToInt32(Console.ReadLine());
                            tinggiBadan /= 100;
                            float BMI = beratBadan / (tinggiBadan * tinggiBadan);
                            if (BMI < 18.1)
                            {
                                Console.WriteLine("BMI : " + BMI.ToString("F2") + ". You're Underweight");
                            }
                            else if (BMI < 23.1)
                            {
                                Console.WriteLine("BMI : " + BMI.ToString("F2") + ". You're Normal");
                            }
                            else if (BMI < 28.1)
                            {
                                Console.WriteLine("BMI : " + BMI.ToString("F2") + ". You're Overweight");
                            }
                            else
                            {
                                Console.WriteLine("BMI : " + BMI.ToString("F2") + ". You're Obese");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please input a number only");
                        }
                        break;
                    case 2:
                        Console.WriteLine("------ Reprint Name ------");
                        Console.WriteLine("Input name:");
                        string nama = Console.ReadLine();
                        int j = 1;
                        for (int i = 0; i < nama.Length; i++)
                        {
                            Console.WriteLine("huruf ke " + j + " : " +nama[i]);
                            j++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("------ Print Even's Character ------");
                        Console.WriteLine("Input name:");
                        nama = Console.ReadLine();
                        for (int i = 0; i < nama.Length; i++)
                        {
                            if (i%2 != 0)
                            {
                                Console.WriteLine(nama[i]);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("------ Sum the inputted array ------");
                        Console.WriteLine("input array length:");
                        try
                        {
                            int inputLength = Convert.ToInt32(Console.ReadLine());
                            int[] input = new int[inputLength];
                            int sum = 0;
                            for (int i = 0; i < inputLength; i++)
                            {
                                input[i] = Convert.ToInt32(Console.ReadLine());
                                sum += input[i];
                            }
                            Console.WriteLine("Total sum : " + sum);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please input a number!");
                        }
                        break;
                    default:
                        Console.WriteLine("Please input from 1 to 4 only!");
                        break;
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Type \"Yes\" to continue program");
                confirm = Console.ReadLine().ToLower();
                Console.Clear();  
            }
        }
    }
}
