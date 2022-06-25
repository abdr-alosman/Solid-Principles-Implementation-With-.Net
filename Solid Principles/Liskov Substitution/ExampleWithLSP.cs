using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Liskov_Substitution
{

    public class Fruit
    {
        public virtual string GetColor()
        {
            return "anonymous Fruit";
        }
    }
    public class Apple1 : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange1 : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

}
