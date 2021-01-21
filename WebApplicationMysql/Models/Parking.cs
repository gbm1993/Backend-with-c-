//using System.Data.Common;
//using MySql.Data.Entity;
//using System.Data.Entity;
//using MySql.Data.MySqlClient;

//namespace MysqlCrud.EntityFramework
//{
//    [DbConfigurationType(typeof(MySqlEFConfiguration))]
//    public class Parking : DbContext
//    {
//        public DbSet<Car> Cars { get; set; }
//        public static MySqlConnection _connection;
//        public static Parking parkingContext;

//        public Parking()
//          : base()
//        {
             
//            string connectionString = "server=localhost;database=Parking;userid=root;password=1234";
//            if (_connection?.State != System.Data.ConnectionState.Closed)
//            {
//                _connection?.Close();
//            }
//            _connection = new MySqlConnection(connectionString);


//            using (Parking contextDB = new Parking(_connection, false))
//            {
//                contextDB.Database.CreateIfNotExists();
//            }

//            _connection.Open();
//            parkingContext = new Parking(_connection, false);
//    }
        
//        public Parking(DbConnection existingConnection, bool contextOwnsConnection)
//          : base(existingConnection, contextOwnsConnection)
//        {

//        }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.Entity<Car>().MapToStoredProcedures();
//        }
//    }

//    public class Car
//    {
//        public int CarId { get; set; }

//        public string Model { get; set; }

//        public int Year { get; set; }

//        public string Manufacturer { get; set; }
//    }

//    public class Employee
//    {
//        public int Empid { get; set; }

//}
