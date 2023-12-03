using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Psalm 23", "The LORD is my shepherd, I lack nothing. He makes me lie down in green pastures, he leads me beside quiet waters, he refreshes my soul. He guides me along the right paths for his name’s sake. Even though I walk through the darkest valley, I will fear no evil, for you are with me; your rod and your staff, they comfort me. You prepare a table before me in the presence of my enemies. You anoint my head with oil; my cup overflows.Surely your goodness and love will follow me all the days of my life, and I will dwell in the house of the LORD forever..");
        while (!scripture.AllWordsHidden())
        {
            TryClearConsole();

            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords();
        }
    }

    static void TryClearConsole()
    {
        try
        {
            Console.Clear();
        }
        catch (System.IO.IOException)
        {
            Console.WriteLine("Unable to clear the console. Proceeding without clearing.");
        }
    }
}

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = new Reference(reference);
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = rand.Next(1, words.Count / 2); // Adjust this logic as needed
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(words.Count);
            words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }

    public override string ToString()
    {
        return $"{reference}: {string.Join(" ", words)}";
    }
}

class Reference
{
    private string text;

    public Reference(string text)
    {
        this.text = text;
    }

    public override string ToString()
    {
        return text;
    }
}

class Word
{
    private string text;
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        this.text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "____" : text;
    }
}

