using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server_part
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Message();

        [OperationContract]
        int GetStartID();
        [OperationContract]
        void WriteToCart(int id);
        //[OperationContract]
        //void WriteToCart1();
        [OperationContract]
        void CreateCartRecord(int id, int amount);
        [OperationContract]
        void SetLocation(bool loc);
        [OperationContract]
        bool GetLocation();


        [OperationContract]
        string ReturnName(int id);

        //[OperationContract]
        //void Generate_start_id();

        [OperationContract]
        int ReturnPrice(int id);

        [OperationContract]
        void Exit();

        [OperationContract]
        string Show_Cart();

        [OperationContract]
        void ToProccessOfPatment(int id);

        [OperationContract]
        void ToCook (int id);
        [OperationContract]
        void ToDoneWindow();

        [OperationContract]
        void SetStatusDoneWindow(int id, bool stat);
        [OperationContract]
        void DoCooking(int id);
        [OperationContract]
        void RejectCooking(int id);
        [OperationContract]
        void DeleteFromCooking(int id);
        [OperationContract]
        bool CheckIfExists(int id);
        [OperationContract]
        void DeleteFromPoP(int id);
        [OperationContract]
        void DeleteFromCart(int id);
        [OperationContract]
        string ReturnNameFromOrder(int id);
        [OperationContract]
        int ReturnPriceFromOrder(int id);
        [OperationContract]
        int Authorization(string email, string password, string position);
        [OperationContract]
        string Show_Orders(int id);
        [OperationContract]
        string Show_Orders_By_Number(int id);
        [OperationContract]
        int CountOrders();
        [OperationContract]
        void Delete_Done_Order(int id);
        [OperationContract]
        string Show_Done_Orders();

    }
}
