using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationUsingDB;

namespace Unittest
{
    class MyDataProvider:IDataProvider
    {
        public int CountPeople()
        {
            throw new NotImplementedException();
        }

        public bool ExistsPerson(Person pers)
        {
            bool returnBool = false;
            List<Person> people = new List<Person>();
            Person testPerson = new Person(1,"Frederik");
            people.Add(testPerson);
            int i = 0;
            while(pers.Equals(testPerson))
            {
                returnBool = true;
            }
            return returnBool;
        }

        public ICollection<Payment> GetPaymentsFromPerson(Person pers)
        {
            ICollection<Payment> payments = new List<Payment>();
            Payment myPayment = new Payment(22.5,1);
            Payment nextPayment = new Payment(51.8,1);
            payments.Add(nextPayment);
            payments.Add(myPayment);
            return payments;

        }

        public ICollection<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public void SavePayment(Payment pmnt)
        {
            throw new NotImplementedException();
        }

        public void SavePerson(Person pers)
        {
            throw new NotImplementedException();
        }
    }
}
