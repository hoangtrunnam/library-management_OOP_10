﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-62VA20P\\HOANGNAM;Initial Catalog=lib_Management2;Integrated Security=True");
        protected SqlDataReader sdr;
    }
}
