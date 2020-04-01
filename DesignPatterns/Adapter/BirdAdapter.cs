using Adapter.Client;
using Adapter.Service;

namespace Adapter
{
    internal class BirdAdapter : IToyDuck
    {
        // You need to implement the interface your 
        // client expects to use. 
        private readonly IBird _bird;

        public BirdAdapter(IBird bird)
        {
            // we need reference to the object we 
            // are adapting 
            _bird = bird;
        }

        public void squeak()
        {
            // translate the methods appropriately 
            _bird.makeSound();
        }
    }
}