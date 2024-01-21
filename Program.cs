// Zahid Afsar
// 9/12/23
// Mini Challenge 5
// Creating a unique madlib generator with 10 fields to enter and a play again option
// Peer reviewed by : Max Mendoza    Peer Comment: The story was made creatively and the code runs perfectly, the answers i put in made sense with the story and it loops back to the start like its supposed to, 10/10

Console.Clear();
bool playAgain = true;
while(playAgain == true){

Console.WriteLine("You will be filling in the blanks in this madlib to create your own story");
Console.WriteLine();
Console.WriteLine("Once upon a time in the _ ocean, there lived a young diver named _. \n Who stumbled upon a mysterious _ and decided to explore it. Inside they discovered a magical portal that led to _. \n When they entered they saw a land inhabited by _ and _. During the first day they become a hero by _. \n Life was great because the old world was filled with _ and this new one had _. \n Until the _ attacked and they had to fight it with a _. The hero won and lived happily ever after.");

Console.WriteLine();
Console.WriteLine("What is the name of the ocean?");
string userWater = Console.ReadLine();

Console.WriteLine("Please enter the name of the diver");
string userName = Console.ReadLine();

Console.WriteLine("What type of under water ruin protaganist stumble across?");
string userHouse = Console.ReadLine();

Console.WriteLine("Please enter the name of new world");
string userWorld = Console.ReadLine();

Console.WriteLine("What is the new land inhabited by?");
string userInhabited = Console.ReadLine();

Console.WriteLine("What is the other thing the new land inhabited by?");
string userInhabitedTwo = Console.ReadLine();

Console.WriteLine("How did the protagonist become a hero in the new world?");
string userHero = Console.ReadLine();

Console.WriteLine("What was filled with in your old world that mad you hate it?");
string userBad = Console.ReadLine();

Console.WriteLine("What does this new world have that makes you like it?");
string userNew = Console.ReadLine();

Console.WriteLine("What is the Monster that attacked you?");
string userEnemy = Console.ReadLine();

Console.WriteLine("What weapon did you use to fight the monster");
string userWeapon = Console.ReadLine();

Console.WriteLine($"Once upon a time in the {userWater} ocean, there lived a young diver named {userName}. Who stumbled upon a mysterious {userHouse} and decided to explore it. Inside they discovered a magical portal that led to {userWorld}. When they entered they saw a land inhabited by {userInhabited} and {userInhabitedTwo}. During the first day they become a hero by {userHero}. Life was great because the old world was filled with {userBad} and this new one had {userNew}. Until the {userEnemy} attacked and they had to fight it with a {userWeapon}. The hero won and lived happily ever after");

Console.WriteLine("The End");


    Console.WriteLine("Would you like to play again");
    string playerAnswer = Console.ReadLine();
    playerAnswer = playerAnswer.ToLower();
    
    if(playerAnswer == "no"){
        playAgain = false;
        Console.WriteLine("You have finished the game");
    }else{
        Console.WriteLine("Lets play again!");
    }
}