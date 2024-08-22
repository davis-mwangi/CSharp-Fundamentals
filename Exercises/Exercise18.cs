using System;
namespace Exercises
{
    public class Order
    {
        //your code goes here
        private string _item;
        private DateTime _date;

        public Order(string item, DateTime date)
        {
            Item = item;
            Date = date;
        }

        public string Item
        {
            get;
        }


        public DateTime Date
        {
            set
            {

                DateTime current = DateTime.Now;
                int year = current.Year;

                if (value.Year == year)
                {
                    _date = value;
                }
            }
            get
            {
                return _date;
            }

        }
    }



}

