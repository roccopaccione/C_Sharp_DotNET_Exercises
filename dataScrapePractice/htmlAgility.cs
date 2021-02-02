using System;

namespace dataScrapePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load("https://www.indeed.com/jobs?q=Software+Developer&l=San+Antonio%2C+TX&ts=1611781524876&rq=1&rsIdx=0&fromage=last&newcount=31");
            foreach (var job in document.DocumentNode.SelectNodes("//a[@class='jobtitle turnstileLink ']"))
            {
                Console.WriteLine(job.InnerText);
            }

        }
    }
}
