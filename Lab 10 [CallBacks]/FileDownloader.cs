using System;

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
            progress += random.Next(5, 15);
            if (progress > 100) progress = 100;
            progressCallback(progress);
        }

        bool success = random.Next(10) < 9;
        completionCallback(filename, success);
    }
}