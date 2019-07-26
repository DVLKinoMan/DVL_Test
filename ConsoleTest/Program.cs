using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVL_Test.Domain.Abstract;
using DVL_Test.Domain.Concrete;
using DVL_Test.Domain;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
        //m1:
        //    IDVLTest d = new DVLTest();
        //    try
        //    {
        //        Console.WriteLine("Add New Word:");
        //        Word w = new Word { Text = Console.ReadLine() };
        //        d.addWord(w);

        //    }
        //    catch (Exception exc)
        //    {
        //        Console.WriteLine(exc.Message);
        //        Console.WriteLine("Try Again");
        //        goto m1;
        //    }
        //    Console.WriteLine("Added Successfully");

        //m2:
        //    IDVLTest d2 = new DVLTest();
        //    try
        //    {
        //        Console.WriteLine("Remove Word:");
        //        Word w = new Word { Text = Console.ReadLine() };
        //        d2.removeWord(w);
        //    }
        //    catch (Exception exc)
        //    {
        //        Console.WriteLine(exc.Message);
        //        Console.WriteLine("Try Again");
        //        goto m2;
        //    }
        //    Console.WriteLine("Removed Successfully");

        //    foreach (Word word in d2.Words)
        //        Console.WriteLine(word.Text);

            IDVLTest d3 = new DVLTest();
            for (int i = 0; i < 1000; i++)
                Console.WriteLine(d3.getRandomWord().Text);

                Console.ReadKey();
        }
    }
}
