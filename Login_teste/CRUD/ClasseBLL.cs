using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Login_teste.CRUD
{
    class ClasseBLL
    {
        Conectar conection = null;

        public DataTable ExibirDadosBD()
        {
            try
            {
                DataTable dataTable = new DataTable();
                conection = new Conectar();

                dataTable = conection.Exibir();

                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
