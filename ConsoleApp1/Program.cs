//Mohammad Hani Issa Khrabeh 202110986
using System;
class Welcome1
{

    class Customer
    {
        private string name;
        private string address;
    }

    class Order
    {
        private DateTime date;
        private string status;
        private Customer customer;

        private List<OrderDetail> orderDetails;

        public void calcSubTotal()
        {
            
        }

        public void calcTax()
        {
            
        }

        public void calcTotal()
        {
           
        }

        public void calcTotalWeight()
        {
            
        }
    }

    class OrderDetail
    {
        private string quality;
        private string taxStatus;
        private Item item;

        public void calcSubTotal()
        {
           
        }

        public void calcWeight()
        {

        }

        public void calcTax()
        {
            
        }

        
    }

    class Item
    {
        private int shippingWeight;
        private string description;

        public double GetPriceForQuantity()
        {
            
        }

        public double GetTax()
        {
            
        }

        public bool InStock()
        {
            
        }
    }

    class Payment
    {
        private float amount;
        private Order order; 
    }

    class Credit : Payment
    {
        private string name;
        private string type;
        private DateTime expDate;

        public void authorized()
        {
            
        }
    }

    class Check : Payment
    {
        private string name;
        private string bankID;

        public void authorized()
        {
           
        }
    }

    class Cash : Payment
    {
        private float cashTendered;
    }

static void Main()
    {

       

    }
}