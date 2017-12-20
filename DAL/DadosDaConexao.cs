using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get
            {
                return "Data Source=NOTE-EDSON\\SQLEXPRESS;Initial Catalog=CeciliaChocolate;Integrated Security=True";
                //return "server=192.168.25.103;user id=root;database=CeciliaChocolate;persistsecurityinfo=True";
            }
        }
    }
}
