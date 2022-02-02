using System;

namespace P225FirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte age = 2;

            ////float pi = 3f;

            ////decimal test = 5m;

            ////double money = 53.65;

            ////char symbol = '@';

            ////string text = "Hello World";//['H','e','l','l','o',' ','W','o','r','l','d']

            //Console.WriteLine(age);

            //string text = "2a";
            //int num = 2;

            //int num = 8;


            //if (num == 5)
            //{

            //}
            //else if (num == 5)
            //{

            //}
            //else if (num == 5)
            //{

            //}
            //else if (num == 5)
            //{

            //}
            //else if (num == 5)
            //{

            //}
            //else
            //{

            //}


            //switch (num)
            //{
            //    case 5:
            //        Console.WriteLine("test");
            //        break;
            //    case 6:
            //        Console.WriteLine("test");
            //        break;
            //    case 7:
            //        Console.WriteLine("test");
            //        break;
            //    case 8:
            //        Console.WriteLine("test");
            //        break;
            //    default:
            //        break;
            //}


            //string word = "Hello P225";
            //int i = 0;

            //while (i < word.Length)
            //{
            //    Console.WriteLine(word[i]);

            //    i++;
            //}

            //bool check = false;

            //while (check)
            //{
            //    Console.WriteLine("Seciminizi Edin");
            //    Console.WriteLine("-------------------");
            //    Console.WriteLine("1. Telebe yarad");
            //    Console.WriteLine("2. Muellim Yarat");
            //    Console.WriteLine("3. Cixis");
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("Isdediyniz Emeliyyat Ucun Qarsisindaki Reqemi Daxil");

            //    string choose = Console.ReadLine();

            //    int num = int.Parse(choose);

            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("Telebe Yaradildi");
            //            break;
            //        case 2:
            //            Console.WriteLine("Muellim Yaradildi");
            //            break;
            //        case 3:
            //            Console.WriteLine("Sistemden Cixdiniz");
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("Yanlisdir!!! Duzgun Daxil Et");
            //            break;
            //    }
            //}

            //do
            //{
            //    Console.WriteLine("Seciminizi Edin");
            //    Console.WriteLine("-------------------");
            //    Console.WriteLine("1. Telebe yarad");
            //    Console.WriteLine("2. Muellim Yarat");
            //    Console.WriteLine("3. Cixis");
            //    Console.WriteLine("---------------");
            //    Console.WriteLine("Isdediyniz Emeliyyat Ucun Qarsisindaki Reqemi Daxil");

            //    string choose = Console.ReadLine();

            //    int num = int.Parse(choose);

            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("Telebe Yaradildi");
            //            break;
            //        case 2:
            //            Console.WriteLine("Muellim Yaradildi");
            //            break;
            //        case 3:
            //            Console.WriteLine("Sistemden Cixdiniz");
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("Yanlisdir!!! Duzgun Daxil Et");
            //            break;
            //    }
            //} while (check);


            //string word = "Hello";
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(word[i]);
            //}

            //string word = "Hello";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}

            //for (int i = 0; i < word.Length; i++)
            //{
            //    char letter = word[i];
            //    Console.WriteLine(letter);
            //}
            char symbol = 'a';

            int[] nums = { 5, 7, 15, 269 , symbol };
            int a = nums.Length;
            a--;

            Console.WriteLine(nums[a]);

            string[] words = { "Hello", "World", "P225" };

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(Convert.ToInt32(symbol));

        }
    }
}
