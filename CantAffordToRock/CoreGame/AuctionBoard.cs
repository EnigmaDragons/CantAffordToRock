using System;
using System.Collections.Generic;
using System.Linq;

namespace CantAffordToRock.CoreGame
{
    public class AuctionBoard
    {
        private readonly List<Instrument> _instruments;

        public Dictionary<Instrument, Deck> Decks { get; }
        public List<Rocker> AvailableRockers { get; }

        public AuctionBoard(List<Deck> decks)
        {
            Decks = new Dictionary<Instrument, Deck>();
            decks.ForEach(x => Decks.Add(x.Instrument, x));
            AvailableRockers = new List<Rocker>();
            _instruments = Enum.GetValues(typeof(Instrument)).Cast<Instrument>().ToList();
        }

        public void DrawRockers()
        {
            _instruments.ForEach(inst =>
            {
                if (!AvailableRockers.Any(x => x.Instrument.Equals(inst)))
                    AvailableRockers.Add(Decks[inst].Draw());
            });
        }
    }
}
