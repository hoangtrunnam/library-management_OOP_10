using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCheckLogin
    {
        private string _maTT;
        private string _matKhau;

        public string maTT { get { return _maTT; } set { _maTT = value; } }
        public string matKhau { get { return _matKhau; } set { _matKhau = value; } }

        public DTOCheckLogin()
        {

        }
        public DTOCheckLogin(string maTT, string matKhau)
        {
            this._maTT = maTT;
            this._matKhau=matKhau;
        }
    }
}
