namespace Poinc.Domain.Builder
{
    public interface IBaseBuilder<T>
    {
        T Build();
    }
}