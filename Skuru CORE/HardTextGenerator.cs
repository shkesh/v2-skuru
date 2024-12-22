using System;

namespace Skuru.Core
{
    public class HardTextGenerator : ITextGenerator
    {
        private readonly string[] _easyWords =
        {
            "дом", "окно", "летать", "как", "вот", "вы", "я", "так", "над", "под", "огонь", "свет", "гость", "дверь",
            "дело", "еда"
        };

        private readonly string[] _hardWords =
        {
            "казаться", "присутствие", "отсутствие", "привлекательный", "восстановление", "оправдание", "восприятие",
            "усложнение", "успокоение", "освежать", "созерцать", "окружение", "протяжённость", "путешествие",
            "обогащение", "прикосновение"
        };

        public string Generate(int numberOfWords)
        {
            var random = new Random();

            var wordChoice = 0;
            var outputString = string.Empty;

            for (var i = 0; i < numberOfWords; i++)
            {
                wordChoice = random.Next(1, 10);

                if (wordChoice > 5)
                {
                    if (i != numberOfWords - 1)
                        outputString += _easyWords[random.Next(0, _easyWords.Length)] + " ";
                    else
                        outputString += _easyWords[random.Next(0, _easyWords.Length)];
                }
                else
                {
                    if (i != numberOfWords - 1)
                        outputString += _hardWords[random.Next(0, _hardWords.Length)] + " ";
                    else
                        outputString += _hardWords[random.Next(0, _hardWords.Length)];
                }
            }

            return outputString;
        }
    }
}