/*
 * Inventory class
 * This program was written by Jason Borum
 * Date: April 1, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Inventory
    {
        //Decalre Inventory fields
        private string itemCategory;
        private string itemName;
        private string itemNumber;
        private decimal itemPrice;
        private int numberOfItems;

        // Item Category Property
        public string Category
        {
            get { return itemCategory; }
            set { itemCategory = value; }
        }

        // Item Name Property
        public string Name
        {
            get { return itemName; }
            set { itemName = value; }
        }

        // Item Number Property
        public string Number
        {
            get { return itemNumber; }
            set { itemNumber = value; }
        }

        // Item Price Property
        public decimal Price
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        // Item Quantity Property
        public int Quantity
        {
            get { return numberOfItems; }
        }


        //Constructor without arguments
        public Inventory()
        {
            itemCategory = "None";
            itemName = "None";
            itemNumber = "None";
            itemPrice = 0.00m;
            numberOfItems++;
        }

        //Constructor with arguments
        public Inventory(string itemCategory, string itemName, string itemNumber, decimal itemPrice)
        {
            this.itemCategory = itemCategory;
            this.itemName= itemName;
            this.itemNumber = itemNumber;
            this.itemPrice = itemPrice;
            numberOfItems++;
        }

    }
}
