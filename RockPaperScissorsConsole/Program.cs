string x = "";
int rsp = 0;
Random random = new();
Console.WriteLine("Lütfen oyunu sürdürmek istediğinizde enter'a, bitirmek istediğinizde q tuşuna basın");
string message = "";
/*while(x != "q")
{
    
    Console.WriteLine($"{(ht == 0 ? "Heads" : "Tails")}");
    //x = Console.ReadLine();
}*/

do
{
    rsp = random.Next(0,3);
    switch (rsp)
    {
        case 0:
            message = "Rock";
            break;
        case 1:
            message = "Scissors";
            break;
        case 2:
            message = "Paper";
            break;
    }
    if (message == "Rock") continue;
    Console.WriteLine(message);
    x = Console.ReadLine();
    
} while (x != "q");