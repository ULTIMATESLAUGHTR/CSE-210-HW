using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureHider
{
    private string _text;
    private List<string> _words;
    private HashSet<int> _hiddenWordIndices;
    private Random _random;

    public ScriptureHider(string text)
    {
        _text = text;
        _words = text.Split(' ').ToList();
        _hiddenWordIndices = new HashSet<int>();
        _random = new Random();
    }
    public string GetHiddenText()
    {
        var displayWords = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (_hiddenWordIndices.Contains(i))
            {
                displayWords.Add(new string('_', _words[i].Length));
            }
            else
            {
                displayWords.Add(_words[i]);
            }
        }
        return string.Join(" ", displayWords);
    }
    public void HideRandomWords(int count)
    {
        count = Math.Max(1, Math.Min(3, count));
        var availableIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_hiddenWordIndices.Contains(i))
            {
                availableIndices.Add(i);
            }
        }
        int wordsToHide = Math.Min(count, availableIndices.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(availableIndices.Count);
            int wordIndex = availableIndices[randomIndex];
            _hiddenWordIndices.Add(wordIndex);
            availableIndices.RemoveAt(randomIndex);
        }
    }

    public bool AllWordsHidden => _hiddenWordIndices.Count == _words.Count;

    public string GetOriginalText()
    {
        return _text;
    }
}