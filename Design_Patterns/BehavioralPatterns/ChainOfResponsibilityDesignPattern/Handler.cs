namespace ChainOfResponsibilityDesignPattern
{
    public class Handler<T> : IHandler<T>
    {
        private IHandler<T>? Next { get; set; }
        public virtual void Handle(T entity)
        {
            Next?.Handle(entity);
        }
        public IHandler<T> SetNextHandler(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }
}
