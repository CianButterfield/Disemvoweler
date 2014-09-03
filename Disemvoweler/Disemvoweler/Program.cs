using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //call disemvoweler
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");

            //keep the console window open
            Console.ReadKey();
        }

        //Function for disemvoweling
        static void Disemvoweler(string input)
        {
            //declare variable for the disemvoweled output
            string disemvoweled = "";
            //delare variable for the vowels
            string vowels = "";
            //loop throuth the input
            for (int i = 0; i < input.Length; i++)
            {
                //see if the letter is a vowel
                if ("aeiouAEIOU".Contains(input[i]))
                {
                    //it's a vowel, add it to the vowel string
                    vowels = vowels + input[i];
                }
                //se if it is a space
                else if (input[i] == ' ')
                {
                    //it's a space, do NOTHING to it
                }
                else
                {
                    //it's a non-vowel non-space character, add it to the disemvoweled string
                    disemvoweled = disemvoweled + input[i];
                }
            }
            //print the ouputs
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + disemvoweled);
        }
    }
}
