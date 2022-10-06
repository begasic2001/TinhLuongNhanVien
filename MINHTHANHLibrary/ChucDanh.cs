using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINHTHANHLibrary
{
    public class ChucDanh
    {
        public string chucDanh { get; set; }

        public ChucDanh(string chucDanh)
        {
            this.chucDanh = chucDanh;
        }

        public float HeSoChucDanh()
        {
            float heSoChucDanh = 0;
            switch (chucDanh)
            {
                case "GD":
                    heSoChucDanh = 5.0f;
                    break;
                case "PGD":
                    heSoChucDanh = 4.0f;
                    break;
                case "TP":
                    heSoChucDanh = 3.0f;
                    break;
                case "PP":
                    heSoChucDanh = 2.0f;
                    break;
                case "NV":
                    heSoChucDanh = 1.0f;
                    break;
            }
            return heSoChucDanh;
        }
    }
}
