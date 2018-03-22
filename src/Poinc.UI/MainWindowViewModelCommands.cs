using Prism.Commands;
using System.Windows.Input;

namespace Poinc.UI
{
    public partial class MainWindowViewModel
    {
        private ICommand addProjectDefinitionCommand;
        private ICommand removeProjectDefinitionCommand;
        private ICommand startProcessingCommand;
        private ICommand stopProcessingCommand;

        public ICommand AddProjectDefinitionCommand
        {
            get
            {
                return addProjectDefinitionCommand ?? (addProjectDefinitionCommand = new DelegateCommand(() =>
                {
                    //TODO: implement
                }));
            }
        }

        public ICommand RemoveProjectDefinitionCommand
        {
            get
            {
                return removeProjectDefinitionCommand ?? (removeProjectDefinitionCommand = new DelegateCommand(() =>
                {
                    //TODO: implement
                }));
            }
        }

        public ICommand StartProcessingCommand
        {
            get
            {
                return startProcessingCommand ?? (startProcessingCommand = new DelegateCommand(() =>
                {
                    //TODO: implement
                }));
            }
        }

        public ICommand StopProcessingCommand
        {
            get
            {
                return stopProcessingCommand ?? (stopProcessingCommand = new DelegateCommand(() =>
                {
                    //TODO: implement
                }));
            }
        }
    }
}