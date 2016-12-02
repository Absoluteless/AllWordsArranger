﻿using System;
using AllWordsArranger.Analysis;
using AllWordsArranger.FileOperations;

namespace AllWordsArranger
{
    internal class Program
    {
        private static void Main(string[] cmdArgs) // "не прислоняться" "D:\lop2v2.txt" "D:\out.txt"
        {
            if (cmdArgs.Length != 4)
            {
                Console.WriteLine("Possible usage: \"не прислоняться\" \"D:\\lop2v2.txt\" \"D:\\out.txt\"");
                Console.ReadKey();
                return;
            }

            var startTime = DateTime.Now;

            var inputProvider = new InputProvider(cmdArgs[2]);
            var outputProvider = new OutputProvider(cmdArgs[3]);
            var analysisController = new AnalysisController(cmdArgs[1], inputProvider, outputProvider);
            analysisController.PerformAnalyze();

            var endTime = DateTime.Now;

            Console.WriteLine($"The Job is done! Words selected: {outputProvider.Stored}/{inputProvider.Cap}, time taken: {endTime - startTime}");
        }
    }
}
