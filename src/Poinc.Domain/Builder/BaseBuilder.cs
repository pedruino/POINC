namespace Poinc.Domain.Builder
{
    public interface IBuilder
    {
    }

    public abstract class BaseBuilder<T> : IBuilder
    {
        public abstract T Build();
    }
}