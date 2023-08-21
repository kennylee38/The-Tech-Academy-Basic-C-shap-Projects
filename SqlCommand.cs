using System.Data.SqlClient;

namespace Newsletter.Controllers
{
    internal class SqlCommand
    {
        internal object Parameters;
        private string queryString;
        private SqlConnection connection;

        public SqlCommand(string queryString, SqlConnection connection)
        {
        }

        public SqlCommand(string queryString, SqlConnection connection)
        {
            this.queryString = queryString;
            this.connection = connection;
        }
    }
}