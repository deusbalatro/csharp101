Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
string message = "";
string message2 = "";

/* MY SOLUTION
if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
    message = "Your subscription will expire soon. Renew now!";
else if (daysUntilExpiration <=5 && daysUntilExpiration > 1)
    message = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage+=10}%!";
else if (daysUntilExpiration <= 1 && daysUntilExpiration > 0)
    message = $"Your subscription expires within a day! \nRenew now and save {discountPercentage+=20}%!";
else if (daysUntilExpiration < 1)
    message = "Your subscription has expired.";
else
    message = "";
*/

if (daysUntilExpiration == 0)
    message = "Your subscription has expired";
else if (daysUntilExpiration == 1)
    {
    message = "Your subscription expires within a day!";
    discountPercentage = 20;
    }
else if (daysUntilExpiration <= 5)
    {
    message = $"Your subscription expires in {daysUntilExpiration} days.";
    discountPercentage = 10;
    }
else if (daysUntilExpiration <= 10)
    message = "Your susbscription will expire soon. Renew now!";

if (discountPercentage > 0)
    message2 = $"Renew now and save {discountPercentage}%!";
else if (discountPercentage > 10)
    message2 = $"Renew now and save {discountPercentage}%!";


Console.WriteLine(message);
Console.WriteLine(message2);
