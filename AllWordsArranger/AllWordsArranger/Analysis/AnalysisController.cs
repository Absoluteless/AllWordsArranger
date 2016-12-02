using AllWordsArranger.FileOperations;

namespace AllWordsArranger.Analysis
{
    internal class AnalysisController
    {
        private readonly string _charSequence;
        private readonly InputProvider _inputProvider;
        private readonly OutputProvider _outputProvider;

        internal AnalysisController(string charSequence, InputProvider inputProvider, OutputProvider outputProvider)
        {
            _charSequence = charSequence;
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
        }

        public void PerformAnalyze()
        {
            string currentWord;
            while (_inputProvider.GetNextWord(out currentWord))
            {
                if (Analyse(currentWord))
                {
                    _outputProvider.StoreWord(currentWord);
                }
            }
        }

        private bool Analyse(string currentWord)
        {
            return true;
        }
    }
}
