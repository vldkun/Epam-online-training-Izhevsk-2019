using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students test viewer.");

            var filePath = ReadPath();


            var testsTable = ReadTestsData(filePath);
            IEnumerable<TestResult> query = testsTable.Select(t => t.Value);

            Console.WriteLine(
                "Choose sorting order.\nPress button 1 to select ascending order, 2 - by descending order.");
            bool isAscending = true;
            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nSorting in ascending order.");
                    break;
                }

                if (key.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\nSorting in descending order.");
                    isAscending = false;
                    break;
                }

                Console.WriteLine("Incorrect button, try again.");
            }


            Console.WriteLine(
                "Choose column to sort by.\nPress button 1 to sort by student name, 2 - by test name,\n 3 - by time of test, 4 - by score.");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nSorting by student name.");
                    query = isAscending
                        ? query.OrderBy(t => t.StudentName)
                        : query.OrderByDescending(t => t.StudentName);
                    break;
                }

                if (key.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("\nSorting by test name.");
                    query = isAscending ? query.OrderBy(t => t.TestName) : query.OrderByDescending(t => t.TestName);
                    break;
                }

                if (key.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("\nSorting by time of test.");
                    query = isAscending ? query.OrderBy(t => t.TestDate) : query.OrderByDescending(t => t.TestDate);
                    break;
                }

                if (key.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("\nSorting by by score.");
                    query = isAscending ? query.OrderBy(t => t.TestScore) : query.OrderByDescending(t => t.TestScore);
                    break;
                }

                Console.WriteLine("Incorrect column, try again.");
            }

            Console.WriteLine(
                "Enter the number of table lines to display.");
            while (true)
            {
                var num = Console.ReadLine();
                var flag = true;
                foreach (var ch in num)
                {
                    if (!Char.IsDigit(ch))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("\nSorting in descending order.");
                    query = query.Take(Convert.ToInt32(num));
                    break;
                }

                Console.WriteLine("Incorrect number, try again.");
            }

            Console.WriteLine("{0,20} | {1,15} | {2,10} | {3,1}", "Student name", "Test name", "Test date",
                "Test score");
            foreach (var line in query)
            {
                Console.WriteLine("{0,20} | {1,15} | {2,10} | {3,1}", line.StudentName, line.TestName,
                    line.TestDate.ToShortDateString(), line.TestScore);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static string ReadPath()
        {
            string filePath;
            Console.WriteLine("\nEnter path of tests data file.");
            while (true)
            {
                filePath = Console.ReadLine();
                if (File.Exists(filePath))
                {
                    break;
                }

                Console.WriteLine("File not found. Check the file name and try again.");
            }

            return filePath;
        }

        private static SortedDictionary<int, TestResult> ReadTestsData(string path)
        {
            var testsTable = new SortedDictionary<int, TestResult>();
            using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
            {
                int id = 0;
                while (reader.PeekChar() > -1)
                {
                    var testResult = new TestResult(reader.ReadString(), reader.ReadString(),
                        DateTime.Parse(reader.ReadString()), reader.ReadString());
                    testsTable.Add(id, testResult);
                    id++;
                }
            }

            return testsTable;
        }
    }
}
