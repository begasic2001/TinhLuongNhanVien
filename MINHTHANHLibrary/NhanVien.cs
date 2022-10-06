using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINHTHANHLibrary
{
    public class NhanVien
    {
       
        const float BHXH = 0.08f;
        const float BHYT = 0.15f;
        const float BHTN = 0.01f;
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime ngaySinh { get; set; }
        public float ngayCong { get; set; } 
        public float ngayPhep { get; set; }
        public DateTime ngayBatDau { get; set; }
        public string TenBang { get; set; }
        public string ChucDanh { get; set; }
        public string PhongBan { get; set; }
        public string ThamNien { get; set; }
        public int Vung { get; set; }
        public int amount { get; set; }
        public NhanVien (string ma , string ten , DateTime ng,float ngayCong,float ngayPhep
            ,DateTime ngayBatDau,string TenBang , string ChucDanh , string PhongBan,string ThamNien,int Vung,int amount)
        {
            this.MaNV = ma;
            this.TenNV= ten;
            this.ngaySinh= ng;
            this.ngayCong= ngayCong;
            this.ngayPhep= ngayPhep;
            this.ngayBatDau= ngayBatDau;
            this.TenBang = TenBang;
            this.ChucDanh = ChucDanh;
            this.PhongBan = PhongBan;
            this.ThamNien = ThamNien;
            this.Vung = Vung; 
            this.amount = amount;
        }

        public float TinhLuongThang()
        {
            ThamNien tn = new ThamNien(ThamNien,ngayBatDau);
            BangCap bc = new BangCap(TenBang);
            ChucDanh cd = new ChucDanh(ChucDanh);
            PhongBan pb = new PhongBan(PhongBan);
            float LCB=0;
            switch (Vung)
            {
                case 1:
                    LCB = 4420000f;
                    break;
                   
                case 2:
                    LCB = 3920000f;
                    break;
                   
                case 3:
                    LCB = 3430000f;
                    break;
                   
                case 4:
                    LCB = 3070000f;
                    break;
                    
            }
            return LCB * (tn.HeSoThamNien() + bc.HeSoBangCap() + cd.HeSoChucDanh()) + (LCB * pb.PhuCapPhongBan());

        }

        public float TinhLuongPartTime()
        {
            float heso = 0;
            switch (Vung)
            {
                case 1:
                    heso =  0.53f;
                    break ;
                case 2:
                    heso = 0.50f;
                    break;
                case 3:
                    heso = 0.45f;
                    break;
                case 4:
                     heso = 0.42f;
                    break;

            }
            return TinhLuongThang() * heso;
        }

        public float LuongGio()
        {
            return (TinhLuongThang() / (22 * 8)) * ngayCong;
        }

        // Lương overtime
        public float LuongOverTime(bool flag)
        {
            bool flag2 = true;
            if (flag2 == flag)
            {
                return TinhLuongThang() * 3f;
            }
            return TinhLuongThang() * 1.5f;

        }

        // Thuế thu nhập cá nhân
        public float TNCN()
        {
            float luongThang = SauKhiTruThue();
            if(luongThang < 9000000)
            {
                return 0;
            }
          
          
                
           
 
            if(luongThang > 5000000 && luongThang <= 10000000)
            {
                return luongThang * 0.1f - 250000;
            }

            if (luongThang > 10000000 && luongThang <= 18000000)
            {
                return luongThang * 0.15f - 750000;
               
            }

            if (luongThang > 18000000 && luongThang <= 32000000)
            {
                return luongThang * 0.2f - 1650000;
               
            }

            if (luongThang > 32000000 && luongThang <= 52000000)
            {
                return luongThang * 0.25f - 3250000;
                
            }

            if (luongThang > 52000000 && luongThang <= 800000000)
            {
                return luongThang * 0.3f - 5850000;
               
            }

            if (luongThang > 80000000 )
            {
                return luongThang * 0.35f - 9850000;
            }
            // tien luong < 5000000
            return luongThang * 0.05f;
        }

       

        public float Thue()
        {
            return TinhLuongThang() * (BHTN + BHYT + BHXH);
        }

        public float SauKhiTruThue()
        {
            return TinhLuongThang() - ThuongTet() - Thue() - (amount * 3600000);
        }

        // Tính thưởng tết 

        public float ThuongTet()
        {
            float tienThuongTet = 0;
            int ThangHienTai = DateTime.Today.Month;
            int soThang = ThangHienTai - ngayBatDau.Month;
            if(soThang > 25)
            {
                tienThuongTet = TinhLuongThang()  * 2.5f;
            }
            if(soThang > 18 && soThang <= 25)
            {
                tienThuongTet = TinhLuongThang() * 2.2f;
            }
            if (soThang > 12 && soThang <= 18)
            {
                tienThuongTet = TinhLuongThang() * 2.0f;
            }
            if (soThang > 6 && soThang <= 12)
            {
                tienThuongTet = TinhLuongThang() * 1.7f;
            }
            if (soThang < 6 )
            {
                tienThuongTet = TinhLuongThang() * 1.5f;
            }
            return tienThuongTet;

        }

       
       
    }
    
}
