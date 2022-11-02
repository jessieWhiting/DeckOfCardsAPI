using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace DeckOfCardsAPI.Models
{
    public class DeckOfCardsDAL 
    {
        public Deck GetDeck(int num)
        {
            string url = $@"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1{num}";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync<Deck>(request);
            Deck d = response.Result;
            return d;
        }

        public DeckHand DeckResults(string id)
        {
            string url = $@"https://deckofcardsapi.com/api/deck/{id}/draw/?count=5";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync<DeckHand>(request);
            DeckHand dh = response.Result;
            return dh;
        }



    }
}
