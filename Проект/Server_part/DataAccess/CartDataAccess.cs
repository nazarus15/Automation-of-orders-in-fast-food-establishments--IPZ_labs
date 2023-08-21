using Server_part.Models;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Server_part.DataAccess
{
    class CartDataAccess
    {
        private const string ConnectionString = "mongodb://localhost:27017";
        private const string DatabaseName = "IPZ_project";
        private const string CartCollection = "Cart";
        private const string UserCollection = "users";
        private const string ChoreHistoryCollection = "chore_history";

        //func that connects to collection
        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        //return all in cart collection
        private async Task<List<CartModel>> GetAllInCart()
        {
            var cartsCollection = ConnectToMongo<CartModel>(CartCollection);
            var results = await cartsCollection.FindAsync(_ => true);
            return results.ToList();
        }

        //create cart record
        //public Task CreateCartRecord(CartModel cart)
        //{
        //    var cartsCollection = ConnectToMongo<CartModel>(CartCollection);
        //   /*var client = new MongoClient(ConnectionString);
        //    var db = client.GetDatabase(DatabaseName);
        //    var cartsCollection = db.GetCollection<CartModel>(CartCollection);*/
        //    return cartsCollection.InsertOneAsync(cart);
        //}

        //update or insert record in cart if matches "id"
        public Task UpdateCart(CartModel cart)
        {
            var cartsCollection = ConnectToMongo<CartModel>(CartCollection);
            var filter = Builders<CartModel>.Filter.Eq("Id", cart.Cart_ID);
            return cartsCollection.ReplaceOneAsync(filter, cart, new ReplaceOptions { IsUpsert = true });
        }

        //delete record in cart
        public Task DeleteCart(CartModel cart)
        {
            var cartsCollection = ConnectToMongo<CartModel>(CartCollection);
            return cartsCollection.DeleteOneAsync(c => c.Cart_ID == cart.Cart_ID);
        }

    }


}

