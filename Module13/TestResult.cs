using System;

namespace Module13
{
    public class TestResult
    {
        public string StudentName { get; set; }
        public string TestName { get; set; }
        public DateTime TestDate { get; set; }
        public string TestScore { get; set; }

        public TestResult(string student, string test, DateTime date, string score)
        {
            StudentName = student;
            TestName = test;
            TestDate = date;
            TestScore = score;
        }
    }
}
