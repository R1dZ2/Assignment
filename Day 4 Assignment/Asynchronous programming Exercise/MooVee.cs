using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_programming_Exercise
{
    internal class MooVee
    {
        static string MovieDownload()
        {
            Console.WriteLine("Download started...");
            Thread.Sleep(5000);
            Console.WriteLine("Download finished...");
            return "1024 MB downloaded";
        }

        static async Task<string> MovieDownloadAsync()
        {
            return await Task<string>.Run(() => MovieDownload());
        }

        static void ReadReview()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Review: This is a movie review!");
            Console.WriteLine("-------------------------------");
        }

        public static void Main()
        {
            Task<string> movieDownload = MovieDownloadAsync();
            //Console.WriteLine(MovieDownload());
            Console.WriteLine("Your download is in progress. Do you want to read the review?{Y/N)");
            if (Console.ReadKey(true).KeyChar == 'y' || Console.ReadKey(true).KeyChar == 'Y')
            {
                ReadReview();
            }
            if (movieDownload.Status != TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Please wait for your download to finish!");
            }
            Console.WriteLine(movieDownload.Result);
            Console.WriteLine("Goodbye.");
        }


    }
}
