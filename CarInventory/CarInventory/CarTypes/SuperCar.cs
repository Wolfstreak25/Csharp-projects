﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    class SuperCar : Car
    {
        public SuperCar(string _name) : base(_name)
        {
            topSpeed = 1;
            handling = 1;
            acceleration = 1;
            carType = CarType.SuperCar;
        }

        public override void SetAcceleration(int _acceleration)
        {
            base.SetAcceleration(_acceleration);
        }
        public override void SetHandling(int _handling)
        {
            base.SetHandling(_handling);
        }
        public override void SetTopSpeed(int _topSpeed)
        {
            base.SetTopSpeed(_topSpeed);
        }
        public override int GetAcceleration()
        {
            return base.GetAcceleration();
        }
        public override int GetHandling()
        {
            return base.GetHandling();
        }
        public override int GetTopSpeed()
        {
            return base.GetTopSpeed();
        }
    }
}
