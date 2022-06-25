using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Liskov_Substitution
{

    /// <summary>
    /// For example, a father is a teacher whereas his son is a doctor. So here, in this case, the son can’t simply replace his
    /// father even though both belong to the same family.
    /// </summary>
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    /// <summary>
    /// . The point is that an Orange cannot be replaced by an Apple, which results in printing the color of the apple as Orange 
    /// as shown in the below example.
    /// </summary>
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
    
}
