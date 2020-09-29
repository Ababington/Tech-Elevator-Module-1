using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tracker : ISingable
    {
        public string Name { get; }
        public string Sound { get; }

        public Tracker()
        {
            Name = "Tractor";
            Sound = "Vroom";
        }
    }
}
