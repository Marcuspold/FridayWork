using System;
using System.IO;

namespace WeekWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morning Soldier!");
            //MoveApplesFile();
            //MovePotatoFile();
            //MoveApplesFile();
            //MovePineappleFile();
            MoveOnionFile();
            MoveCucumberFile();
            MoveBananasFile();

            DeleteFile();
        }

        public static void MoveApplesFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string FileName = "apples.txt";
            string DestinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
        public static void MovePotatoFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string FileName = "potatos.txt";
            string DestinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
        public static void MovePineappleFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string FileName = "Pineapples.txt";
            string DestinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
        public static void MoveOnionFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string FileName = "Onions.txt";
            string DestinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
        public static void MoveCucumberFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string FileName = "Cucumbers.txt";
            string DestinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
        public static void MoveBananasFile()
        {
            string SourceDirectory = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string FileName = "bananas.txt";
            string DestinationPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";


            File.Move(Path.Combine(SourceDirectory, FileName), Path.Combine(DestinationPath, FileName));
        }
        public static void DeleteFile()
        {
            string RootPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string FileName = "cheese.txt";
            if (File.Exists(Path.Combine(RootPath, FileName)))
            {
                File.Delete(Path.Combine(RootPath, FileName));
            }
            else
            {
                Console.WriteLine("File Not Found Error 404");
            }
        }
        public static void DeleteFile2()
        {
            string RootPath = @"C:\Users\opilane\Samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string FileName = "toiletpaper.txt";
            if (File.Exists(Path.Combine(RootPath, FileName)))
            {
                File.Delete(Path.Combine(RootPath, FileName));
            }
            else
            {
                Console.WriteLine("File Not Found Error 404");
            }
        }
    }
}
