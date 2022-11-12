
//main 
using System;

namespace TheRealHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //tab with hello world 
            char[] HelloWorld = new char[11];
            string tab = "hello world";
            HelloWorld = tab.ToCharArray();
            //tab whith alphabet
            char[] Alphabet = new char[26];
            string tab2 = "abcdefghijklmnopqrstuvwxyz";
            Alphabet = tab2.ToCharArray();

            char[] Display = new char[11];
            for (int i = 0; i < 11; i++)
            {
                if (i == 5)
                {
                    Display[i] = (char)32;//whitespace ascii code
                }
                else
                {
                    char letter = Alphabet[new Random().Next(0, 26)];
                    while (HelloWorld[i] != letter)
                    {
                        letter = Alphabet[new Random().Next(0, 26)];
                        Display[i] = letter;
                        Console.WriteLine(Display);
                        //buffer
                        System.Threading.Thread.Sleep(15);
                    }
                    if (i == 0 || i == 6)
                    {
                        Display[i] = char.ToUpper(letter); //first letter of each word in uppercase
                    }
                    else
                    {
                        Display[i] = letter;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
