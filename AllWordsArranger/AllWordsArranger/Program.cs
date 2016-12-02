using System;
using AllWordsArranger.Analysis;
using AllWordsArranger.FileOperations;

namespace AllWordsArranger
{
    internal class Program
    {
        private static void Main(string[] cmdArgs) // "не прислоняться" "D:\lop2v2.txt" "D:\out.txt"
        {
            if (cmdArgs.Length != 3)
            {
                Console.WriteLine("Possible usage: \"не прислоняться\" \"D:\\lop2v2.txt\" \"D:\\out.txt\"");
                Console.ReadKey();
                return;
            }

            var startTime = DateTime.Now;

            var inputProvider = new InputProvider(cmdArgs[1].Replace("\"", string.Empty));
            var outputProvider = new OutputProvider(cmdArgs[2].Replace("\"", string.Empty));
            var analysisController = new AnalysisController(cmdArgs[0].Replace("\"", string.Empty), inputProvider, outputProvider);
            analysisController.PerformAnalyze();

            var endTime = DateTime.Now;

            Console.WriteLine($"The Job is done! Words selected: {outputProvider.Stored}/{inputProvider.Cap}, time taken: {endTime - startTime}");
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
