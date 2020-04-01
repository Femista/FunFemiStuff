using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class PunkClothesFactory : IClothesFactory
    {
        public IShirt CreateShirt(bool buttonUp)
        {
            return new PunkShirt(buttonUp);
        }

        public IPants CreatePants()
        {
            return new PunkPants();
        }
    }
}