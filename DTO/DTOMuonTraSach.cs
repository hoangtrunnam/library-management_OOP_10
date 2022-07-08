using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOMuonTraSach
    {
        private int _mamuon;
        private string _mssv;
        private int _masach;
        private string _matt;
        private string _ngaymuon;
        private string _ngayhentra;
        private string _ngaytra;
        private string _songayquahan;
        private string _tienphat;
        private string _statusmoney;
        private string _statusbook;

        DTOMuonTraSach()
        {

        }

        public int maMuon
        {
            set
            {
                _mamuon = value;
            }
            get
            {
                return _mamuon;
                
            }
        }
        public string mssv
        {
            set
            {
                _mssv = value;
            }
            get
            {
                return _mssv;

            }
        }

        public int masach
        {
            set
            {
                _masach = value;
            }
            get
            {
                return _masach;

            }
        }

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

        public string ngaymuon
        {
            set
            {
                _ngaymuon = value;
            }
            get
            {
                return _ngaymuon;

            }
        }

        public string ngayhentra
        {
            set
            {
                _ngayhentra = value;
            }
            get
            {
                return _ngayhentra;

            }
        }

        public string ngaytra
        {
            set
            {
                _ngaytra = value;
            }
            get
            {
                return _ngaytra;

            }
        }

        public string songayquahan
        {
            set
            {
                _songayquahan = value;
            }
            get
            {
                return _songayquahan;

            }
        }

        public string tienphat
        {
            set
            {
                _tienphat = value;
            }
            get
            {
                return _tienphat;

            }
        }

        public string statusmoney
        {
            set
            {
                _statusmoney = value;
            }
            get
            {
                return _statusmoney;

            }
        }

        public string statusBook
        {
            set
            {
                _statusbook = value;
            }
            get
            {
                return _statusbook;

            }
        }


        public DTOMuonTraSach( int _mamuon,
        string _mssv,
        int _masach,
        string _matt,
        string _ngaymuon,
        string _ngayhentra,
        string _ngaytra,
        string _songayquahan,
        string _tienphat,
        string _statusmoney)
        {
            this._mamuon = _mamuon;
            this._mssv = _mssv;
            this._masach = _masach;
            this._matt = _matt;
            this._ngaymuon = _ngaymuon;
            this._ngayhentra = _ngayhentra;
            this._ngaytra = _ngaytra;
            this._songayquahan = _songayquahan;
            this._tienphat = _tienphat;
            this.statusmoney = _statusmoney;
        }

        public DTOMuonTraSach(int _mamuon,
       string _mssv,
       int _masach,
       string _matt,
       string _ngaymuon,
       string _ngayhentra,
       string _statusmoney)
        {
            this._mamuon = _mamuon;
            this._mssv = _mssv;
            this._masach = _masach;
            this._matt = _matt;
            this._ngaymuon = _ngaymuon;
            this._ngayhentra = _ngayhentra;
            this.statusmoney = _statusmoney;
        }
      
        public DTOMuonTraSach(
      string _mssv,
      int _masach,
      string _matt,
      string _ngaymuon,
      string _ngayhentra,
      string _statusmoney)
        {
            
            this._mssv = _mssv;
            this._masach = _masach;
            this._matt = _matt;
            this._ngaymuon = _ngaymuon;
            this._ngayhentra = _ngayhentra;
            this.statusmoney = _statusmoney;
        }
        public DTOMuonTraSach(int _mamuon,
         
       
         string _ngaytra,
         string _songayquahan,
         string _tienphat
         )
        {
            this._mamuon = _mamuon;
           
            this._ngaytra = _ngaytra;
            this._songayquahan = _songayquahan;
            this._tienphat = _tienphat;
            
        }

        public DTOMuonTraSach(int _mamuon,
     
      string _statusmoney)
        {
            this._mamuon = _mamuon;
           
            this.statusmoney = _statusmoney;
        }


        public DTOMuonTraSach(string _statusbook, string _ngaytra, int _mamuon)
        {
            this._mamuon = _mamuon;
            this._ngaytra = _ngaytra;
            this._statusbook= _statusbook;
        }



    }
}
