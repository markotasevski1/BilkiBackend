namespace backend_asp.Abstraction
{
    public interface ICommand : IBaseCommand
    {
    }
    public interface IComand<TResponse> : IBaseCommand
    {

    }   
    public interface IBaseCommand
    { }
}
