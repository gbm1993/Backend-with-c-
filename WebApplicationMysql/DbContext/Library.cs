using MySql.Data.Entity;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using WebApplicationMysql.Models;
using System.Data.Common;

namespace WebApplicationMysql.DbContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Library : System.Data.Entity.DbContext
    {

        public DbSet<Book> Books { get; set; }
        public static MySqlConnection _connection;
        public Library libraryContext;

        public Library()
          : base()
        {

            string connectionString = "server=localhost;database=Library;userid=root;password=1234";
            if (_connection?.State != System.Data.ConnectionState.Closed)
            {
                _connection?.Close();
            }
            _connection = new MySqlConnection(connectionString);


            using (Library contextDB = new Library(_connection, false))
            {
                contextDB.Database.CreateIfNotExists();
            }

            _connection.Open();
            libraryContext = new Library(_connection, false);
        }

        public Library(DbConnection existingConnection, bool contextOwnsConnection)
          : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().MapToStoredProcedures();
        }
    }
}