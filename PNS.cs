﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PNS : Karyawan
    {
        public double GajiPokok { get; set; }
        public double Tunjangan { get; set; }
        public override double Gaji()
        {
            return GajiPokok + Tunjangan;
        }
    }
}
