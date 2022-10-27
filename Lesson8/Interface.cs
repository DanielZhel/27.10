using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public interface IVIhicle
    {
        void Drive(int distance);

        bool Refuel(int amount);
    }
}
