using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    public class Journal: ReadingMaterial
    {
        private int _id;

        public Journal(string title, int yearPrinted, string author,
            string publisher, double price,
            int id) : base(title, yearPrinted, author, publisher, price)
        {
            _id = id;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", Id: {_id},";
        }
    }
}
