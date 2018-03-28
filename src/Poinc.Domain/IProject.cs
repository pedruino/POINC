using System;
using System.Collections.ObjectModel;

namespace Poinc.Domain
{
    public interface IProject
    {
        ObservableCollection<IWorkerClient> Clients { get; set; }
        Guid Id { get; }
        string Name { get; }
        float Percentage { get; set; }
    }
}