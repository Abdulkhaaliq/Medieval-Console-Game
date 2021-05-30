using Medieval_Console_Game.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Console_Game
{
    public class ApiService
    {
        HttpClient httpClient = new HttpClient();

        public void NewPlayer(PlayerModel playerModel)
        {
            
        }

        public async Task<PlayerModel> GetPlayerStats()
        {
           
            string stats = await httpClient.GetStringAsync("https://localhost:44324/api/Player");
            PlayerModel getter = JsonConvert.DeserializeObject<PlayerModel>(stats);
            PlayerModel playerModel = new PlayerModel()
            {
                PlayerName = getter.PlayerName,
                PlayerLevel = getter.PlayerLevel
            };
            return playerModel;
        }
    }
}
