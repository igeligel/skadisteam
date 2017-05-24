using System;
using skadisteam.console.Settings;
using skadisteam.login;
using skadisteam.login.Models;
using skadisteam.trade;
using skadisteam.inventory.Models;
using skadisteam.inventory;

namespace skadisteam.console
{
    internal class Program
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            Loader.LoadSettings();
            Console.ReadKey();
            var skadiLoadItemInventoryConfiguration =
                new SkadiLoadItemInventoryConfiguration
                {
                    AppId = 730,
                    ContextId = 2,
                    PartnerCommunityId = 76561198028630048
                };
            var inventory =
                SkadiInventoryClient.LoadInventoryItems(
                    skadiLoadItemInventoryConfiguration);
            Console.ReadKey();
            var skadiLoginData = new SkadiLoginData
            {
                Username = ConsoleSettings.Instance["username"],
                Password = ConsoleSettings.Instance["username"],
                SharedSecret = ConsoleSettings.Instance["username"]
            };
            var skadiLogin = new SkadiLogin();
            var skadiLoginResponse = skadiLogin.Execute(skadiLoginData);
            var skadiTradeClient = new SkadiTradeClient(skadiLoginResponse);
            var basicOffers = skadiTradeClient.GetBasicTradeOffers();
            Console.ReadKey();
        }
    }
}
