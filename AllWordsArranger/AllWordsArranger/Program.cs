﻿using System;
using System.CodeDom;
using WordsAnalyzer.Analysis;

namespace WordsAnalyzer
{
    internal class Program
    {
        private static void Main(string[] cmdArgs) // "не прислоняться" "D:\lop2v2.txt" "D:\out.txt"
        {
            if (cmdArgs.Length != 4)
            {
                Console.WriteLine("Possible usage: \"не прислоняться\" \"D:\\lop2v2.txt\" \"D:\\out.txt\"");
            }

            var inputProvider = new InputProvider(cmdArgs[2]);
            var outputProvider = new OutputProvider(cmdArgs[3]);
            var analysisController = new AnalysisController(cmdArgs[1], inputProvider, outputProvider);
            AnalysisController.PerformAnalyze();
        }
    }
}