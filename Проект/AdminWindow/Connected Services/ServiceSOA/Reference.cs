﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminWindow.ServiceSOA {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSOA.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Message", ReplyAction="http://tempuri.org/IService1/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Message", ReplyAction="http://tempuri.org/IService1/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStartID", ReplyAction="http://tempuri.org/IService1/GetStartIDResponse")]
        int GetStartID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStartID", ReplyAction="http://tempuri.org/IService1/GetStartIDResponse")]
        System.Threading.Tasks.Task<int> GetStartIDAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WriteToCart", ReplyAction="http://tempuri.org/IService1/WriteToCartResponse")]
        void WriteToCart(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/WriteToCart", ReplyAction="http://tempuri.org/IService1/WriteToCartResponse")]
        System.Threading.Tasks.Task WriteToCartAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCartRecord", ReplyAction="http://tempuri.org/IService1/CreateCartRecordResponse")]
        void CreateCartRecord(int id, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCartRecord", ReplyAction="http://tempuri.org/IService1/CreateCartRecordResponse")]
        System.Threading.Tasks.Task CreateCartRecordAsync(int id, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetLocation", ReplyAction="http://tempuri.org/IService1/SetLocationResponse")]
        void SetLocation(bool loc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetLocation", ReplyAction="http://tempuri.org/IService1/SetLocationResponse")]
        System.Threading.Tasks.Task SetLocationAsync(bool loc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLocation", ReplyAction="http://tempuri.org/IService1/GetLocationResponse")]
        bool GetLocation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLocation", ReplyAction="http://tempuri.org/IService1/GetLocationResponse")]
        System.Threading.Tasks.Task<bool> GetLocationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnName", ReplyAction="http://tempuri.org/IService1/ReturnNameResponse")]
        string ReturnName(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnName", ReplyAction="http://tempuri.org/IService1/ReturnNameResponse")]
        System.Threading.Tasks.Task<string> ReturnNameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnPrice", ReplyAction="http://tempuri.org/IService1/ReturnPriceResponse")]
        int ReturnPrice(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnPrice", ReplyAction="http://tempuri.org/IService1/ReturnPriceResponse")]
        System.Threading.Tasks.Task<int> ReturnPriceAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Exit", ReplyAction="http://tempuri.org/IService1/ExitResponse")]
        void Exit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Exit", ReplyAction="http://tempuri.org/IService1/ExitResponse")]
        System.Threading.Tasks.Task ExitAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Cart", ReplyAction="http://tempuri.org/IService1/Show_CartResponse")]
        string Show_Cart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Cart", ReplyAction="http://tempuri.org/IService1/Show_CartResponse")]
        System.Threading.Tasks.Task<string> Show_CartAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToProccessOfPatment", ReplyAction="http://tempuri.org/IService1/ToProccessOfPatmentResponse")]
        void ToProccessOfPatment(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToProccessOfPatment", ReplyAction="http://tempuri.org/IService1/ToProccessOfPatmentResponse")]
        System.Threading.Tasks.Task ToProccessOfPatmentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToCook", ReplyAction="http://tempuri.org/IService1/ToCookResponse")]
        void ToCook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToCook", ReplyAction="http://tempuri.org/IService1/ToCookResponse")]
        System.Threading.Tasks.Task ToCookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToDoneWindow", ReplyAction="http://tempuri.org/IService1/ToDoneWindowResponse")]
        void ToDoneWindow();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ToDoneWindow", ReplyAction="http://tempuri.org/IService1/ToDoneWindowResponse")]
        System.Threading.Tasks.Task ToDoneWindowAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetStatusDoneWindow", ReplyAction="http://tempuri.org/IService1/SetStatusDoneWindowResponse")]
        void SetStatusDoneWindow(int id, bool stat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetStatusDoneWindow", ReplyAction="http://tempuri.org/IService1/SetStatusDoneWindowResponse")]
        System.Threading.Tasks.Task SetStatusDoneWindowAsync(int id, bool stat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoCooking", ReplyAction="http://tempuri.org/IService1/DoCookingResponse")]
        void DoCooking(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoCooking", ReplyAction="http://tempuri.org/IService1/DoCookingResponse")]
        System.Threading.Tasks.Task DoCookingAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RejectCooking", ReplyAction="http://tempuri.org/IService1/RejectCookingResponse")]
        void RejectCooking(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RejectCooking", ReplyAction="http://tempuri.org/IService1/RejectCookingResponse")]
        System.Threading.Tasks.Task RejectCookingAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFromCooking", ReplyAction="http://tempuri.org/IService1/DeleteFromCookingResponse")]
        void DeleteFromCooking(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFromCooking", ReplyAction="http://tempuri.org/IService1/DeleteFromCookingResponse")]
        System.Threading.Tasks.Task DeleteFromCookingAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckIfExists", ReplyAction="http://tempuri.org/IService1/CheckIfExistsResponse")]
        bool CheckIfExists(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CheckIfExists", ReplyAction="http://tempuri.org/IService1/CheckIfExistsResponse")]
        System.Threading.Tasks.Task<bool> CheckIfExistsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFromPoP", ReplyAction="http://tempuri.org/IService1/DeleteFromPoPResponse")]
        void DeleteFromPoP(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFromPoP", ReplyAction="http://tempuri.org/IService1/DeleteFromPoPResponse")]
        System.Threading.Tasks.Task DeleteFromPoPAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFromCart", ReplyAction="http://tempuri.org/IService1/DeleteFromCartResponse")]
        void DeleteFromCart(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFromCart", ReplyAction="http://tempuri.org/IService1/DeleteFromCartResponse")]
        System.Threading.Tasks.Task DeleteFromCartAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnNameFromOrder", ReplyAction="http://tempuri.org/IService1/ReturnNameFromOrderResponse")]
        string ReturnNameFromOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnNameFromOrder", ReplyAction="http://tempuri.org/IService1/ReturnNameFromOrderResponse")]
        System.Threading.Tasks.Task<string> ReturnNameFromOrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnPriceFromOrder", ReplyAction="http://tempuri.org/IService1/ReturnPriceFromOrderResponse")]
        int ReturnPriceFromOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReturnPriceFromOrder", ReplyAction="http://tempuri.org/IService1/ReturnPriceFromOrderResponse")]
        System.Threading.Tasks.Task<int> ReturnPriceFromOrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorization", ReplyAction="http://tempuri.org/IService1/AuthorizationResponse")]
        int Authorization(string email, string password, string position);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorization", ReplyAction="http://tempuri.org/IService1/AuthorizationResponse")]
        System.Threading.Tasks.Task<int> AuthorizationAsync(string email, string password, string position);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Orders", ReplyAction="http://tempuri.org/IService1/Show_OrdersResponse")]
        string Show_Orders(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Orders", ReplyAction="http://tempuri.org/IService1/Show_OrdersResponse")]
        System.Threading.Tasks.Task<string> Show_OrdersAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Orders_By_Number", ReplyAction="http://tempuri.org/IService1/Show_Orders_By_NumberResponse")]
        string Show_Orders_By_Number(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Orders_By_Number", ReplyAction="http://tempuri.org/IService1/Show_Orders_By_NumberResponse")]
        System.Threading.Tasks.Task<string> Show_Orders_By_NumberAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountOrders", ReplyAction="http://tempuri.org/IService1/CountOrdersResponse")]
        int CountOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CountOrders", ReplyAction="http://tempuri.org/IService1/CountOrdersResponse")]
        System.Threading.Tasks.Task<int> CountOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Done_Order", ReplyAction="http://tempuri.org/IService1/Delete_Done_OrderResponse")]
        void Delete_Done_Order(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Done_Order", ReplyAction="http://tempuri.org/IService1/Delete_Done_OrderResponse")]
        System.Threading.Tasks.Task Delete_Done_OrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Done_Orders", ReplyAction="http://tempuri.org/IService1/Show_Done_OrdersResponse")]
        string Show_Done_Orders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_Done_Orders", ReplyAction="http://tempuri.org/IService1/Show_Done_OrdersResponse")]
        System.Threading.Tasks.Task<string> Show_Done_OrdersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AdminWindow.ServiceSOA.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AdminWindow.ServiceSOA.IService1>, AdminWindow.ServiceSOA.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public int GetStartID() {
            return base.Channel.GetStartID();
        }
        
        public System.Threading.Tasks.Task<int> GetStartIDAsync() {
            return base.Channel.GetStartIDAsync();
        }
        
        public void WriteToCart(int id) {
            base.Channel.WriteToCart(id);
        }
        
        public System.Threading.Tasks.Task WriteToCartAsync(int id) {
            return base.Channel.WriteToCartAsync(id);
        }
        
        public void CreateCartRecord(int id, int amount) {
            base.Channel.CreateCartRecord(id, amount);
        }
        
        public System.Threading.Tasks.Task CreateCartRecordAsync(int id, int amount) {
            return base.Channel.CreateCartRecordAsync(id, amount);
        }
        
        public void SetLocation(bool loc) {
            base.Channel.SetLocation(loc);
        }
        
        public System.Threading.Tasks.Task SetLocationAsync(bool loc) {
            return base.Channel.SetLocationAsync(loc);
        }
        
        public bool GetLocation() {
            return base.Channel.GetLocation();
        }
        
        public System.Threading.Tasks.Task<bool> GetLocationAsync() {
            return base.Channel.GetLocationAsync();
        }
        
        public string ReturnName(int id) {
            return base.Channel.ReturnName(id);
        }
        
        public System.Threading.Tasks.Task<string> ReturnNameAsync(int id) {
            return base.Channel.ReturnNameAsync(id);
        }
        
        public int ReturnPrice(int id) {
            return base.Channel.ReturnPrice(id);
        }
        
        public System.Threading.Tasks.Task<int> ReturnPriceAsync(int id) {
            return base.Channel.ReturnPriceAsync(id);
        }
        
        public void Exit() {
            base.Channel.Exit();
        }
        
        public System.Threading.Tasks.Task ExitAsync() {
            return base.Channel.ExitAsync();
        }
        
        public string Show_Cart() {
            return base.Channel.Show_Cart();
        }
        
        public System.Threading.Tasks.Task<string> Show_CartAsync() {
            return base.Channel.Show_CartAsync();
        }
        
        public void ToProccessOfPatment(int id) {
            base.Channel.ToProccessOfPatment(id);
        }
        
        public System.Threading.Tasks.Task ToProccessOfPatmentAsync(int id) {
            return base.Channel.ToProccessOfPatmentAsync(id);
        }
        
        public void ToCook(int id) {
            base.Channel.ToCook(id);
        }
        
        public System.Threading.Tasks.Task ToCookAsync(int id) {
            return base.Channel.ToCookAsync(id);
        }
        
        public void ToDoneWindow() {
            base.Channel.ToDoneWindow();
        }
        
        public System.Threading.Tasks.Task ToDoneWindowAsync() {
            return base.Channel.ToDoneWindowAsync();
        }
        
        public void SetStatusDoneWindow(int id, bool stat) {
            base.Channel.SetStatusDoneWindow(id, stat);
        }
        
        public System.Threading.Tasks.Task SetStatusDoneWindowAsync(int id, bool stat) {
            return base.Channel.SetStatusDoneWindowAsync(id, stat);
        }
        
        public void DoCooking(int id) {
            base.Channel.DoCooking(id);
        }
        
        public System.Threading.Tasks.Task DoCookingAsync(int id) {
            return base.Channel.DoCookingAsync(id);
        }
        
        public void RejectCooking(int id) {
            base.Channel.RejectCooking(id);
        }
        
        public System.Threading.Tasks.Task RejectCookingAsync(int id) {
            return base.Channel.RejectCookingAsync(id);
        }
        
        public void DeleteFromCooking(int id) {
            base.Channel.DeleteFromCooking(id);
        }
        
        public System.Threading.Tasks.Task DeleteFromCookingAsync(int id) {
            return base.Channel.DeleteFromCookingAsync(id);
        }
        
        public bool CheckIfExists(int id) {
            return base.Channel.CheckIfExists(id);
        }
        
        public System.Threading.Tasks.Task<bool> CheckIfExistsAsync(int id) {
            return base.Channel.CheckIfExistsAsync(id);
        }
        
        public void DeleteFromPoP(int id) {
            base.Channel.DeleteFromPoP(id);
        }
        
        public System.Threading.Tasks.Task DeleteFromPoPAsync(int id) {
            return base.Channel.DeleteFromPoPAsync(id);
        }
        
        public void DeleteFromCart(int id) {
            base.Channel.DeleteFromCart(id);
        }
        
        public System.Threading.Tasks.Task DeleteFromCartAsync(int id) {
            return base.Channel.DeleteFromCartAsync(id);
        }
        
        public string ReturnNameFromOrder(int id) {
            return base.Channel.ReturnNameFromOrder(id);
        }
        
        public System.Threading.Tasks.Task<string> ReturnNameFromOrderAsync(int id) {
            return base.Channel.ReturnNameFromOrderAsync(id);
        }
        
        public int ReturnPriceFromOrder(int id) {
            return base.Channel.ReturnPriceFromOrder(id);
        }
        
        public System.Threading.Tasks.Task<int> ReturnPriceFromOrderAsync(int id) {
            return base.Channel.ReturnPriceFromOrderAsync(id);
        }
        
        public int Authorization(string email, string password, string position) {
            return base.Channel.Authorization(email, password, position);
        }
        
        public System.Threading.Tasks.Task<int> AuthorizationAsync(string email, string password, string position) {
            return base.Channel.AuthorizationAsync(email, password, position);
        }
        
        public string Show_Orders(int id) {
            return base.Channel.Show_Orders(id);
        }
        
        public System.Threading.Tasks.Task<string> Show_OrdersAsync(int id) {
            return base.Channel.Show_OrdersAsync(id);
        }
        
        public string Show_Orders_By_Number(int id) {
            return base.Channel.Show_Orders_By_Number(id);
        }
        
        public System.Threading.Tasks.Task<string> Show_Orders_By_NumberAsync(int id) {
            return base.Channel.Show_Orders_By_NumberAsync(id);
        }
        
        public int CountOrders() {
            return base.Channel.CountOrders();
        }
        
        public System.Threading.Tasks.Task<int> CountOrdersAsync() {
            return base.Channel.CountOrdersAsync();
        }
        
        public void Delete_Done_Order(int id) {
            base.Channel.Delete_Done_Order(id);
        }
        
        public System.Threading.Tasks.Task Delete_Done_OrderAsync(int id) {
            return base.Channel.Delete_Done_OrderAsync(id);
        }
        
        public string Show_Done_Orders() {
            return base.Channel.Show_Done_Orders();
        }
        
        public System.Threading.Tasks.Task<string> Show_Done_OrdersAsync() {
            return base.Channel.Show_Done_OrdersAsync();
        }
    }
}
