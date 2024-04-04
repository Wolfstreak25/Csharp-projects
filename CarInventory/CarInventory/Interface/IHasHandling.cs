using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory.Interface
{
    interface IHasHandling
    {
        public void SetHandling(int Level);
        public int GetHandling();
    }
}
