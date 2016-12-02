using System.IO;

namespace AllWordsArranger.FileOperations
{
    internal class InputProvider
    {
        private readonly string[] _allLines;
        private readonly int _cap;
        private int _currentWord;
    
        internal InputProvider(string pathToDictionary)
        {
            _allLines = File.ReadAllLines(pathToDictionary);
            _cap = _allLines.Length;
        }

        internal bool GetNextWord(out string wordForAnalysis)
        {
            if (_currentWord < _cap)
            {
                wordForAnalysis = _allLines[_currentWord];
                _currentWord++;
                return true;
            }

            wordForAnalysis = string.Empty;
            return false;
        }
    }
}
