using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            ApiHelper.InitializeClient();

            async void loadChartsInfo()
            {
                var chartsInfo = await ChorusProcessor.LoadChartData("Enigma Machine", "Dream Theater");
                foreach (ChorusSongModel model in chartsInfo)
                {
                    Console.WriteLine($"id: {model.id} name: {model.name} artist: {model.artist} album: {model.album}");
                }
            }

            loadChartsInfo();
        }

    }
}