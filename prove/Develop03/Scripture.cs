using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

public class Scripture
{
    public Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        this._words = new List<Word>();
        string[] textList = text.Split(" ");
        foreach (string i in textList)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        for (int j = 0; j < numberToHide; j++)
        {
            visibleWords.Clear();

            foreach (Word item in _words)
            {
                if (item.IsHidden() == false)
                {
                    visibleWords.Add(item);
                }
            }

            int randomNumber = random.Next(visibleWords.Count);

            visibleWords[randomNumber].Hide();
        }
    }
    public string GetDisplayText()
    {
        string displayedText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayedText += " " + word.GetDisplayText();
        }
        return displayedText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() != false)
            {
                return false;
            }
        }
        return true;
    }
}