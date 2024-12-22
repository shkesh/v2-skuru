namespace Skuru.Core
{
    public class TextGenerator
    {
        private readonly TextGeneratorFactory _factory;

        public TextGenerator()
        {
            _factory = new TextGeneratorFactory();
            
            _factory.Register("easy", new EasyTextGenerator());
            _factory.Register("normal", new NormalTextGenerator());
            _factory.Register("hard", new HardTextGenerator());
        }

        public string Generate(string difficultyLevel, int numberOfWords)
        {
            var generator = _factory.GetTextGenerator(difficultyLevel);
            return generator.Generate(numberOfWords);
        }
    }
}