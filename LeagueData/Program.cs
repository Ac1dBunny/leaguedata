using System;
using RiotSharp;
using RiotSharp.Misc;

namespace LeagueData
{
    class Program
    {
        static void Main(string[] args)
        {

            var api = RiotApi.GetDevelopmentInstance("RGAPI-7e14c5f9-35c1-43f2-9bde-e7dbb04476b4");
            try
            {
                Console.Write("Type your summoner's name: ");
                string userName = Console.ReadLine();
                var summoner = api.Summoner.GetSummonerByNameAsync(Region.Eune, userName).Result;
                var name = summoner.Name;
                var level = summoner.Level;
                var accountId = summoner.AccountId;
                var region = summoner.Region;

                Console.WriteLine("Summoner name is: " + userName);
                Console.WriteLine("Your level is: " + level);
                Console.WriteLine("Your account ID is: " + accountId);
                Console.WriteLine("Your region is: " + region);

            }
            catch (RiotSharpException)
            {
                // Handle the exception however you want.
            }
            
        }
    }
}
