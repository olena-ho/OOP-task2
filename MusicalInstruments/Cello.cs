namespace MusicalInstruments;

internal class Cello : Instrument
{
    private const string name = "cello";
    private const string description = "It is a bass musical instrument of the violin group, with four strings. The cello, about 70 cm long (119 cm with the neck), has proportionally deeper ribs and a shorter neck than the violin.";
    private const string history = "The cello came to the limelight for the first time in northern Italy in 1550. It is a member of the violin family and was initially called bass violin. In Italy, it was called viola da braccio.";
    private const string soundDesc = "Its deep tenor voice can be further enhanced by a broad vibrato which on other instruments might sound ridiculous. With its particularly wide range and powerful sound it can one minute be playing a bass line and the next a melody that is high enough for the rest of the orchestra to move underneath.";

    public Cello() : base(name, description, history, soundDesc) { }
}
