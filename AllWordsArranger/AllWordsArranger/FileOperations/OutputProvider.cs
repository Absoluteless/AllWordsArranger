using System;
using System.IO;

namespace AllWordsArranger.FileOperations
{
    internal class OutputProvider
    {
        private readonly string _destinationFile;

        internal OutputProvider(string destinationFile)
        {
            _destinationFile = destinationFile;
        }

        internal void StoreWord(string wordToStore)
        {
            File.AppendAllText(_destinationFile, wordToStore + Environment.NewLine);
        }
    }
}
