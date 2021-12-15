using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Models
{
    public partial class Student
    {
        public override bool Equals(object obj)
        {
            if (this.Id == ((Student)obj).Id)
                return true;
            else
                return false;
        }
    }
}
