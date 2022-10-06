using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINHTHANHLibrary
{
    public class ThamNien
    {
        public string thamNien { get; set; }
        public DateTime ngayBatDau { get; set; }
        public ThamNien(string thamNien , DateTime ngayBatDau)
        {
            this.thamNien = thamNien;
            this.ngayBatDau = ngayBatDau;
        }
        public float HeSoThamNien()
        {
            int soNam = DateTime.Today.Year - ngayBatDau.Year;
            if (DateTime.Today.Month < ngayBatDau.Month)
            {
                soNam--;
            }
            return soNam * 0.15f;
        }
    }
}
