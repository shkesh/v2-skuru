using System;

namespace Skuru.Core
{
    public class TextGenerator
    {
        private static string[] easyWords =
        {
             "дом", "окно", "летать", "как", "вот", "вы", "я", "так", "над", "под", "огонь", "свет", "гость", "дверь", "дело", "еда"
        };

        private static string[] hardWords =
        {
            "казаться", "присутствие", "отсутствие", "привлекательный", "восстановление", "оправдание", "восприятие", "усложнение", "успокоение", "освежать", "созерцать", "окружение", "протяжённость", "путешествие", "обогащение", "прикосновение"
        };

        public static string GenerateText(string diificultyLevel, int numberOfWords)
        {
            Random random = new Random();

            int wordChoice = 0;
            string outputString = string.Empty;

            if (diificultyLevel == "hard")
            {
                for (int i = 0; i < numberOfWords; i++)
                {
                    wordChoice = random.Next(1, 10);

                    if (wordChoice > 5)
                        if (i != numberOfWords - 1)
                        {
                            outputString += easyWords[random.Next(0, easyWords.Length)] + " ";
                        }
                        else
                        {
                            outputString += easyWords[random.Next(0, easyWords.Length)];
                        }
                    else
                    {
                        if (i != numberOfWords - 1)
                        {
                            outputString += hardWords[random.Next(0, hardWords.Length)] + " ";
                        }
                        else
                        {
                            outputString += hardWords[random.Next(0, hardWords.Length)];
                        }
                    }
                }
            }

            if (diificultyLevel == "normal")
            {
                for (int i = 0; i < numberOfWords; i++)
                {
                    wordChoice = random.Next(1, 10);

                    if (wordChoice > 2)
                    {
                        if (i != numberOfWords - 1)
                        {
                            outputString += easyWords[random.Next(0, easyWords.Length)] + " ";
                        }
                        else
                        {
                            outputString += easyWords[random.Next(0, easyWords.Length)];
                        }
                    }
                        
                    else
                    {
                        if (i != numberOfWords - 1)
                        {
                            outputString += hardWords[random.Next(0, hardWords.Length)] + " ";
                        }
                        else
                        {
                            outputString += hardWords[random.Next(0, hardWords.Length)];
                        }
                    }
                }
            }
            return outputString;
        }
    }
}
