using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRandomizer.Models
{
    class Staff : Person, IStaff
    {
        public override string GetInfo()
        {
            throw new NotImplementedException();
        }

        public string Test()
        {
            return "";
        }

    }
}
