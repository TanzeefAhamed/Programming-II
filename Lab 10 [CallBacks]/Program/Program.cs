using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public delegate void StartCallback(string filename);
    public delegate void ProgressCallback(int percentage);
    public delegate void CompletionCallback(string filename, bool success);

    class Program
    {
        static void Main()
        {
            Console.WriteLine("File Download Simulator");
            Console.WriteLine("-----------------------");
            FileDownloader downloader = new FileDownloader();
            downloader.Download("example.txt", OnStart, OnProgress, OnComplete);
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
        static void OnStart(string filename)
        {
            Console.WriteLine($"Now downloading: {filename}");
        }

        static void OnProgress(int percent)
        {
            Console.WriteLine($"Downloaded: {percent}%");
        }

        static void OnComplete(string filename, bool success)
        {
            Console.WriteLine
                (success ? $"Finished downloading {filename} successfully!" : $"Download of {filename} failed.");
        }

    }
    public class FileDownloader
    {
        public void Download(
            string filename,
            StartCallback startCallback,
            ProgressCallback progressCallback,
            CompletionCallback completionCallback)
        {
            startCallback(filename);

            Random random = new Random();
            int progress = 0;

            while (progress < 100)
            {
                System.Threading.Thread.Sleep(1000);
                progress += random.Next(5, 10);
                if (progress > 100) progress = 100;
                progressCallback(progress);
            }

            bool success = random.Next(10) < 9;
            completionCallback(filename, success);
        }
    }
}

