using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dicitionaries think of key value pairs
            //Syntax for Dictionary
            //Dictionary is a class
            //string is your data
            //the new keyword means we're instantiating a new object
            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
            { "A1", "Twix"},//A1 is our key, Twix is our value
            { "A2", "Twizzlers"},
            { "A3","Reeses"},
            { "A4", "Sour Patch Kids"},

        };
            foreach(KeyValuePair<string, string>item in snackMachine)
       //Or foreach (var item in snackMachine) don't do this, just being taught so you know what it is
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using add method to add driniks
            drinkMachine.Add(10, "Ginger-Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Orange Juice");
            drinkMachine.Add(13, "Fruit Punch");
            drinkMachine.Add(14, "Mountain Dew");
            //Counting the number of entries in the dictionary
            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int,string>drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);//this will return all of the keys
                Console.WriteLine(drink.Value);//this will return all of the values
            }


        }
    }
}
