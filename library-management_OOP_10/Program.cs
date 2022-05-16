using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_OOP_10
{

    static class GlobalVar
    {
        // định nghĩa các tên các bảng và tên domain,database ở đây.
        // muốn dùng được thì phải đổi đường dẫn _globalDomain
        // tên database bắt buộc phải là lib_Management
        // các phương thức chỉ được phép get, cấm sử dụng set

        private static string _globalDomain = "PC-PC\\SQLEXPRESS";
        private static string _globalDataBase = "lib_Management";

        public static string GlobalDomain
        {
            get { return _globalDomain; }
        }

        public static string globalDataBase
        {
            get { return _globalDataBase; }
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
        }
    }
}
