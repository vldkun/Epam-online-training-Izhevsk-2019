using System;
using System.IO;
using System.Text;

namespace Module15
{
    public static class FileCoping
    {
        private const int BuffSize = 1024;

        /// <summary>
        /// Coping by byte from file to file using FileStream.
        /// </summary>
        /// <param name="fileName">Coping from.</param>
        /// <param name="newFileName">Coping to.</param>
        /// <returns>Returns number of copied bytes.</returns>
        public static int CopyToFile_FS_ByByte(string fileName, string newFileName)
        {
            try
            {
                var bytes = 0;

                using (FileStream sin = new FileStream(fileName, FileMode.Open),
                    sout = new FileStream(newFileName, FileMode.Create))
                {
                    int readByte;
                    while ((readByte = sin.ReadByte()) >= 0)
                    {
                        sout.WriteByte((byte) readByte);
                        bytes++;
                    }
                }

                return bytes;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
        }

        /// <summary>
        /// Coping by byte from file to file using MemoryStream.
        /// </summary>
        /// <param name="fileName">Coping from.</param>
        /// <param name="newFileName">Coping to.</param>
        /// <returns>Returns number of copied bytes.</returns>
        public static int CopyToFile_MS_ByByte(string fileName, string newFileName)
        {
            MemoryStream ms = null;
            StreamReader sin = null;
            try
            {
                var bytes = 0;

                sin = new StreamReader(fileName);
                ms = new MemoryStream(Encoding.ASCII.GetBytes(sin.ReadToEnd()));

                using (var sout = new FileStream(newFileName, FileMode.Create))
                {
                    int readByte;
                    while ((readByte = ms.ReadByte()) >= 0)
                    {
                        sout.WriteByte((byte) readByte);
                        bytes++;
                    }
                }

                ms.Close();
                return bytes;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
            finally
            {
                ms?.Close();
                sin?.Close();
            }
        }

        /// <summary>
        /// Coping from file to file using FileStream with buffer.
        /// </summary>
        /// <param name="fileName">Coping from.</param>
        /// <param name="newFileName">Coping to.</param>
        /// <returns>Returns number of copied bytes.</returns>
        public static int CopyToFile_FS_Buffer(string fileName, string newFileName)
        {
            try
            {
                var bytes = 0;

                using (FileStream sin = new FileStream(fileName, FileMode.Open),
                    sout = new FileStream(newFileName, FileMode.Create))
                {
                    var buffer = new byte[BuffSize];
                    var byteCount = 0;
                    while ((byteCount = sin.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        bytes += byteCount;
                        sout.Write(buffer, 0, byteCount);
                    }
                }

                return bytes;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
        }

        /// <summary>
        /// Coping from file to file using BufferedStream.
        /// </summary>
        /// <param name="fileName">Coping from.</param>
        /// <param name="newFileName">Coping to.</param>
        /// <returns>Returns number of copied bytes.</returns>
        public static int CopyToFile_BS(string fileName, string newFileName)
        {
            try
            {
                var bytes = 0;
                using (var bufStreamIn = new BufferedStream(File.Open(fileName, FileMode.Open), BuffSize))
                {
                    using (var bufStreamOut = new BufferedStream(File.Open(newFileName, FileMode.Create), BuffSize))
                    {
                        var buffer = new byte[BuffSize];
                        int byteCount;
                        while ((byteCount = bufStreamIn.Read(buffer, 0, BuffSize)) > 0)
                        {
                            bufStreamOut.Write(buffer, 0, byteCount);
                            bytes += byteCount;
                        }
                    }
                }

                return bytes;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
        }

        /// <summary>
        /// Coping from file to file using MemoryStream.
        /// </summary>
        /// <param name="fileName">Coping from.</param>
        /// <param name="newFileName">Coping to.</param>
        /// <returns>Returns number of copied bytes.</returns>
        public static int CopyToFile_MS(string fileName, string newFileName)
        {
            try
            {
                var bytes = 0;

                var sin = new StreamReader(fileName);
                var str = sin.ReadToEnd();
                sin.Close();
                var byteArray = Encoding.ASCII.GetBytes(str);
                var ms = new MemoryStream(byteArray);

                using (var sout = new FileStream(newFileName, FileMode.Create))
                {
                    var buffer = new byte[BuffSize];
                    int readByte;
                    while ((readByte = ms.Read(buffer, 0, BuffSize)) > 0)
                    {
                        sout.Write(buffer, 0, readByte);
                        bytes += readByte;
                    }
                }

                ms.Close();
                return bytes;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
        }

        /// <summary>
        /// Coping by lines from file to file.
        /// </summary>
        /// <param name="fileName">Coping from.</param>
        /// <param name="newFileName">Coping to.</param>
        /// <returns>Returns number of copied bytes.</returns>
        public static int CopyToFile_ByLine(string fileName, string newFileName)
        {
            StreamWriter sout = null;
            try
            {
                var lines = 0;
                using (var sin = new StreamReader(fileName))
                {
                    sout = new StreamWriter(newFileName);
                    string str;
                    while ((str = sin.ReadLine()) != null)
                    {
                        sout.WriteLine(str);
                        lines++;
                    }
                }

                return lines;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
            finally
            {
                sout?.Dispose();
            }
        }

        /// <summary>
        /// Comparing files.
        /// </summary>
        /// <param name="fileName1">First file</param>
        /// <param name="fileName2">Second file.</param>
        /// <returns>Returns true if files are equal or false if not.</returns>
        public static bool CompareFiles(string fileName1, string fileName2)
        {
            try
            {
                using (FileStream sin1 = new FileStream(fileName1, FileMode.Open),
                    sin2 = new FileStream(fileName2, FileMode.Open))
                {
                    int readByte1, readByte2;
                    while ((readByte1 = sin1.ReadByte()) >= 0 && (readByte2 = sin2.ReadByte()) >= 0)
                    {
                        if (readByte1 != readByte2)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found.");
                throw;
            }
        }
    }
}
