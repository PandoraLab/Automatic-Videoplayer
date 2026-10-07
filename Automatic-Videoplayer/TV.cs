using System;
using System.Collections.Generic;
using System.Text;

namespace Automatic_Videoplayer
{
    internal class TV
    {
        public bool IsAan { get; private set; }

        public void AanZetten()
        {
            IsAan = true;
            Console.WriteLine("De TV is aangezet.");
        }

        public void Uitzetten()
        {
            IsAan = false;
            Console.WriteLine("De TV is uitgezet.");
        }
    }
}
