using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace WindowsFormTP1.Model
{
    internal class ConnexionBDD
    {
        private string DBServer = "192.168.10.16", DBName = "levalegant_sam_quizzAndTest", DBLogin = "levalegant_sam", DBPassword = "Js37s0LW";
        private MySqlConnection mySqlCo;
        public ConnexionBDD()
        {
            initConnexion();
        }

        public MySqlConnection MySqlCo { get => mySqlCo; set => mySqlCo = value; }


        private void initConnexion()
        {
            MySqlCo = new MySqlConnection("Server=" + DBServer + ";Database=" + DBName + ";User ID=" + DBLogin + ";Password=" + DBPassword);
        }

    }
}
