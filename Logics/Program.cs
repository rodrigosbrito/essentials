using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logics
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Odd-Even
            //2-Check Vowel err
            //3-Count Vowels and Consonants
            //4-Leap Year
            //5-Factorial
            //6-HCF & LCM
            //7-Decimal to Binary
            //8-Summation of n numbers
            //9-Swapping with & without 3rd Variable
            //10-Reverse
            //11-Check Armstrong
            //12-Fibonacci Series
            //13-Remove Blank Space
            //14-Floyd's Triangle
            //15-Pascal's Triangle
        Restart:
            Console.WriteLine("Enter your query \n");
            string read = Console.ReadLine();


            if (read == "Odd-Even" || read == "1")
            {
                Console.WriteLine("Enter number 1 \n");
                int range1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2 \n"); 
                int range2 = Convert.ToInt32(Console.ReadLine());

                for (int i = range1; i <= range2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + " number is Even.\n");

                    }
                    else
                    {
                        Console.WriteLine(i + " number is Odd.\n");

                    }
                }
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Check Vowel" || read == "2")
            {
                string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                string getinput = Console.ReadLine();

                if (vowels.Contains(getinput))
                {
                    Console.WriteLine("Yes!" + getinput + " is a vowel.");

                }
                else
                {
                    Console.WriteLine("No!" + getinput + " is not a vowel.");
                }
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Count Vowels & Consonants" || read == "3")
            {
                string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                string getinput = Console.ReadLine();
                int vowelscnt = 0;
                int consonantscnt = 0;
                foreach (char character in getinput)
                {
                    if (vowels.Contains(character.ToString()))
                    {
                        Console.WriteLine("Yes!" + character + " is a vowel.");
                        vowelscnt++;
                    }
                    else
                    {
                        Console.WriteLine("No!" + character + " is not a vowel.");
                        consonantscnt++;
                    }
                }
                Console.WriteLine("Total Vowels:" + vowelscnt + " and Consonants are:" + consonantscnt);
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Leap Year" || read == "4")
            {
                int getinput = Convert.ToInt32(Console.ReadLine());
                if (getinput % 4 == 0)
                {
                    Console.WriteLine("Yes!" + getinput + " is a leap year.");
                }
                else
                {
                    Console.WriteLine("No!" + getinput + " is not a leap year.");
                }
                Console.ReadLine();
            }
            else if (read == "Factorial" || read == "5")
            {
                int getinput = Convert.ToInt32(Console.ReadLine());
                int fact = 1;
                for (int i = 1; i <= getinput; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of " + getinput + "! is:" + fact);

                Console.ReadLine();
                goto Restart;
            }
            else if (read == "HCF & LCM" || read == "6")
            {
                Console.WriteLine("Enter two numbers:");

                int getinput1 = Convert.ToInt32(Console.ReadLine());
                int getinput2 = Convert.ToInt32(Console.ReadLine());
                int temp;
                int hcf; //  or gcd    
                int lcm, x, y;

                x = getinput1;
                y = getinput2;

                while (getinput2 != 0)
                {
                    temp = getinput2;
                    getinput2 = getinput1 % getinput2;
                    getinput1 = temp;
                }

                hcf = getinput1;
                lcm = (x * y) / hcf;


                Console.WriteLine("Greatest Common Divisor of " + x + " & " + y + " is:" + hcf);
                Console.WriteLine("Least Common Multiple of " + x + " & " + y + " is:" + lcm);
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "HCF & LCM" || read == "7")
            {
                Console.WriteLine("Enter two numbers:");

                int getinput1 = Convert.ToInt32(Console.ReadLine());
                int getinput2 = Convert.ToInt32(Console.ReadLine());
                int temp;
                int hcf; //  or gcd    
                int lcm, x, y;

                x = getinput1;
                y = getinput2;

                while (getinput2 != 0)
                {
                    temp = getinput2;
                    getinput2 = getinput1 % getinput2;
                    getinput1 = temp;
                }

                hcf = getinput1;
                lcm = (x * y) / hcf;


                Console.WriteLine("Greatest Common Divisor of " + x + " & " + y + " is:" + hcf);
                Console.WriteLine("Least Common Multiple of " + x + " & " + y + " is:" + lcm);
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Decimal to Binary" || read == "8")
            {
                Console.WriteLine("Enter one number:");
                /* Method 1*/
                int getinput1 = Convert.ToInt32(Console.ReadLine());

                string binary = Convert.ToString(getinput1, 2);
                Console.WriteLine("Decimal to Binary of " + getinput1 + "by method1 is:" + binary);
                /* Method 1*/
                /* Method 2*/
                const int mask = 1;
                var binaynum = string.Empty;
                while (getinput1 > 0)
                {
                    // Logical AND the number and prepend it to the result string    
                    binaynum = (getinput1 & 1) + binaynum;
                    getinput1 = getinput1 >> 1;
                }
                Console.WriteLine("Decimal to Binary of same by method2 is:" + binary);
                /* Method 2*/

                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Add Numbers" || read == "9")
            {
                Console.WriteLine("Enter two numbers:");

                int getinput1 = Convert.ToInt32(Console.ReadLine());
                int getinput2 = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = getinput1; i <= getinput2; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Addition of n numbers is:" + sum);
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Swap" || read == "10")
            {
                Console.WriteLine("Enter two number:");

                int getinput1 = Convert.ToInt32(Console.ReadLine());
                int getinput2 = Convert.ToInt32(Console.ReadLine());

                int x, y;
                x = getinput1;
                y = getinput2;

                /*Method 1->  using third variable*/
                int temp;

                temp = getinput1;
                getinput1 = getinput2;
                getinput2 = temp;

                Console.WriteLine("Numbers swapped as:" + getinput1 + "& " + getinput2);
                Console.ReadLine();
                /*Method 1->  using third variable*/

                /*Method 2-> without using third variable*/
                x = y - x;   // a=> b-a    
                y = x + y;   // b=> a+b    
                x = x + y;  // a=>b-a    

                Console.WriteLine("Numbers swapped as:" + getinput1 + "& " + getinput2);
                Console.ReadLine();
                goto Restart;

            }
            else if (read == "Reverse" || read == "11")
            {

                Console.WriteLine("Enter string:");
                string input1 = Console.ReadLine();
                /* Reverse String Method 1*/
                string reversest = string.Empty;
                Stack stack = new Stack();
                foreach (char data in input1)
                {
                    stack.Push(data);
                }

                foreach (var data in stack)
                {
                    reversest += data;
                }
                Console.WriteLine("Reverse string of:" + input1 + "is " + reversest);
                /* Reverse String Method 1*/

                /* Reverse String Method 2*/
                char[] chrarray = input1.ToCharArray();
                string reversestring = string.Empty;
                for (int i = chrarray.Length; i >= 1; i--)
                {
                    reversestring += chrarray[i - 1];
                }
                Console.WriteLine("Reverse string of:" + input1 + "is " + reversestring);

                /* Reverse String Method 2*/

                Console.ReadLine();
                goto Restart;

            }
            else if (read == "Armstrong" || read == "12")
            {
                Console.WriteLine("Enter Number:");
                string getinput = Console.ReadLine();
                char[] input1 = getinput.ToCharArray();

                int length = input1.Length;

                double x = Convert.ToDouble(getinput);
                double armstrong = 0;

                for (int i = 0; i <= length - 1; i++)
                {
                    string num = input1[i].ToString();
                    int number = Convert.ToInt32(num);

                    armstrong = armstrong + Math.Pow(number, length);
                }

                if (armstrong == x)
                {
                    Console.WriteLine("Yes! it's an Armstrong number.");
                }
                else
                {
                    Console.WriteLine("No! it's not an Armstrong number.");
                }

                Console.ReadLine();
                goto Restart;
            }

            else if (read == "Fibonacci" || read == "13")
            {
                Console.WriteLine("Enter two range as numbers:");

                int getinput1 = Convert.ToInt32(Console.ReadLine());
                int getinput2 = Convert.ToInt32(Console.ReadLine());

                string fibonacci = string.Empty;
                int temp = getinput1;
                fibonacci = temp.ToString() + "," + getinput2.ToString();

                for (int i = 0; i <= 10; i++)
                {

                    temp = getinput1 + getinput2;
                    getinput1 = getinput2;
                    getinput2 = temp;
                    fibonacci += "," + getinput2;
                }

                Console.WriteLine("Fibonacci Series between two numbers is:" + fibonacci);
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Blank Space" || read == "14")
            {
                Console.WriteLine("Enter string:");

                string getinput1 = Console.ReadLine();

                /* Simple in c# due to function -> Replace*/
                string newstring = getinput1.Replace(" ", "");
                Console.WriteLine("String after removing blank space:" + newstring);
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Floyds Triangle" || read == "15")
            {
                for (int i = 0; i <= 20; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {

                        Console.Write(j + " ");

                    }
                    Console.Write("\n");

                }
                Console.ReadLine();
                goto Restart;
            }
            else if (read == "Pascal Triangle" || read == "16")
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10 - i; j++)
                    {
                        Console.Write(" ");

                    }
                    //for (int k = 20; k >= i; k--)    
                    //{    
                    //    Console.Write(" " + k);    
                    //}    
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(" " + k);
                    }

                    Console.Write("\n");

                }
                Console.ReadLine();
            }    
        }
    }
}
