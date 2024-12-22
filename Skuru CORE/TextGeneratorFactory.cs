using System.Collections.Generic;

namespace Skuru.Core
{
    public class TextGeneratorFactory
    {
        private readonly Dictionary<string, ITextGenerator> _textGenerators;

        public TextGeneratorFactory()
        {
            _textGenerators = new Dictionary<string, ITextGenerator>();
        }

        public void Register(string difficultyLevel, ITextGenerator textGenerator)
        {
            _textGenerators.Add(difficultyLevel, textGenerator);
        }

        public ITextGenerator GetTextGenerator(string difficultyLevel)
        {
            return _textGenerators[difficultyLevel];
        }
    }
}