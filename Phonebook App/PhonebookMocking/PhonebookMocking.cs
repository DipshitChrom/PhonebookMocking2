using Moq;
using NUnit.Framework;
using Phonebook_ApplicationVS2019.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookMocking
{
    public class PhonebookMocking
    {
        Mock<IPhonebook> phonebookmock;
     

        [Test]
        public void TestingPhonebookMock()
        {
            Mock<IPhonebook> phonebookmock = new Mock<IPhonebook>();

            phonebookmock.Setup(p => p.StoreEntry("Mark", 10101010));
            phonebookmock.Setup(p => p.FindPhonenumberbyName("Mark")).Returns(10101010);

            
            var result = 10101010;
            Assert.AreEqual(phonebookmock.Object.FindPhonenumberbyName("Mark"), result);

        }

      
    }
}
