using System;

public class ScriptureHider
{
    private string _text;
    private string _hiddenText;
    private Random _random;

    private ScriptureHider(string text)
    {
        _text = text;
        _hiddenText = text;
        _random = new Random();
    }
    private string GetHiddenText()
    {
        return _hiddenText;
    }
    private void HideRandomWords(int count)
    {
        count = Math.Max(1, Math.Min(3, count));
        var words = _hiddenText.Split(' ');
        int hiddenCount = 0;
        int maxAttempts = words.Length * 2; // Prevent infinite loop
        int attempts = 0;

        while (hiddenCount < count && attempts < maxAttempts)
        {
            int index = _random.Next(words.Length);
            if (words[index] != "____")
            {
                words[index] = "____";
                hiddenCount++;
            }
        }

        _hiddenText = string.Join(" ", words);
    }
}