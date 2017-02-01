using System.Collections.Generic;
using CantAffordToRock.Game;

namespace CantAffordToRock.Decks
{
    public sealed class DrummerDeck : Deck
    {
        public DrummerDeck() 
            : base(Instrument.Drums, GetDummers()) { }

        private static List<Rocker> GetDummers()
        {
            return new List<Rocker>
            {
                new Rocker(Instrument.Drums, "Mala Maniak", 3, 1, 2),
                new Rocker(Instrument.Drums, "Olaf Petermann", 1, 4, 3),
                new Rocker(Instrument.Drums, "bib Thunder", 2, 5, 2),
                new Rocker(Instrument.Drums, "Tiny Manu", 1, 2, 2),
                new Rocker(Instrument.Drums, "John Skytrick", 2, 1, 2),
                new Rocker(Instrument.Drums, "Peter Moon", 1, 1, 1),
                new Rocker(Instrument.Drums, "Juliet Noisy", 4, 1, 2),
                new Rocker(Instrument.Drums, "Toby Bear", 5, 3, 2)
            };
        }
    }
}
