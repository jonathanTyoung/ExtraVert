// Models/IMovable.cs
namespace ExtraVert.Models
{
    public interface IMovable
    {
        void Move();
        int Speed { get; }
    }
}