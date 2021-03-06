﻿using System;
using System.IO;
using System.Text;

namespace AllWordsArranger.FileOperations
{
    internal class OutputProvider
    {
        private readonly string _destinationFile;

        internal int Stored { get; private set; }

        internal OutputProvider(string destinationFile)
        {
            _destinationFile = destinationFile;
        }

        internal void StoreWord(string wordToStore)
        {
            File.AppendAllText(_destinationFile, wordToStore + Environment.NewLine, Encoding.Default);
            Stored++;
        }
    }
}
