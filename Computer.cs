using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_redone
{
    public class Computer : AbstractEntity //statred with public class, have the class "come from" the abstractentity class for unique Id 
    {
        public bool PowerOn { get; set; } = false; //Power on to test if the device has power
        public int Ram { get; set; } //setting the RAM size for the device 
        public int Storage { get; set; } // Setting the storage capacity on the device
        public readonly bool hasKeyboard; //sets bool for having a keyboard

        public Computer(bool powerOn, int ram, int storage, bool hasKeyboard) //set the constructor for the identified properites. 
        {
            PowerOn = powerOn;
            Ram = ram;
            Storage = storage;
            this.hasKeyboard = hasKeyboard;
        }
    
       public void PushPowerOn() //sets Power to the "power button" give If/esle statement to ensure the power is on. 
        {
            if (PowerOn)
            {
                PowerOn = false;
            }
            else
            {
                PowerOn = true;
            }   
        }
        public void IncreaseRam(int size) //sets the increase to Ram for the device
        {
            Ram += size; //whatever the ram is, add the new size to the existing ram
        }
        
        public void IncreaseStorage(int size) //whatever the storage is, sets the new storgae to add to the existing storage
        {
            Storage += size;
        }
    
    
    
    }
}

