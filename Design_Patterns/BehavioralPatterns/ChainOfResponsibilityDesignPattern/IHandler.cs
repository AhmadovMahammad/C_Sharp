namespace ChainOfResponsibilityDesignPattern
{
    public interface IHandler<T>
    {
        void Handle(T entity);
        IHandler<T> SetNextHandler(IHandler<T> next);
    }
}
