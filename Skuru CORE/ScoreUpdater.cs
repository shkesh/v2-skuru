namespace Skuru.Core
{
    public class ScoreUpdater
    {
        public string UpdateScore(int currentIndex, int numberOfSymbols)
        {
            return $"{currentIndex} / {numberOfSymbols}";
        }
    }
}
