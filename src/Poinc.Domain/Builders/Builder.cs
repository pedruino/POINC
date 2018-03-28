namespace Poinc.Domain.Builders
{
    public interface IBuilder   
    {
    }

    public abstract class Builder<T> : IBuilder
    {
        public abstract T Build();
    }
}