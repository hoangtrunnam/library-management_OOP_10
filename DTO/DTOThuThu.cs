using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOThuThu
    {
        private string _matt;
        private string _hotennv;
        private int _sdt;
        private string _cccd;
        private string _diachi;

        public string matt
        {
            set
            {
                _matt = value;
            }

            get
            {
                return _matt;
            }
        }

        public string hotennv
        {
            set
            {
                _hotennv = value;
            }

            get
            {
                return _hotennv;
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

        public string cccd
        {
            set
            {
                _cccd = value;
            }

            get
            {
                return _cccd;
            }
        }

        public string diachi
        {
            set
            {
                _diachi = value;
            }

            get
            {
                return _diachi;
            }
        }

        public DTOThuThu(string _matt,
        string _hotennv,
         int _sdt,
         string _cccd,
         string _diachi)
        {
            this._matt = _matt;
            this._hotennv = _hotennv;
            this._sdt = _sdt;
            this._cccd = _cccd;
            this._diachi = _diachi;
        }

        public DTOThuThu() { }
    }
}