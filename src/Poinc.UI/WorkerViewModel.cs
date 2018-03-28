using Poinc.Domain;
using Poinc.Domain.Builders;

namespace Poinc.UI
{
    public class WorkerViewModel
    {
        public WorkerViewModel()
        {
            IWorkerServer server = new WorkerServerBuilder().WithUsername("pedruino")
                                                            .WithIp("192.168.2.1")
                                                            .WithPort(8000)
                                                            .Build();

            IWorkerServer client = new WorkerServerBuilder().UseDefaultValues()
                                                             .WithPort(8000)
                                                             .Build();
        }
    }
}