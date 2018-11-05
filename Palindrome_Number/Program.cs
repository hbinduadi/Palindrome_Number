using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 1;
                while (num > 0)
                {
                    string data = num.ToString();
                    bool isPalindrome = true;
                    for (int i = 0; i < data.Length / 2; i++)
                    {
                        if (data[i] != data[(data.Length - 1) - i])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    Console.WriteLine("The Palindrome Numbers are : ");
                    if (isPalindrome)
                    {
                        Console.WriteLine("Palindrome :" + num);
                    }
                    num++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught ");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
