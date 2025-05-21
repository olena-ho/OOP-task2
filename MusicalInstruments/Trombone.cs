namespace MusicalInstruments;

internal class Trombone : Instrument
{
    private const string name = "trombone";
    private const string description = "The trombone is a 15th-century development of the trumpet. Like a trumpet, it has a cylindrical bore flared to a bell. Its mouthpiece is larger, however, suited to its deeper musical register, and is parabolic in cross section, like a cornet.";
    private const string history = "The trombone is said to have been created in the middle of the 15th century. Until the 18th century the trombone was called a \"saqueboute\" (in French) or a \"sackbut\" (in English).";
    private const string soundDesc = "Brassy, brilliant, powerful, overpowering, solid, tense, penetrating, dramatic, hard, full, sinister, soft, round. The sound of the trombone remains homogeneous throughout its entire range.";

    public Trombone() : base(name, description, history, soundDesc) { }
}
