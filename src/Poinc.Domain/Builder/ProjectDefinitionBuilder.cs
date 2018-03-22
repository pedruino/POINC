using Poinc.Domain.Extensions;
using Poinc.Domain.Model;

namespace Poinc.Domain.Builder
{
    public sealed class ProjectDefinitionBuilder : BaseBuilder<IProjectDefinition>
    {
        private string name;
        private string path;

        public override IProjectDefinition Build()
        {
            return new ProjectDefinition(this.name, this.path);
        }

        public ProjectDefinitionBuilder WithName(string name) => this.SetProperty(ref this.name, name);

        public ProjectDefinitionBuilder WithPath(string path) => this.SetProperty(ref this.path, path);
    }
}