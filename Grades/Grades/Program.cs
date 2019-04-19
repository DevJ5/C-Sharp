using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Right click references -> add reference.
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello this is the grade book program.");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            // C# converts decimals to double precision floating points,
            // for single point floating numbers with need to put an 'f' at the end.
            book.AddGrade(89.5f);
            book.AddGrade(10);
            book.AddGrade(15);

            GradeStatistics stats = book.ComputeStatistics();
            // Type cw and press tab twice for WriteLine
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);
            // Right click a line, and run to cursor opens debugger on that line.
           
        }
    }
}
