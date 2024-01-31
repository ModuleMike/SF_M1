using HuntingTheManticore;

int min = 1;
int max = 100;
int manticoreLoc;
bool gameEnd = true;

while (gameEnd)
{
    Console.Clear();
    Console.WriteLine("Welcome to the battle of the Manticore!");
    manticoreLoc = ConsoleIO.SetManticoreLocation(min, max);
    Console.Clear();
    Battle match = new Battle();
    Console.WriteLine("Player 2, it is your turn.");
    match.BattleDashboard(manticoreLoc, min, max);
    gameEnd = ConsoleIO.Replay();
}