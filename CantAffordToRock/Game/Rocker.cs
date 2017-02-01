
namespace CantAffordToRock.Game
{
    public class Rocker
    {
        public Instrument Instrument { get; }
        public string Name { get; }
        public int Talent { get; }
        public int Charisma { get; }
        public int Opportunism { get; }

        public Rocker(Instrument instrument, string name, int talent, int charisma, int opportunism)
        {
            Instrument = instrument;
            Name = name;
            Talent = talent;
            Charisma = charisma;
            Opportunism = opportunism;
        }
    }
}
