using System;

namespace Skuru.Core
{
    public class Statistics
    {
        public static string OutputStatistics(long resultTime, int numberOfSymbols, int numberOfWords, int numberOfMisprints)
        {
            string statisticsString = $"Время:    {resultTime / 1000},{resultTime % 100} сек.\nСкорость: {Math.Round(numberOfWords / Convert.ToDouble(resultTime) * 60000)} WPM\nОшибки:   {numberOfMisprints} / {numberOfSymbols} ({Math.Round((Convert.ToDouble(numberOfMisprints) / Convert.ToDouble(numberOfSymbols)) * 100, 2)}%)";
            return statisticsString;
        }
    }
}
