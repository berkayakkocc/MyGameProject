using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new GamerAdult();
            person.Id = 111111;
            person.Tc = "12345678925";
            person.Name = "Berkaycan ";
            person.Surname = "Akkoç";
            person.BirthOfYear = new DateTime(1997);

            IUsersService usersService = new PersonManager(new CheckPersonManager());
            usersService.Add(person);

            Campaign campaign = new Campaign();
            campaign.CampaignType = " Özel Müşteri ";

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign);

            Gamers game = new Gamers();
            game.GameName = "";
            game.GamePrice = 50;
            game.Id = 2;

            IGamers gamers = new GamersManager();
            gamers.Sell(person, campaign, game);


        }




    }
}