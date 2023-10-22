using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRealUsage
{
    internal class Student : IVideoPlayer
    {
        public int Id;
        public string Name;

        public void Play()
        {
            Console.WriteLine($"Student Id:{Id}, Name:{Name}");
        }
    }

}
