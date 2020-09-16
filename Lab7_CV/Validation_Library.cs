using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_CV
{
    class Validation_Library
    {
        public static bool BadWords(string contact)
        {
            bool result = false;

            string[] BadWordsList = { "BLAH", "POOP", "HOMEWORK", "CACA" };

            String temp = contact.ToUpper();

            foreach (string BadWord in BadWordsList)
            if (contact.Contains(BadWord))
            {
                result = true;
            }
            return result;
        }
    }
}
