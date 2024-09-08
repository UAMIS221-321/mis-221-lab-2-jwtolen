//initialize variables
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;

//initialize constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

//prompt the user for # of sandwiches
System.Console.WriteLine("How many sandwiches?");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches "+numberOfSandwiches);

//prompt user for # of toppings needed
System.Console.WriteLine("How many toppings?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toppings "+numberOfToppings);

//prompt user for the tip
System.Console.WriteLine("How much would you like to tip?");
tip = double.Parse(Console.ReadLine());
System.Console.WriteLine("Tip "+tip);

//calculate base cost
totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;

//incorporate tip and discount
double discountedCost = baseCost * (1 - DISCOUNT_AMOUNT);
double orderCost = discountedCost + tip;

//Display final price
System.Console.WriteLine("Total Price: "+orderCost.ToString("F2"));