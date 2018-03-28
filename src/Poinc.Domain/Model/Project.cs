using System;
using System.Collections.ObjectModel;

namespace Poinc.Domain.Model
{
    internal class Project : IProject
    {
        public Project(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public ObservableCollection<IWorkerClient> Clients { get; set; }
        public Guid Id { get; }
        public string Name { get; }
        public float Percentage { get; set; }
    }
}