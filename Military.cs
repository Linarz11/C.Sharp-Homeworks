using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public enum TypeMilitary
    {
        fighter, bomber, reconnaissance, cargo
    }
   public class Military:Plane
    {
        public TypeMilitary Type { get; set; }
    }
}
