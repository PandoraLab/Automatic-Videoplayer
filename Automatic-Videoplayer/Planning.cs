using System;
using System.Collections.Generic;
using System.Text;

namespace Automatic_Videoplayer
{
    internal class Planning
    {
        public TimeOnly Starttijd { get; set; }
        public TimeOnly Eindtijd { get; set; }

        public Planning(TimeOnly starttijd, TimeOnly eindtijd)
        {
            Starttijd = starttijd;
            Eindtijd = eindtijd;
        }
    }
}
