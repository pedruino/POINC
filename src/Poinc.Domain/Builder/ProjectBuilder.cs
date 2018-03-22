using Poinc.Domain.Extensions;
using Poinc.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Poinc.Domain.Builder
{
    public sealed class ProjectBuilder : BaseBuilder<IProject>
    {
        private IReadOnlyList<IClient> clients;
        private Guid id;
        private string name;

        public override IProject Build()
        {
            return new Project(id, name)
            {
                Clients = new ObservableCollection<IClient>(this.clients)
            };
        }

        public ProjectBuilder WithClients(IReadOnlyList<IClient> clients) => this.SetProperty(ref this.clients, clients);

        public ProjectBuilder WithId(Guid id) => this.SetProperty(ref this.id, id);

        public ProjectBuilder WithName(string name) => this.SetProperty(ref this.name, name);
    }
}