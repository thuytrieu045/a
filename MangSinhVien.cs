using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamDucThanh_Lab01
{
    internal class MangSinhVien
    {
        private SinhVien[] a;

        public MangSinhVien()
        {
            a = null;
        }

        public MangSinhVien(SinhVien[] a)
        {
            this.a = new SinhVien[a.Length];
            for (int i = 0; i < a.Length; i++)
                this.a[i] = new SinhVien(a[i]);
        }
        public MangSinhVien(MangSinhVien arrSV)
        {
            this.a = new SinhVien[arrSV.a.Length];
            for (int i = 0; i < arrSV.a.Length; i++)
                this.a[i] = new SinhVien(arrSV.a[i]);
        }
        internal SinhVien[] A { get => a; set => a = value; }
        //Bước 4. Cài đặt các phương thức kiểm tra kích thước, nhập và xuất danh sách sinh viên
        public bool KiemTraKichThuoc(int n)
        {
            return n > 0 && n <= 1000000;
        }
        public int NhapN()
        {
            int n = 0;
            while(true)
            {
                Console.Write("Mời nhập (0<n<=1000000) n: ");
                n = int.Parse(Console.ReadLine());
                if(KiemTraKichThuoc(n)) return n;
                Console.WriteLine("Bạn nhập sai, mời nhập lại...");
            }    
        }
        public void Nhap()
        {
            int n = NhapN();
            a = new SinhVien[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = new SinhVien();
                a[i].Nhap();
            }    
        }
        public void Xuat()
        {
            foreach (SinhVien sv in a)
                sv.Xuat();
        }
    }
}
