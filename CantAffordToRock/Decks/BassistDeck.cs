using System.Collections.Generic;
using CantAffordToRock.CoreGame;

namespace CantAffordToRock.Decks
{
    public sealed class BassistDeck : Deck
    {
        public BassistDeck()
            : base(Instrument.Bass, GetBassists()) { }

        private static List<Rocker> GetBassists()
        {
            return new List<Rocker>
            {
                new Rocker(Instrument.Bass, "Giles Garner", 1, 3, 1),
                new Rocker(Instrument.Bass, "Jade Hansen", 5, 2, 2),
                new Rocker(Instrument.Bass, "Uluk Nash", 2, 1, 4),
                new Rocker(Instrument.Bass, "Isaac Black", 2, 2, 2),
                new Rocker(Instrument.Bass, "Mary Fingers", 1, 1, 2),
                new Rocker(Instrument.Bass, "Oliver T. Rex", 3, 3, 2),
                new Rocker(Instrument.Bass, "Ursula Red", 1, 1, 1),
                new Rocker(Instrument.Bass, "Murphy Malone", 3, 5, 2)
            };
        }
    }
}
