using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UpSkill_CSharpConsoleApp.DNS;

namespace UpSkill_CSharpConsoleApp.Ping
{
    public class NetworkService
    {
        public IDNS _dNS { get; }

        public NetworkService(IDNS dNS)
        {
            _dNS = dNS;
        }
        public string SendPing()
        {
            var dnsSuccess = _dNS.SendDNS();
            if(dnsSuccess)
            {
                return "Success: Ping sent!";
            }
            else
            {
                return "Faild: Ping not sent!";
            }
        }
                    

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }


        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }


        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                }
            };

            return pingOptions;
        }

    }



   
}
