using System.Collections.Generic;
using CantAffordToRock.CoreGame;

namespace CantAffordToRock.Decks
{
    public sealed class VocalistDeck : Deck
    {
        public VocalistDeck()
            : base(Instrument.Vocals, GetVocalists()) { }

        private static List<Rocker> GetVocalists()
        {
            return new List<Rocker>
            {
                new Rocker(Instrument.Vocals, "Dom Figgy", 2, 1, 1),
                new Rocker(Instrument.Vocals, "Pat Balam", 3, 1, 2),
                new Rocker(Instrument.Vocals, "Raoul Castle", 2, 2, 5),
                new Rocker(Instrument.Vocals, "Jacky Bananas", 1, 1, 1),
                new Rocker(Instrument.Vocals, "Mat Yahiko", 4, 2, 1),
                new Rocker(Instrument.Vocals, "Scarlett Inara", 5, 2, 3),
                new Rocker(Instrument.Vocals, "Dave Ardilo", 1, 1, 3),
                new Rocker(Instrument.Vocals, "Lucy Spark", 1, 4, 3)
            };
        }
    }
}
