using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINHTHANHLibrary
{
    public class PhongBan
    {
        public string phongBan { get; set; }

        public PhongBan(string phongBan)
        {
            this.phongBan = phongBan;
        }

        public float PhuCapPhongBan()
        {
            float heSoPhongBan = 0;
            if (phongBan == "NS" || phongBan == "HC" || phongBan == "KT")
            {
                heSoPhongBan = 0.3f;
            }
                return heSoPhongBan;
        }
    }
}
