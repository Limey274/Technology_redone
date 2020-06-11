using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_redone
{
    public class SmartPhone : Computer //gets all properties from the computer class, adds new/unique property
    {
        public int PicturesInPhone { get; set; } //sets new/unique property

        public SmartPhone(bool powerOn, int ram, int storage, bool hasKeyboard, int picturesInPhone) : base(powerOn, ram, storage, hasKeyboard) //sets constructor for the smartphone
        {
            PicturesInPhone = picturesInPhone;
        }
        
        public void TakePicture()// makes every new photo add one new photo to the total count which we set later
        {
            PicturesInPhone++;
        }
        

    }
}
