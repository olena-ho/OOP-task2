namespace MusicalInstruments;

internal class Ukulele : Instrument
{
    private const string name = "ukulele";
    private const string description = "Also known as uke, is a four-stringed musical instrument made from wood that resembles a small classical acoustic guitar.";
    private const string history = "Developed in the 1880s, the ukulele is based on several small, guitar-like instruments of Portuguese origin, the machete, cavaquinho and rajão, introduced to the Hawaiian Islands by Portuguese immigrants from Madeira, the Azores, and Cape Verde.";
    private const string soundDesc = "The tone and volume of the instrument vary with size and construction. Ukuleles commonly come in four sizes: soprano, concert, tenor, and baritone.";

    public Ukulele() : base(name, description, history, soundDesc) { }
}
