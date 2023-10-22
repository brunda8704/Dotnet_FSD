using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRealUsage
{
    internal class Employee : IVideoPlayer
    {
        public int Id;
        public string Name;
        public void Play()
        {
            Console.WriteLine($"Employee Id:{Id}, Name:{Name}");
        }
    }

}
