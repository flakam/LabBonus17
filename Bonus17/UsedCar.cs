using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus17
{
    class UsedCar : Car
    {
        public int year;
        public string make;
        public string model;
        public double price;
        public double mileage;

        public UsedCar(int year, string make, string model, double price, double mileage) : base( year,make, model, price)
        {
            this.mileage = mileage;
            this.year = year;
            this.make = make;
            this.model = model;
            this.Price = price;
        }
        //public double mileage;
        public double Mileage
        {
            get

            {
                return mileage;
            }
        }
        //public UsedCar(int year, string make, string model, double price,double mileage)
        // {
        //   this.year = year;
        // this.make = make;
        //this.model = model;
        //this.Price = price;
        // this.mileage = mileage;

        public override string ToString()
        {
            return $"Year: {year} Maker: {make},Model: {model} Price:  {Price} Mileage: {mileage}";
        }
       

    }
}
