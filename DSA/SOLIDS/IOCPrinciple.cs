using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.SOLIDS
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName();
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public string GetCustomerName()
        {
            return "Demo";
        }
    }
    public class CustomerDataAccessV1 : ICustomerDataAccess
    {
        public string GetCustomerName()
        {
            return "Version 2";
        }
    }

    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccess()
        {
            return new CustomerDataAccessV1();
        }
    }

    public class CustomerBussinessLogin
    {
        ICustomerDataAccess _cutomerDataAccess;
        public CustomerBussinessLogin()
        {
            _cutomerDataAccess = DataAccessFactory.GetCustomerDataAccess();
        }

        public string GetCustname() {
            return _cutomerDataAccess.GetCustomerName();
        }
    }
}
