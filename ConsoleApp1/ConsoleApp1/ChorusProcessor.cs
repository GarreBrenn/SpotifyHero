using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChorusProcessor
    {
        public static async Task<ChorusSongModel[]> LoadChartData(string songName, string songArtist) 
        {
            string url = $"https://chorus.fightthe.pw/api/search?query=name=\"{ songName }\" artist=\"{ songArtist }\"";
        
            using (HttpResponseMessage response = await ApiHelper.apiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ChorusModel result = await response.Content.ReadAsAsync<ChorusModel>();
                    return result.songs;
                } else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
