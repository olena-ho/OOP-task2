namespace MusicalInstruments;

internal class Violin : Instrument
{
    private const string name = "violin";
    private const string description = "It is the soprano of the string family. It has a hollow, wooden body and four strings.";
    private const string history = "first built in the early 16th century, in Italy. The earliest evidence for their existence is in paintings by Gaudenzio Ferrari from the 1530s, though Ferrari's instruments had only three strings.";
    private const string soundDesc = "The sound made by the violin can vary from bright and vibrant to solemn and mellow. The sound is made by drawing a bow across the strings, or by plucking the strings with a finger.";

    public Violin() : base(name, description, history, soundDesc) { }
}
