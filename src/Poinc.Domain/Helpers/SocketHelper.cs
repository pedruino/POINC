using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Poinc.Domain.Helpers
{
    public class SocketHelper
    {
        public static IPAddress GetIpv4() => GetIp(AddressFamily.InterNetwork);

        public static IPAddress GetIpv6() => GetIp(AddressFamily.InterNetworkV6);

        private static IPAddress GetIp(AddressFamily addressFamily)
        {
            return Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == addressFamily);
        }
    }
}