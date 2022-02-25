//Formas de se inicializar uma matriz 
string[] fraudulentOrderIDs = new string [4];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
fraudulentOrderIDs[0] = "FOOO";
Console.WriteLine($"Reassign First:{fraudulentOrderIDs[0]}");

//Ou:

string[] fraudulentOrderIDs = {"A123", "8456", "C789"};

Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//foreach

string [] names = {"Bob", "Conrad", "Grant"};
foreach(string name in names)
{
    Console.WriteLine(name);
}

//Exercicio de contagem de iventário

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} (Runing total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");