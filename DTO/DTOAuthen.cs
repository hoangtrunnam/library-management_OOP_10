using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOAuthen
    {
        private string _matt;
        private string _matkhau;
        private string _phanquyen;

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


        public string matkhau
        {
            set
            {
                _matkhau = value;
            }

            get
            {
                return _matkhau;
            }
        }

        public string phanquyen
        {
            set
            {
                _phanquyen = value;
            }

            get
            {
                return _phanquyen;
            }
        }

        public DTOAuthen(string matt, string matkhau, string phanquyen)
        {
            this._matt = matt;
            this._matkhau = matkhau;
            this._phanquyen = phanquyen;
        }
    }

   
}
