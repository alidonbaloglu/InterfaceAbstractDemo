using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public  class StarbucksCustomerManager:BaseCustomerManager,ICustomerCheckService
    {
        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        
    }
}
