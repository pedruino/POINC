using Poinc.Domain;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using Poinc.Domain.Builders;

namespace Poinc.UI
{
    public partial class MainWindowViewModel : BindableBase
    {
        public WorkerViewModel WorkerViewModel;

        public MainWindowViewModel()
        {
            var c1 = new SocketClientBuilder().WithName("CXJ01").WithStatus(false).Build();
            var c2 = new SocketClientBuilder().WithName("CXJ02").WithStatus(true).Build();
            var c3 = new SocketClientBuilder().WithName("CXJ03").WithStatus(false).Build();

            var clients1 = new List<ISocketClient>() { c1, c2, c3 };
            var clients2 = new List<ISocketClient>() { c1, c2, c3 };

            Projects = new ObservableCollection<IProject>(new List<IProject>() {
                new ProjectBuilder().WithId(Guid.NewGuid()).WithName("Project 1").WithClients(clients1).Build(),
                new ProjectBuilder().WithId(Guid.NewGuid()).WithName("Project 2").WithClients(clients2).Build(),
            });

            ProjectDefinitions = new ObservableCollection<IProjectDefinition>(new List<IProjectDefinition>()
            {
                new ProjectDefinitionBuilder().WithName("Project 1").WithPath(@"C:\apsdkopasdka").Build(),
                new ProjectDefinitionBuilder().WithName("Project 2").WithPath(@"C:\apsdkopasdka").Build(),
            });
        }

        public ObservableCollection<IProjectDefinition> ProjectDefinitions { get; }
        public ObservableCollection<IProject> Projects { get; }
    }

    internal interface IHost
    {
        string Username { get; }
        IPAddress IP { get; }
    }
}