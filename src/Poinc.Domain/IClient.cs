namespace Poinc.Domain
{
    public interface IClient
    {
        string Name { get; }
        float Percentage { get; set; }
        bool Status { get; }
    }
}