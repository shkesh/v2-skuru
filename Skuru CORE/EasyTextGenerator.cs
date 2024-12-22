using System;

namespace Skuru.Core
{
    public class EasyTextGenerator : ITextGenerator
    {
        private string[] _easyWords =
        {
            "дом", "окно", "летать", "как", "вот", "вы", "я", "так", "над", "под", "огонь", "свет", "гость", "дверь",
            "дело", "еда"
        };


        public string Generate(int numberOfWords)
        {
            throw new NotImplementedException();
        }
    }
}