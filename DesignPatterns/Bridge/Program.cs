using System;
using Bridge.Abstraction;
using Bridge.Implementation;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new Tv();
            var remote = new AdvancedRemote(tv);
            remote.TogglePower();
        }
    }
}
