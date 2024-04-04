using System;

namespace CarInventory
{
    public abstract class Car
    {
        public string name { get; set; } = "CarName";
        
        protected virtual int topSpeed = 1;
        protected virtual int acceleration = 1;
        protected virtual int handling = 1;
        protected virtual int nitro = 1;

        public Car(string _name) 
        {
            this.name = _name;
        }
    }
}

