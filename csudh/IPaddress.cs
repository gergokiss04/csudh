using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh
{
    public class IPaddress
    {
        
        public string domainname { get; private set; }
        public string ipaddress { get; private set; }

        public IPaddress(string domainname, string ipaddress)
        {
            this.domainname = domainname;
            this.ipaddress = ipaddress;
        }

      
        public IPaddress(string sor)
        {
            string[] darabok = sor.Split(';');
            domainname= darabok[0];
            ipaddress= darabok[1];
        }
    }
}
