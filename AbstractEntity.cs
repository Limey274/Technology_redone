using System;
using System.Collections.Generic;
using System.Text;

namespace Technology_redone
{
   public abstract class AbstractEntity
    {
        public int Id { get; set; } //Sets Id 
        private static int newId = 1; // makes the starting ID = 1

        public AbstractEntity() //class sets the ID to equal a new ID and makes the ID go up every time with every new ID needed (Every new computer)
        {
            Id = newId;

            newId += 1;
        }
    }
}
