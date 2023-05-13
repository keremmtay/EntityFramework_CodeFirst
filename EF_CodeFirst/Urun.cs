using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public float UrunFiyati { get; set; }
        public int StokMiktari { get; set; }
    }
}
