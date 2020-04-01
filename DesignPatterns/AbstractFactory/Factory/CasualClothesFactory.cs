using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public class CasualClothesFactory : IClothesFactory
    {
        public IShirt CreateShirt(bool buttonUp)
        {
            return new CasualShirt(buttonUp);
        }

        public IPants CreatePants()
        {
            return new CasualPants();
        }
    }
}