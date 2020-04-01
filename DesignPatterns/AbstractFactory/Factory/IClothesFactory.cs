using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    public interface IClothesFactory
    {
        IShirt CreateShirt(bool buttonUp);
        IPants CreatePants();
    }
}