Random dice = new Random(0);
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

string[] orders = new string[3];

orders[0] = "First Order";
orders[1] = "Second Order";
orders[2] = "Third Order";


string[] _ = { "Fourth Order", "Fifth Order", "Sixth Order" };

foreach (string order in orders)
{
    Console.WriteLine(order);
}

int[] inventory = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item}");
}

Console.WriteLine(sum);


string[] orderIDs = {
    "A123",
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179",
};


foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

string str = "Hello World";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
    if (i == '0') x++;
}

string new_message = new string(charMessage);
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");