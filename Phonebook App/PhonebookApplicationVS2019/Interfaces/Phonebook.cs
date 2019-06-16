using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_ApplicationVS2019.Interfaces
{
    public class Phonebook : IPhonebook
    {
        public string Name { get; set; }
        public long Phonenumber { get; set; }
        readonly IConsoleWriter consoleWriter;
        private IPhonebook phonebook;
        Dictionary<string, long> phonebookbyname = new Dictionary<string, long>();
        Dictionary<long, string> phonebookbynumber = new Dictionary<long, string>();

        public Phonebook(IPhonebook phonebook)
        {
            this.phonebook = phonebook;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void StoreEntry(string name, long phonenumber)
        {
            phonebookbyname.Add(name, phonenumber);
            phonebookbynumber.Add(phonenumber, name);
        }

        public long FindPhonenumberbyName(string name)
        {
            long phonenumber = 0;

            if (phonebookbyname.ContainsKey(name))
            {
                phonenumber = phonebookbyname[name];
                return phonenumber;
            }
            else
            {
                Console.WriteLine("The name entered doesn't exist in the phonebook");
            }

            return phonenumber;

        }

        public string FindNamebyPhonenumber(long phonenumber)
        {
            string name = " ";

            if (phonebookbynumber.ContainsKey(phonenumber))
            {
                name = phonebookbynumber[phonenumber];
                return name;
            }
            else
            {
                Console.WriteLine("The phone number entered doesn't exist in the phonebook");
            }

            return name;
        }

        public string ReturnName(string name)
        {
            return name;
        }

        public long ReturnPhoneNumber(long phonenumber)
        {
            return phonenumber;
        }

        public bool DoesNameExistInPhonebook(string name)
        {
            if (phonebookbyname.ContainsKey(name))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool DoesNumberExistInPhonebook(long number)
        {
            if (phonebookbynumber.ContainsKey(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
