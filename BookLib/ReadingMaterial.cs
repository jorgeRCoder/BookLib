using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib
{
    public abstract class ReadingMaterial
    {
        private string _title;
        private int    _yearPrinted;
        private string _author;
        private string _publisher;
        private double _price;
        private int _quantity;

        public ReadingMaterial()
        {

        }
        public ReadingMaterial(string title, int yearPrinted, string author,
            string publisher, double price)
        {
            _title = title;
            _yearPrinted = yearPrinted;
            _author = author;
            _publisher = publisher;
            _price = price;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int YearPrinted
        {
            get { return _yearPrinted; }
            set { _yearPrinted = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public override string ToString()
        {
            return $"Title: {_title}, Year printed:{_yearPrinted}, Author:{_author}" +
                $", Publisher:{_publisher}, Price:{_price:n},Quantity {_quantity}" ; 
        }
    }
}
