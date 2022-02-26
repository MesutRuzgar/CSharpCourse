using System;

namespace Interfaces
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }
    }
}