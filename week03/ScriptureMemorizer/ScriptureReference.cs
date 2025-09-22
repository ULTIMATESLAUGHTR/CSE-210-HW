using System;
using System.Collections.Generic;

public class ScriptureReference
{
    public string Reference { get; private set; }
    public string Text { get; private set; }

    public ScriptureReference(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Reference}: {Text}";
    }
}

public class ScriptureCollection
{
    private List<ScriptureReference> _scriptureQuotes;
    private Random _random;

    public ScriptureCollection()
    {
        _random = new Random();
        _scriptureQuotes = new List<ScriptureReference>
        {
            new ScriptureReference("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new ScriptureReference("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all ways submit to him, and he will make your paths straight."),
            new ScriptureReference("Philippians 4:13", "I can do all this through him who gives me strength."),
            new ScriptureReference("Psalm 23:1-4", "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul. He guides me along the right paths for his name's sake. Even though I walk through the darkest valley, I will fear no evil, for you are with me; your rod and your staff, they comfort me."),
            new ScriptureReference("Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new ScriptureReference("Isaiah 41:10", "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."),
            new ScriptureReference("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."),
            new ScriptureReference("Moroni 10:4-5", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.")
        };
    }

    public ScriptureReference GetRandomScripture()
    {
        int index = _random.Next(_scriptureQuotes.Count);
        return _scriptureQuotes[index];
    }
}