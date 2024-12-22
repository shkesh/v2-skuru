namespace Skuru.Core
{
    public class ScoreUpdater
    {
        public static string UpdateScore(int currentIndex, int numberOfSymbols)
        {
            return $"{currentIndex} / {numberOfSymbols}";
        }
    }
}
