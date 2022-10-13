using System;
using System.Data;
using System.Net;
using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace PreguntadORT.Models{
    
    public class BD{        

        private static string server = Dns.GetHostName();
        private static string _connectionString = @$"Server={server};DataBase=TIENDAJOYAS;Trusted_Connection=True;";  


    }
}