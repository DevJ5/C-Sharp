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

            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Scott's Gradebook";
            book.Name = null;
            book.AddGrade(91);
            // C# converts decimals to double precision floating points,
            // for single point floating numbers with need to put an 'f' at the end.
            book.AddGrade(89.5f);
            book.AddGrade(10);
            book.AddGrade(15);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            // Type cw and press tab twice for WriteLine
            WriteResult("Highest grade", stats.HighestGrade);
            WriteResult("Lowest grade", (int)stats.LowestGrade);
            WriteResult("Average grade", stats.AverageGrade);
            // Right click a line, and run to cursor opens debugger on that line.
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }

        // Static methods can only call other static methods.
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        // This method has a different signature because of a different parameter. (Method overloading)
        static void WriteResult(string description, float result)
        {
            // Formatting string instead of string concatenation (F2 = float with 2 decimals)
            Console.WriteLine("{0}: {1:F2}", description, result);

            // String interpolation
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
