using Poinc.Domain.Extensions;
using Poinc.Domain.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Poinc.Domain.Builders
{
    public sealed class ProjectBuilder : Builder<IProject>
    {
        private IReadOnlyList<IWorkerClient> clients;
        private Guid id;
        private string name;

        public override IProject Build()
        {
            return new Project(id, name)
            {
                Clients = new ObservableCollection<IWorkerClient>(clients)
            };
        }

        public ProjectBuilder WithClients(IReadOnlyList<IWorkerClient> clients) => this.SetProperty(ref this.clients, clients);

        public ProjectBuilder WithId(Guid id) => this.SetProperty(ref this.id, id);

        public ProjectBuilder WithName(string name) => this.SetProperty(ref this.name, name);
    }
}