using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Hastane_Otomasyon
{
    class Oracle_Connection
    {
        public OracleConnection baglanti()
        {
            OracleConnection baglan = new OracleConnection("USER ID=ALPER_DATABASE;PASSWORD=alper;DATA SOURCE=LAPTOP-0PK6NB8B:1521/ORCL;Unicode=True");
            baglan.Open();
            return baglan;
        }
      
        
    }
}
