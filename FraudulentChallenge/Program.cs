//in case, ther order ids start with "B" considered that must be fraudulent

string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

//MY SOLUTION
int x = 1;
int order = 0;
Console.WriteLine("These orders might be fraudulent:\n-----------------------");
foreach (string id in orders)
{
    order++;
    
    if (id.StartsWith("B"))
        Console.WriteLine($"Suspicious order {x++}: {orders[order-1]}");
    
}

/*
int x = 1;
foreach (string id in orders)
{
    if(id.StartsWith("B"))
    Console.WriteLine($"Suspicious Order {x++}: {id});
    
}
*/