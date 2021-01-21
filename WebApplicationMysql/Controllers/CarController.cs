//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using MySql.Data.MySqlClient;
//using MysqlCrud.EntityFramework;
//using System.Text;
//namespace WebApplicationMysql.Controllers
//{
   
//    public class CarController : ApiController
//    {
//        Parking context = getContext();



//        public static IEnumerable<Car> Get()
//        {
//            using (Parking entities = new Parking())
//            {
//                return entities.Cars.ToList();
//            }
//        }
//        public static void addCar(Parking context, Car obj)
//        {
//            context.Cars.Add(obj);
//            context.SaveChanges();

//        }
//        public static void addCarList(Parking context, List<Car> obj)
//        {
//            context.Cars.AddRange(obj);
//            context.SaveChanges();

//        }
//        public static MySqlConnection connection;

//        public static object CustomerEntities { get; private set; }

//        public static Parking getContext()
//        {
//            string connectionString = "server=localhost;database=Parking;userid=root;password=1234";
//            if (connection?.State != System.Data.ConnectionState.Closed)
//            {
//                connection?.Close();
//            }
//            connection = new MySqlConnection(connectionString);


//            using (Parking contextDB = new Parking(connection, false))
//            {
//                contextDB.Database.CreateIfNotExists();
//            }

//            connection.Open();
//            try
//            {
//                return new Parking(connection, false);
//            }
//            catch (Exception err)
//            {
//                Console.WriteLine(err);
//                return null;
//            }

//        }
//    }
//}
    
