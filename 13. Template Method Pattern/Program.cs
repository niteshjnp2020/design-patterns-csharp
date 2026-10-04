// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var onlineOrder = new OnlineOrderProcessor();

onlineOrder.ProcessOrder();
var storeOrder = new StoreOrderProcessor();

storeOrder.ProcessOrder();
