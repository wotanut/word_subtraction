using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace word_subtraction
{
    // str class
    class str
    {
        // private variables
        private int string1value;
        private int string2value;
        private string string1;
        private string string2;
        
        // constructor
        public str(string string1, string string2)
        {
            this.string1 = string1;
            this.string2 = string2;
        }
        // getters
        public string getString1()
        {
            return this.string1;
        }
        public string getString2()
        {
            return this.string2;
        }
        public int getString1Worth()
        {
            foreach(char character in this.string1)
            {
                this.string1value = this.string1value + Convert.ToInt32(character);
            }
            return this.string1value;
        }
        public int getString2Worth()
        {
            foreach(char character in this.string2)
            {
                this.string2value = this.string2value + Convert.ToInt32(character);
            }
            return this.string2value;
        }
        
        // helper method to remove any duplicate characters
        public void removeDuplicates()
        {
            List<string> duplicates = new List<string>();
            foreach(char character in this.string1)
            {
                foreach(char charact in this.string2)
                {
                    if (character == charact)
                    {
                        duplicates.Add(Convert.ToString(charact));
                    }
                }
            }
            for (int i=0; i< duplicates.Count(); i++)
            {
                this.string1 = this.string1.Replace(duplicates[i],"");
                this.string2 = this.string2.Replace(duplicates[i],"");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // takes inputs and declares variables
            string string1 = "";
            string string2 = "";
            Console.WriteLine("Please enter in string 1");
            string1 = Console.ReadLine();
            Console.WriteLine("Please enter in string 2");
            string2 = Console.ReadLine();

            str variable = new str(string1, string2);

            // removes any duplicate characters
            variable.removeDuplicates();

            // compares variables

            if (variable.getString1Worth() < variable.getString2Worth())
            {
                // comes down here if string 2 has more worth than string 1
                Console.WriteLine("String 2 has more \"worth\" than string 1");
            }
            else if (variable.getString1Worth() > variable.getString2Worth())
            {
                // comes down here if string 1 has more worth than string 2
                Console.WriteLine("String 1 has more \"worth\" than string 2");
            }
            else
            {
                // comes down here if they are equal
                Console.WriteLine("Both strings have equal \"worth\"");
            }
        }
    }
}
