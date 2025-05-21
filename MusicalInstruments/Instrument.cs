namespace MusicalInstruments;

internal abstract class Instrument
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public string HistoryText { get; protected set; }
    public string SoundDesc { get; protected set; }

    protected Instrument(string name, string description, string history, string soundDesc)
    {
        Name = name;
        Description = description;
        HistoryText = history;
        SoundDesc = soundDesc;
    }
    public void Sound()
    {
        Console.WriteLine($"The sound:\n\t{SoundDesc}\n");
    }

    public void Show()
    {
        Console.WriteLine($"The instrument is called {Name}\n");
    }

    public void Desc()
    {
        Console.WriteLine($"The {Name} has the following characteristics:\n\t{Description}\n");
    }

    public void History()
    {
        Console.WriteLine($"The history of {Name}:\n\t{HistoryText}\n");
    }
}
