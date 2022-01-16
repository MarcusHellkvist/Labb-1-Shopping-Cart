// See https://aka.ms/new-console-template for more information
using Labb_1_Marcus_Hellkvist.Models;

Console.WriteLine("WELCOME TO MY SHOP");

// products
var milk = new Item(1, "Milk", 50);
var bread = new Item(2, "Bread", 80);
var coffee = new Item(3, "Coffee", 30);
var tea = new Item(4, "Tea", 60);
var soda = new Item(5, "Soda", 80);
var water = new Item(6, "Water", 10);

// cart
var cart = new Cart();

// discount algorithms
var discountThreeForTwo = new DiscountThreeForTwo();
var discountTenPercent = new DiscountTenPercent();
var discountCheapestItem = new DiscountCheapestItem();

// credit card
var masterCard = new MasterCard(400);

// observer
var UIController = new UIController();

cart.Attach(UIController);

cart.AddItem(milk);
cart.AddItem(milk);
cart.AddItem(bread);
cart.AddItem(coffee);
cart.AddItem(coffee);
cart.AddItem(coffee);
cart.AddItem(tea);
cart.AddItem(soda);
cart.AddItem(soda);
cart.AddItem(soda);
cart.AddItem(soda);
cart.AddItem(water);

cart.RemoveItem(milk);

cart.CalculateDiscount(discountThreeForTwo);
cart.CalculateDiscount(discountCheapestItem);
cart.CalculateDiscount(discountTenPercent);

CheckoutController.CheckOut(cart);
if (CheckoutController.Pay(masterCard, cart))
{
    Console.WriteLine("Card Approved!");
}
else 
{
    Console.WriteLine("Card Declined");
}
