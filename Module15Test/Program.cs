using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Module15;

namespace Module15Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test comparing function? Press Y to test.");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Comparing files test.");
                string path1, path2, path3;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter path of test file.");
                        path1 = Console.ReadLine();
                        Console.WriteLine("Enter path of copy of test file.");
                        path2 = Console.ReadLine();
                        Console.WriteLine("Enter path of file not identical to test file.");
                        path3 = Console.ReadLine();
                        Console.WriteLine(FileCoping.CompareFiles(path1, path2)
                            ? "Equal files are equal."
                            : "Equal files are not equal.");
                        Console.WriteLine(FileCoping.CompareFiles(path1, path3)
                            ? "Not equal files are equal."
                            : "Not equal files are not equal.");
                        break;
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("Check paths of files and try again. Press any key to continue.");
                        Console.ReadKey();
                    }
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Coping files test.");
                    Console.WriteLine("Enter path of test file.");
                    var testFile = Console.ReadLine();

                    Console.WriteLine("Coping files test 1. Coping by byte from file to file using FileStream.");
                    var newFile1 = testFile.Insert(testFile.LastIndexOf('.'), "Copy1");
                    Console.WriteLine(FileCoping.CopyToFile_FS_ByByte(testFile, newFile1) + " bytes copied.");
                    Console.WriteLine(FileCoping.CompareFiles(testFile, newFile1)
                        ? "Files are equal."
                        : "Files are not equal.");

                    Console.WriteLine("Coping files test 2. Coping by byte from file to file using MemoryStream.");
                    var newFile2 = testFile.Insert(testFile.LastIndexOf('.'), "Copy2");
                    Console.WriteLine(FileCoping.CopyToFile_MS_ByByte(testFile, newFile2) + " bytes copied.");
                    Console.WriteLine(FileCoping.CompareFiles(testFile, newFile2)
                        ? "Files are equal."
                        : "Files are not equal.");

                    Console.WriteLine("Coping files test 3. Coping from file to file using FileStream with buffer.");
                    var newFile3 = testFile.Insert(testFile.LastIndexOf('.'), "Copy3");
                    Console.WriteLine(FileCoping.CopyToFile_FS_Buffer(testFile, newFile3) + " bytes copied.");
                    Console.WriteLine(FileCoping.CompareFiles(testFile, newFile3)
                        ? "Files are equal."
                        : "Files are not equal.");

                    Console.WriteLine("Coping files test 4. Coping from file to file using BufferedStream.");
                    var newFile4 = testFile.Insert(testFile.LastIndexOf('.'), "Copy4");
                    Console.WriteLine(FileCoping.CopyToFile_BS(testFile, newFile4) + " bytes copied.");
                    Console.WriteLine(FileCoping.CompareFiles(testFile, newFile4)
                        ? "Files are equal."
                        : "Files are not equal.");

                    Console.WriteLine("Coping files test 5. Coping from file to file using MemoryStream.");
                    var newFile5 = testFile.Insert(testFile.LastIndexOf('.'), "Copy5");
                    Console.WriteLine(FileCoping.CopyToFile_MS(testFile, newFile5) + " bytes copied.");
                    Console.WriteLine(FileCoping.CompareFiles(testFile, newFile5)
                        ? "Files are equal."
                        : "Files are not equal.");

                    Console.WriteLine("Coping files test 6. Coping by lines from file to file.");
                    var newFile6 = testFile.Insert(testFile.LastIndexOf('.'), "Copy6");
                    Console.WriteLine(FileCoping.CopyToFile_ByLine(testFile, newFile6) + " lines copied.");
                    Console.WriteLine(FileCoping.CompareFiles(testFile, newFile6)
                        ? "Files are equal."
                        : "Files are not equal.");

                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    break;
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Check paths of files and try again. Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
    }
}
