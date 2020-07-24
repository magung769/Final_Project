using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PNS : Karyawan
    {
        public double GajiPerTahun { get; set; }
        public double Bulanan { get; set; }
        public override double Gaji()
        {
            return GajiPerTahun * Bulanan;
        }
    }
}
