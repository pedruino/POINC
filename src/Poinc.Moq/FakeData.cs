using Moq;
using Poinc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poinc.Moq
{
    public class FakeData
    {
        public IEnumerable<IClient> GetClients()
        {
            var c1 = Mock.Of<IClient>();

            Mock.Get(c1).SetupGet(c => c.Name).Returns("Pedro");

            var f = Mock.Get(mocked: IClient);
            return asd;
        }
        public FakeData()
        {
            var mock = new Mock<IClient>("name");
            mock.Setup(c => c.Name = "asd");
        }
    }
}
