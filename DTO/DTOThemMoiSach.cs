using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOThemMoiSach
    {
        private int _masach;
        private string _tensach;
        private string _tentacgia;
        private string _nhaxuatban;
        private string _ngaymuasach;
        private float _giasach;
        private float _soluong;
        private string _kesach;



        public int maSach
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

        public string kesach
        {
            set
            {
                _kesach = value;
            }

            get
            {
                return _kesach;
            }
        }

        public float soluong
        {
            set
            {
                _soluong = value;
            }

            get
            {
                return _soluong;
            }
        }

        public float giasach
        {
            set
            {
                _giasach = value;
            }

            get
            {
                return _giasach;
            }
        }

        public string ngaymuasach
        {
            set
            {
                _ngaymuasach = value;
            }

            get
            {
                return _ngaymuasach;
            }
        }

        public string nhaxuatban
        {
            set
            {
                _nhaxuatban = value;
            }

            get
            {
                return _nhaxuatban;
            }
        }

        public string tensach
        {
            set
            {
                _tensach = value;
            }

            get
            {
                return _tensach;
            }
        }

        public string tentacgia
        {
            set
            {
                _tentacgia = value;
            }

            get
            {
                return _tentacgia;
            }
        }


        public DTOThemMoiSach()
        {


        }

        public DTOThemMoiSach(
        string tensach,
        string tentacgia,
        string nhaxuatban,
        string ngaymuasach,
        float giasach,
        float soluong,
        string kesach)
        {
            this._tensach = tensach;
            this._tentacgia = tentacgia;
            this._nhaxuatban = nhaxuatban;
            this._ngaymuasach = ngaymuasach;
            this._giasach = giasach;
            this._soluong = soluong;
            this._kesach = kesach;
        }

        public DTOThemMoiSach(
        
        string tensach,
        string tentacgia,
        string nhaxuatban,
        string ngaymuasach,
        float giasach,
        float soluong,
        string kesach,
        int masach)
        {
            this._masach = masach;
            this._tensach = tensach;
            this._tentacgia = tentacgia;
            this._nhaxuatban = nhaxuatban;
            this._ngaymuasach = ngaymuasach;
            this._giasach = giasach;
            this._soluong = soluong;
            this._kesach = kesach;
        }



    }


}
