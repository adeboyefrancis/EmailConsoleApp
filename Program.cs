// Assignment Email using Console.Methods

// Literals Decalaration
string senderEmail = "francis@touchedbyfrancis.cloud";
string recipientEmail = "customer@gmail.com";
char currencySymbol = '$';
string productName1 = "Iphone 15 Prox Max";
string productName2 = "Samsung Galaxy S24 Ultra";
decimal productPrice1 = 1199.99M;
decimal productPrice2 = 1299.50M;
decimal discountRate = 0.10M; // 10% Discount
decimal startDate = 2024_07_01;
decimal endDate = 2024_07_31;

var from = $"From: {senderEmail}";
var to = $"To: {recipientEmail}";
var greetings = "Dear Customer,";
var subject = "Exciting News: New Product Launch!";
var body = "We are pleased to inform you about our new product launch. \n" +
           $"Introducing the {productName1} priced at {currencySymbol}{productPrice1} and the {productName2} priced at {currencySymbol}{productPrice2}. \n" +
           $"Additonally, we are offering a special discount of {discountRate:P} on all purchases made between {startDate} and {endDate}. \n" +
           "We believe these products will meet your needs and exceed your expectations. \n" +
           "Thank you for being a valued customer.";

var closingMessage = "Best Regards, \nFrancis";

// Console Email Output
Console.WriteLine(from);
Console.WriteLine(to);
Console.WriteLine($"Date: {startDate}");
Console.WriteLine($"Subject: {subject}");
Console.WriteLine(greetings);
Console.WriteLine(body);
Console.WriteLine(closingMessage);

