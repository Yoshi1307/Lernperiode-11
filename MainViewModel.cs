using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VociTrainer.Models;

namespace VociTrainer.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly Random _random = new();

    public ObservableCollection<Word> WordsE { get; } = new()
    {
        new Word { GermanE = "Haus", English = "house" },
        new Word { GermanE = "Hund", English = "dog" },
        new Word { GermanE = "Katze", English = "cat" },
        new Word { GermanE = "Buch", English = "book" },
        new Word { GermanE = "Wasser", English = "water" },
        new Word { GermanE = "Tisch", English = "table" },
        new Word { GermanE = "Stuhl", English = "chair" },
        new Word { GermanE = "Auto", English = "car" },
        new Word { GermanE = "Apfel", English = "apple" },
        new Word { GermanE = "Brot", English = "bread" },
        new Word { GermanE = "Schule", English = "school" },
        new Word { GermanE = "Hausaufgabe", English = "homework" },
        new Word { GermanE = "Freund", English = "friend" },
        new Word { GermanE = "Familie", English = "family" },
        new Word { GermanE = "Sonne", English = "sun" },
        new Word { GermanE = "Mond", English = "moon" },
        new Word { GermanE = "Baum", English = "tree" },
        new Word { GermanE = "Stadt", English = "city" },


    };

    public ObservableCollection<Word> WordsF { get; } = new()
    {
              new Word { GermanF = "Haus", French = "maison" },
        new Word { GermanF = "Hund", French = "chien" },
        new Word { GermanF = "Katze", French = "chat" },
        new Word { GermanF = "Buch", French = "livre" },
        new Word { GermanF = "Wasser", French = "eau" },
        new Word { GermanF = "Tisch", French = "table" },
        new Word { GermanF = "Stuhl", French = "chaise" },
        new Word { GermanF = "Auto", French = "voiture" },
        new Word { GermanF = "Apfel", French = "pomme" },
        new Word { GermanF = "Brot", French = "pain" },
        new Word { GermanF = "Schule", French = "école" },
        new Word { GermanF = "Hausaufgabe", French = "devoirs" },
        new Word { GermanF = "Freund", French = "ami" },
        new Word { GermanF = "Familie", French = "famille" },
        new Word { GermanF = "Sonne", French = "soleil" },
        new Word { GermanF = "Mond", French = "lune" },
        new Word { GermanF = "Baum", French = "arbre" },
        new Word { GermanF = "Stadt", French = "ville" },
    };

    [ObservableProperty]
    private Word _currentWord;

    [ObservableProperty]
    private string _userAnswer = "";

    [ObservableProperty]
    private string _feedbackText = "";

    public MainViewModel()
    {
        _currentWord = WordsE[_random.Next(WordsE.Count)];
    }

    [RelayCommand]
    private void CheckAnswer()
    {
        if (string.Equals(UserAnswer.Trim(), CurrentWord.English, StringComparison.OrdinalIgnoreCase))
        {
            FeedbackText = "Richtig!";
        }
        else
        {
            FeedbackText = $"Leider falsch. Richtig wäre: {CurrentWord.English}";
        }

        UserAnswer = "";
        CurrentWord = WordsE[_random.Next(WordsE.Count)];
    }
}