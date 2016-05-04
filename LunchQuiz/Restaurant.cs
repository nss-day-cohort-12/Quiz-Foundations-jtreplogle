using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Restaurant
    {
        //Create list to add Customers and MenuItems
        public List<Customer> CurrentCustomers = new List<Customer>();
        public List<MenuItem> MenuItems = new List<MenuItem>();
        //Declare 2 and 4 Person Tables.
        public int Numberof2PersonTables;
        public int Numberof4PersonTables;

        //Add Customer to list
        public void AddCustomerToList(Customer customerList)
        {
            CurrentCustomers.Add(customerList);
        }
        //Capactiy Method.
        public virtual int capacity()
        {
            return (Numberof4PersonTables * 4) + (Numberof2PersonTables * 2);
        }

        //Is item on menu?
        public bool ItemIsOnMenu(string itemOnMenu)
        {
            return MenuItems.Exists(MenuItem => MenuItem.Name == itemOnMenu);
        }

        //Found > return.
        public bool ItemIsOnMenu(MenuItem itemOnMenu)
        {
            return MenuItems.Contains(itemOnMenu);
        }
    }
}
