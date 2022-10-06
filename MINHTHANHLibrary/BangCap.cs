using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINHTHANHLibrary
{
    public class BangCap
    {
        public string bangCap { get; set; }

        public BangCap(string bangCap)
        {
            this.bangCap = bangCap;
        }

        public float HeSoBangCap()
        {
            float heSo = 0;
            switch (bangCap)
            {
                case "DuoiTH":
                     heSo = 1.0f;
                    break;
                case "TH":
                     heSo = 1.2f;
                    break;
                case "CD":
                     heSo = 1.5f;
                    break;
                case "DH":
                    heSo = 2.0f;
                    break;
                case "THS":
                    heSo = 3.0f;
                    break;
                case "TS":
                    heSo = 4.5f;
                    break;
            }
            return heSo;
        }
    }
}
