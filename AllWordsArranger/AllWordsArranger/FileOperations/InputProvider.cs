using System.IO;
using System.Text;

namespace AllWordsArranger.FileOperations
{
    internal class InputProvider
    {
        private readonly string[] _allLines;
        public int Cap { get; }
        private int _currentWord;
    
        internal InputProvider(string pathToDictionary)
        {
            _allLines = File.ReadAllLines(pathToDictionary, Encoding.Default);
            Cap = _allLines.Length;
        }

        internal bool GetNextWord(out string wordForAnalysis)
        {
            if (_currentWord < Cap)
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
