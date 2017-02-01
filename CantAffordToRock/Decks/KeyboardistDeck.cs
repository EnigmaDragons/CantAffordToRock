using System.Collections.Generic;
using CantAffordToRock.CoreGame;

namespace CantAffordToRock.Decks
{
    public sealed class KeyboardistDeck : Deck
    {
        public KeyboardistDeck() 
            : base(Instrument.Keys, GetKeyboardists()) { }

        private static List<Rocker> GetKeyboardists()
        {
            return new List<Rocker>
            {
                new Rocker(Instrument.Keys, "Kool Shak", 5, 2, 2),
                new Rocker(Instrument.Keys, "Pisca Bella", 2, 5, 3),
                new Rocker(Instrument.Keys, "Kaylee Sung", 3, 3, 1),
                new Rocker(Instrument.Keys, "Sid Sethmes", 1, 3, 4),
                new Rocker(Instrument.Keys, "Tony Bonanza", 1, 1, 1),
                new Rocker(Instrument.Keys, "Billy Bullet", 3, 2, 1),
                new Rocker(Instrument.Keys, "Mike Mecanic", 1, 1, 3),
                new Rocker(Instrument.Keys, "Denis DD", 1, 2, 1)
            };
        }
    }
}
