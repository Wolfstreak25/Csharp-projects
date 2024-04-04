using CarInventory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    public class Car : IHasHandling

    {
        public string name;
        public CarType carType;
        protected int topSpeed;
        protected int acceleration;
        protected int handling;
        
        public Car(string _name) 
        {
            name = _name;
        }


        public virtual void SetTopSpeed(int _topSpeed)
        {
            topSpeed = _topSpeed;
        }
        public virtual void SetHandling(int _handling)
        {
            handling = _handling;
        }
        public virtual void SetAcceleration(int _acceleration)
        {
            acceleration = _acceleration;
        }

        public virtual int GetTopSpeed()
        {
            return topSpeed;
        }
        public virtual int GetAcceleration()
        {
            return acceleration;
        }
        public virtual int GetHandling()
        {
            return handling;
        }
    }
}
