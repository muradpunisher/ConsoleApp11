using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class Student
    {
        public string FullName;
        public string Group;
        public List<Exam> Exams;

        public override string ToString()
        
        {
            return FullName + " - " + Group;
        }

        public List<Exam> GetExamsByPointRange(byte minPoint,byte maxPoint)
        {
            List<Exam> wantedExams = new List<Exam>();
            foreach (var item in Exams)
            {
                if(item.Point>=minPoint && item.Point<=maxPoint)
                    wantedExams.Add(item);
                
            }
            return wantedExams;
        }

        public List<Exam> GetExamsByPointRange(DateTime fromDate,DateTime toDate)
        {
            List<Exam> wantedExams = new List<Exam>();
            foreach (var item in Exams)
            {
                if (item.StartAt >= fromDate && item.StartAt <= toDate)
                    wantedExams.Add(item);

            }
            return wantedExams;
        }

        

        public double GetAvgPoint()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Point;
            }
            return sum/Exams.Count;
        }
    }
}
