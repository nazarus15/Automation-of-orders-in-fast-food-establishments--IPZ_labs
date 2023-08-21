using MongoDB.Driver;
using Server_part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Server_part.DataAccess;
using System.Threading.Tasks;

namespace Server_part
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private static int start_id = 0;
        private static bool location = true;

        public string Message ()
        {
            string str = "Hello";
            return str;
        }




        //public void Generate_start_id()
        //{
        //    string connectionString = "mongodb://localhost:27017";
        //    string databaseName = "IPZ_project";
        //    string collectionName = "Client_number";

        //    var client = new MongoClient(connectionString);
        //    var db = client.GetDatabase(databaseName);
        //    var collection = db.GetCollection<ClientNumberModule>(collectionName);

        //    var result = collection.Find(_ => true).ToListAsync().Result;

        //    int temp;

        //    foreach (var user in result)
        //    {
        //        temp = user.start_ID;
        //        if (start_id <= temp)
        //        {
        //            start_id = temp + 1;
        //        }
        //    }

        //    var check = new ClientNumberModule { start_ID = start_id};

        //    collection.InsertOneAsync(check);
        //}


        public int GetStartID()
        {
            return start_id;
        }
        public void Exit()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Client_number";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<ClientNumberModule>(collectionName);

            var result = collection.Find(_ => true).ToListAsync().Result;

            int temp;

            foreach (var user in result)
            {
                temp = user.start_ID;
                if (start_id <= temp)
                {
                    start_id = temp + 1;
                }
            }

            var check = new ClientNumberModule { start_ID = start_id };

            collection.InsertOneAsync(check);
        }

        public void WriteToCart(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Cart";

            //connect to collection in db or create collection
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CartModel>(collectionName);

            var check = new CartModel { Cart_ID = id, Name = "Bulba", Amount = 2, Price = 200 };

            collection.InsertOneAsync(check);
        }

        public void ToProccessOfPatment (int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Process_of_payment";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<ProcessOfPaymentModel>(collectionName);

            var process_collection = new ProcessOfPaymentModel { Client_ID = start_id, Price = ReturnPriceFromOrder(start_id)};
            cartsCollection.InsertOne(process_collection);
        }

        public void ToCook(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CookModel>(collectionName);

            var process_collection = new CookModel { Order_ID = start_id, Order = ReturnNameFromOrder(start_id), Status = false};
            collection.InsertOne(process_collection);
        }

        public void ToDoneWindow()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "DoneWindow";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<DoneModel>(collectionName);

            var process_collection = new DoneModel { OrderDone_ID = start_id, Status = false };
            collection.InsertOne(process_collection);
        }

        public string Show_Done_Window(bool stat)
        {
            string str = "";

            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "DoneWindow";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<DoneModel>(collectionName);

            var result = cartsCollection.Find(b => b.Status == stat).ToListAsync().Result;


            foreach (var user in result)
            {
                str += user.OrderDone_ID + "\n";
            }

            return str;
        }


        public void SetStatusDoneWindow(int id,bool stat)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "DoneWindow";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<DoneModel>(collectionName);

            DoneModel bill = collection.Find(x => x.OrderDone_ID.Equals(id)).FirstOrDefault();
            bill.Status = stat;
            collection.ReplaceOne(x => x.OrderDone_ID.Equals(id), bill);
        }

        public bool CheckIfExists(int id)
        {
            bool ret = false;

            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CookModel>(collectionName);

            var result = collection.Find(b => b.Order_ID == id).ToListAsync().Result;

            foreach (var user in result)
            {
                if (user.Order_ID==id)
                {
                    ret = true;
                }
            }

            return ret;
        }
        public void DoCooking(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CookModel>(collectionName);

            CookModel bill = collection.Find(x => x.Order_ID.Equals(id)).FirstOrDefault();
            bill.Status = true;
            collection.ReplaceOne(x => x.Order_ID.Equals(id),bill);
        }

        public void RejectCooking(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CookModel>(collectionName);

            CookModel bill = collection.Find(x => x.Order_ID.Equals(id)).FirstOrDefault();
            bill.Status = false;
            collection.ReplaceOne(x => x.Order_ID.Equals(id), bill);
        }

        public void DeleteFromCooking(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CookModel>(collectionName);

            collection.DeleteOne(x => x.Order_ID == id);
        }

        public void DeleteFromPoP(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Process_of_payment";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<ProcessOfPaymentModel>(collectionName);

            collection.DeleteOne(x => x.Client_ID == start_id);
        }

        public void DeleteFromCart(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Cart";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<CartModel>(collectionName);

            collection.DeleteMany(x => x.Cart_ID == start_id);
        }

        public int ReturnPriceFromOrder(int id)
       {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Cart";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CartModel>(collectionName);

            var result = cartsCollection.Find(b => b.Cart_ID == id).ToListAsync().Result;

            int price = 0;

            foreach (var user in result)
            {
                price += user.Price;
            }

            return price;
       }

        public void SetLocation(bool loc)
        {
            location = loc;
        }

        public bool GetLocation()
        {
            return location;
        }

        public void CreateCartRecord(int id, int amount)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Cart";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CartModel>(collectionName);

            var cart = new CartModel { Cart_ID = start_id, Name = ReturnName(id), Amount = amount, Price = ReturnPrice(id)*amount, Location = GetLocation()};
            cartsCollection.InsertOne(cart);
        }

        public string ReturnName(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Menu";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<MenuModel>(collectionName);

            var result = cartsCollection.Find(b => b.Menu_ID == id).ToListAsync().Result;

            string str = "";

            foreach (var user in result)
            {
                str = user.Name;
            }

            return str;
        }

        public string ReturnNameFromOrder(int id)
        {
            string str = "";

            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Cart";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CartModel>(collectionName);

            var result = cartsCollection.Find(b => b.Cart_ID == id).ToListAsync().Result;

            int prev_id = 0;
            foreach (var user in result)
            {
                if(prev_id == 0)
                {
                    str += user.Name + ": " + user.Amount;
                }
                else
                {
                    str += "\n" + user.Name + ": " + user.Amount;
                }
                prev_id++;

            }
            return str;
        }

        public int ReturnPrice(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Menu";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<MenuModel>(collectionName);

            var result = cartsCollection.Find(b => b.Menu_ID == id).ToListAsync().Result;

            int price = 0;

            foreach (var user in result)
            {
                price = user.Price;
            }

            return price;
        }

        public string Show_Cart()
        {
            string str = "Номер твого замовлення: " + start_id + "\n\n";
            str += "Страва або напій\t\tКількість\t\tЦіна\n";

            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "Cart";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CartModel>(collectionName);

            var result = cartsCollection.Find(b => b.Cart_ID == start_id).ToListAsync().Result;

            string temp_str = "";
            foreach (var user in result)
            {
                temp_str = (user.Name);
                if (temp_str.Length > 7)
                {
                    str += user.Name + "\t\t" + user.Amount + "\t\t" + user.Price + "\n";
                }
                else
                { str += user.Name + "\t\t\t" + user.Amount + "\t\t" + user.Price + "\n"; }
            }

            return str;
        }
        
        
        // for personal

        public int Authorization(string email, string password, string position)
        {
            int Succes = 0;
            // 0 - без помилок // 1 - не існує імейла // 2 і 3  - неправильний пароль // 7 i 8 - неправильна позиція

            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "List_of_workers";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<WorkersModule>(collectionName);

            var result = collection.Find(_ => true).ToListAsync().Result;

            bool email_B = false;
            bool email_B2 = false;
            bool password_B = false;
            bool password_B2 = false;
            bool position_B = false;
            foreach (var user in result)
            {
                if (email == user.Email)
                {
                    email_B = true;
                    email_B2 = true;
                }
                //else
                //{
                //    email_B2 = false;
                //}
                if ((email_B == true) && (password == user.Password))
                {
                    password_B = true;
                    password_B2 = true;
                }
                //else
                //{
                //    password_B2 = false;
                //}
                if((email_B2 == true) && (password_B2 == true) && position == user.Position)
                {
                    position_B = true;
                }
                //else
                //{
                //    position_B = false;
                //}
            }

            if (email_B == false)
            {
                Succes++;
            }
            if ((email_B == true) && (password_B == false))
            {
                Succes = Succes + 2;
            }
            if ((email_B == true) && (password_B == true) && (position_B == false))
            { 
                Succes = Succes + 5; 
            }
            return Succes;
        }

        public int CountOrders()
        {
            int count = 0;
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CookModel>(collectionName);

            var result = cartsCollection.Find(_ => true).ToListAsync().Result;

            foreach (var user in result)
            {
                count++;
            }

            return count;
        }
        public string Show_Orders(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CookModel>(collectionName);

            var result = cartsCollection.Find(_ => true).ToListAsync().Result;

            string[] order = new string[CountOrders()];
            int prev_order = 0;
            int counter = 0;
            foreach (var user in result)
            {
                if (prev_order != user.Order_ID && user.Status == false)
                {
                    order[counter] = user.Order_ID.ToString() + ":\n";
                    order[counter] += user.Order;
                    counter += 1;
                }
                else if (user.Status == false)
                {
                    order[counter - 1] += user.Order;
                }
                prev_order = user.Order_ID;
            }

            return order[id];
        }

        public string Show_Orders_By_Number(int id)
        {
            string str = "";
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "CookProcess";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<CookModel>(collectionName);

            var result = cartsCollection.Find(x =>x.Order_ID == id).ToListAsync().Result;
            
            foreach (var user in result)
            {
                str = user.Order_ID.ToString() + ":\n" + user.Order;
            }
            return str;
        }

        // for admin
        public string Show_Done_Orders()
        {
            string str = "";
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "DoneWindow";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var cartsCollection = db.GetCollection<DoneModel>(collectionName);

            var result = cartsCollection.Find(x => x.Status == true).ToListAsync().Result;

            foreach (var user in result)
            {
                str += user.OrderDone_ID.ToString() + "\n";
            }
            return str;
        }

        public void Delete_Done_Order(int id)
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "IPZ_project";
            string collectionName = "DoneWindow";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<DoneModel>(collectionName);

            collection.DeleteOne(x => x.OrderDone_ID == id);
        }

    }

}


