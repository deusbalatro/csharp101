Random random = new();
//int monsterDamage = random.Next(0, 11);
//int heroDamage = random.Next(0,11);
int heroHP = 10;
int monsterHP = 10;
do
{
    int monsterDamage = random.Next(0,11);
    int heroDamage = random.Next(0,11);
    
    monsterHP -= heroDamage;
    Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHP} health.");
    
    //if(monsterHP <= 0)
      //  Console.WriteLine("You win! You beat the monster!");
    if (monsterHP <= 0) continue; //In my version this was break.
    //Console.WriteLine("THIS IS A TEST MESSAGE");
    heroHP -= monsterDamage;
    Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHP} health.");
    //if(heroHP <= 0)
       // Console.WriteLine("Monster wins, you lose!");

} while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "You win! Monster died!" : "Monster wins. You lose.");

/*I wrote the code with break in line 16, so it was causing that I had to use Console Writes just 
before the break. Because, if I did not do this (if I did use continue), it was passing the WriteLine 
line and finishing the iteration. Also my code was using just 1 while condition as heroHP>0. Because
my code was cutting the game already with the line 16, due to break statement. Although my last 
code was working, the updating with Microsoft advices, done my code more readable and professional.*/