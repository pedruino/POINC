namespace Poinc.Domain.Model
{
    internal class ProjectDefinition : IProjectDefinition
    {
        public ProjectDefinition(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; }
        public string Path { get; }
    }
}