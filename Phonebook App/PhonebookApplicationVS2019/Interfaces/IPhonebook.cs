using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_ApplicationVS2019.Interfaces
{
    public interface IPhonebook
    {
        string Name { get; set; }
        long Phonenumber { get; set; }
        void LogMessage(string message);
        void StoreEntry(string name, long phonenumber);
        long FindPhonenumberbyName(string name);
        string FindNamebyPhonenumber(long phonenumber);
        string ReturnName(string name);
        long ReturnPhoneNumber(long phonenumber);
        bool DoesNameExistInPhonebook(string name);
        bool DoesNumberExistInPhonebook(long number);
    }
}
