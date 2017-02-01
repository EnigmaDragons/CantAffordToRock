using System.Collections.Generic;
using CantAffordToRock.CoreGame;

namespace CantAffordToRock.Decks
{
    public sealed class GuitaristDeck : Deck
    {
        public GuitaristDeck()
            : base(Instrument.Guitar, GetGuitarists()) { }

        private static List<Rocker> GetGuitarists()
        {
            return new List<Rocker>
            {
                new Rocker(Instrument.Guitar, "Helen Eleven", 1, 2, 1),
                new Rocker(Instrument.Guitar, "Doc Dark", 3, 2, 5),
                new Rocker(Instrument.Guitar, "Roberto Carlos", 1, 1, 1),
                new Rocker(Instrument.Guitar, "Jenny Calam", 2, 5, 2),
                new Rocker(Instrument.Guitar, "Bill Laker", 3, 1, 1),
                new Rocker(Instrument.Guitar, "Joe King", 2, 1, 3),
                new Rocker(Instrument.Guitar, "Matthew Wheriz", 1, 4, 2),
                new Rocker(Instrument.Guitar, "Tib Mazarus", 4, 3, 1)
            };
        }
    }
}
