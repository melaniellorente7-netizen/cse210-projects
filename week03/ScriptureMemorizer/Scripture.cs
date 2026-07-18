public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] allWords = text.Split(' ');

        foreach (string wordText in allWords)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHiddenSoFar = 0;

        while (wordsHiddenSoFar < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(0, _words.Count());

            Word selectedWord = _words[randomIndex];

            if (!selectedWord.IsHidden())
            {
                selectedWord.Hide();
                wordsHiddenSoFar++;
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> wordsToDisplay = new List<string>();

        foreach (Word word in _words)
        {
            wordsToDisplay.Add(word.GetDisplayText());
        }

        string textWithUnderscores = string.Join(" ", wordsToDisplay);

        return $"{_reference.GetDisplayText()} {textWithUnderscores}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}