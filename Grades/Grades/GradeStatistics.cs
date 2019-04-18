﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            AverageGrade = 0;
            HighestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
        }
    }
}
