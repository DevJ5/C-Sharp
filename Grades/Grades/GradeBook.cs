using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        // Variable is called a "field"
        // Make the field explicitly private for readability
        private List<float> grades;

        // Type 'ctor' and press tab twice for a constructor function
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>(); // We use a list because we dont know how many items we will store. 
        }

        // Method is called a "member"
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;

            foreach (float grade in grades)
            {
                // Hover over Math class and press f12
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            if (grades.Count != 0) stats.AverageGrade = sum / grades.Count;

            return stats;
        }

       // Public class members start with uppercase and private members start with lowercase
       // This is a property instead of a field. (A property has getters and setters).
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NameChanged(_name, value);
                    }
                    _name = value;
                }
            }
        }

        public NameChangedDelegate NameChanged;
        private string _name;
    }
}
