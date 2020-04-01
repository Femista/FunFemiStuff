using System.Security.Cryptography.X509Certificates;

namespace Composite
{
    public interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }
}