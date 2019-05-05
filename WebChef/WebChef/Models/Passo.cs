using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebChef.Models
{
    public class Passo
    {
        public int id { set; get; }
        public string descricao { set; get; }
        public int numPasso { set; get; }
        public string timestamp { set; get; }
        public string descricaoAcao { set; get; }
    }
}
