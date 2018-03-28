using Poinc.Domain.Extensions;
using Poinc.Domain.Helpers;
using System;

namespace Poinc.Domain.Builders
{
    public abstract class WorkerBuilder<TType> : Builder<TType>
    {
        private string ip;
        private int port;
        private string username;

        public WorkerBuilder<TType> UseDefaultValues()
        {
            return WithUsername(Environment.UserName).WithIp(SocketHelper.GetIpv4().ToString());
        }

        public WorkerBuilder<TType> WithIp(string ip) => this.SetProperty(ref this.ip, ip);

        public WorkerBuilder<TType> WithPort(int port) => this.SetProperty(ref this.port, port);

        public WorkerBuilder<TType> WithUsername(string username) => this.SetProperty(ref this.username, username);
    }
}