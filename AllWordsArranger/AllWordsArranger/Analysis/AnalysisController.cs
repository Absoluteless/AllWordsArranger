using System.Collections.Generic;
using System.Linq;
using AllWordsArranger.FileOperations;

namespace AllWordsArranger.Analysis
{
    internal class AnalysisController
    {
        private readonly List<char> _possibleChars;
        private readonly InputProvider _inputProvider;
        private readonly OutputProvider _outputProvider;

        internal AnalysisController(string charSequence, InputProvider inputProvider, OutputProvider outputProvider)
        {
            _possibleChars = charSequence.ToList();
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
            var possibleChars = _possibleChars;
            foreach (var symbol in currentWord)
            {
                if (!possibleChars.Contains(symbol))
                {
                    return false;
                }
                possibleChars.Remove(symbol);
            }
            return true;
        }
    }
}
