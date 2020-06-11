using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_redone
{
   public class Laptop : Computer //Lets the Laptop class know its coming from the Computer class and gets all the properties of ther class
    {
        public double Weight { get; set;  } //sets the weight for the 

        public Laptop(bool powerOn, int ram, int storage, bool hasKeyboard, double weight) : base(powerOn, ram, storage, hasKeyboard) //sets constructor
        {
            Weight = weight;
        }

        public bool TooHeavy() //sets method to look for a heavy laptop and see if it is under 6 pounds
        {
            if (Weight > 6.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
