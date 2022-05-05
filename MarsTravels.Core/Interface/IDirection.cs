namespace MarsTravels.Core.Interface
{
    public interface IDirection
    {
        IDirection Right();
        IDirection Left();
        IPeople Move(IPeople people, ISurface surface);
    }
}
