using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class ChicClothesFactory : IClothesFactory
    {
        public IShirt CreateShirt(bool buttonUp)
        {
            return new ChicShirt(buttonUp);
        }

        public IPants CreatePants()
        {
            return new ChicPants();
        }
    }
}