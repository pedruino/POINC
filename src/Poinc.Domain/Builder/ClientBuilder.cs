using Poinc.Domain.Extensions;
using Poinc.Domain.Model;

namespace Poinc.Domain.Builder
{
    public sealed class ClientBuilder : BaseBuilder<IClient>
    {
        private string name;
        private bool status;

        public override IClient Build()
        {
            return new Client(name, status);
        }

        public ClientBuilder WithName(string name) => this.SetProperty(ref this.name, name);

        public ClientBuilder WithStatus(bool status) => this.SetProperty(ref this.status, status);
    }
}