namespace HuntingTheManticore
{
    public class Battle
    {
        private int _round = 1;
        private int _city = 15;
        private int _manticore = 10;
        public void BattleDashboard(int manticoreLoc, int min, int max)
        {
            bool _replay = true;
            int _min = min;
            int _max = max;

            while (_replay)
            {
                if (_city == 0 || _manticore <= 0)
                {
                    ConsoleIO.WinOrLose(_city, _manticore);
                    break;
                }
                int _manticoreLoc = manticoreLoc; 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"STATUS:  Round:  {_round}  City:  {_city}  Manticore:  {_manticore}");
                Console.WriteLine($"The cannon is expected to deal {Damage()} damage this round.");
                int _cannonLoc = ConsoleIO.CannonLocation("Enter desired cannon range: ", _min, _max);
                bool _roundDamage = ConsoleIO.RoundStatus(_manticoreLoc, _cannonLoc);
                if (_roundDamage)
                {
                    _manticore -= Damage();
                }
                _round++;
                _city--;
            }
        }
        private int Damage()
        {
            if (_round % 5 == 0 && _round % 3 == 0 && _round != 1)
            {
                return 10;
            }
            else if (_round % 5 == 0 || _round % 3 == 0)
            {
                return 3;
            }
            else
                return 1;
        }
    }
}
