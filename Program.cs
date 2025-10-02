using System;
string rocket = @"
   /\
  /  \
  |  |
  |[]|
  |__|
   /\
  /  \
   ||
   ||";



for (int i = 0; i < 10; i++)
{
    Console.Clear();
    for(int j = 0; j < i; j++)
    {
        Console.WriteLine();
    }
    Console.WriteLine(rocket);
    Thread.Sleep(2000);
    if (i==9)
    {
        Console.WriteLine("**********************************");
    }

    
    
}
Console.WriteLine("The rocket has landed.Woohoo!Another successful landing!");