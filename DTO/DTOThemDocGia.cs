using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOThemDocGia
    {
        private string _Mssv;
        private string _hoTenSV;
        private string _gioiTinh;
        private string _lop;
        private string _khoa;
        private int _sdt;

        public string Mssv
        {
            set
            {
                _Mssv = value;
            }

            get
            {
                return _Mssv;
            }
        }

        public string hoTenSV
        {
            set
            {
                _hoTenSV = value;
            }

            get
            {
                return _hoTenSV;
            }
        }

        public string gioiTinh
        {
            set
            {
                _gioiTinh = value;
            }

            get
            {
                return _gioiTinh;
            }
        }

        public string lop
        {
            set
            {
                _lop = value;
            }

            get
            {
                return _lop;
            }
        }

        public string khoa
        {
            set
            {
                _khoa = value;
            }

            get
            {
                return _khoa;
            }
        }

        public int sdt
        {
            set
            {
                _sdt = value;
            }

            get
            {
                return _sdt;
            }
        }

        public DTOThemDocGia()
        {

        }

        public DTOThemDocGia(string mssv, string hoten, string gioitinh, string lop, string khoa, int sdt)
        {
            this._Mssv = mssv;
            this._hoTenSV = hoten;
            this._gioiTinh = gioitinh;
            this._khoa = khoa;
            this.lop = lop;
            this.sdt = sdt;
        }



    }


}
