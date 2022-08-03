namespace TowerBreakers
{
    class Result
    { 
        public static int TowerBreakers(int n, int m)
        {
            bool evenTowers = n % 2 == 0;
            bool gotMoves = m > 1;

            if (!gotMoves) 
                return 2; 

            if (evenTowers) 
                return 2; 

            return 1;
        }

    }
}