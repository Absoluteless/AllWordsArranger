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
    }
}
