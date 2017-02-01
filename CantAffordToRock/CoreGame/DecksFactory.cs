using System.Collections.Generic;
using CantAffordToRock.Decks;

namespace CantAffordToRock.CoreGame
{
    public class DecksFactory
    {
        public List<Deck> CreateStandardDecks()
        {
            return new List<Deck>
            {
                new GuitaristDeck(),
                new VocalistDeck(),
                new BassistDeck(),
                new DrummerDeck(),
                new KeyboardistDeck()
            };
        }

    }
}
