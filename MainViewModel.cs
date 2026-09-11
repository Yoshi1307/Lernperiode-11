using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VociTrainer.Models;
namespace VociTrainer.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly Random _random = new();
    [ObservableProperty]
    private bool _isFehlerrunde = false;

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

    private readonly List<Word> _remainingWordsE = new();
    private readonly List<Word> _remainingWordsF = new();

    private readonly List<Word> _wrongE = new();
    private readonly List<Word> _wrongF = new();

    [ObservableProperty]
    private string _userAnswer = "";

    [ObservableProperty]
    private string _feedbackText = "";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ScoreText))]
    private int _ScoreE = 0;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ScoreText))]
    private int _ScoreF = 0;

    public string ScoreText => $"Score: {_ScoreE} (Englisch), {_ScoreF} (Französisch)";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CurrentGermanWord))]
    private Word _currentWord;  

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CurrentGermanWord))]
    private int _selectedLanguageIndex;

    public string CurrentGermanWord
    {
        get
        {
            if (SelectedLanguageIndex == 1)
            {
                return CurrentWord.GermanF;
            }
            else
            {
                return CurrentWord.GermanE;
            }
        }
    }

    private void Shuffle(List<Word> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    public MainViewModel()
    {
        PickNewWord();
    }

    [RelayCommand]
    private void CheckAnswer()
    {
        bool isFrench = SelectedLanguageIndex == 1;
        string correctAnswer;

        if (isFrench) 
        { 
            correctAnswer = CurrentWord.French;
        }
        else {  
            correctAnswer = CurrentWord.English;
        }

        if (string.Equals(UserAnswer.Trim(), correctAnswer))
        {
            FeedbackText = "Richtig!";
            if ((isFrench))
            {
                ScoreF++;
            } else
            {
                ScoreE++;
            }
        }
        else
        {
            FeedbackText = $"Leider falsch. Richtig wäre: {correctAnswer}";
            if (isFrench && !_wrongF.Contains(CurrentWord))
            {
                _wrongF.Add(CurrentWord);
            }
            else if (!isFrench && !_wrongE.Contains(CurrentWord))
            {
                _wrongE.Add(CurrentWord);
            }
        }

        UserAnswer = "";
        PickNewWord();
    }

    private void PickNewWord()
    {
        List<Word> remaining;
        ObservableCollection<Word> source;

        if (SelectedLanguageIndex == 1)
        {
            remaining = _remainingWordsF;
            source = WordsF;
        }
        else
        {
            remaining = _remainingWordsE;
            source = WordsE;
        }

        if (remaining.Count == 0)
        {
            List<Word> wrongList;

            if (SelectedLanguageIndex == 1)
            {
                wrongList = _wrongF;
            }
            else
            {
                wrongList = _wrongE;
            }

            if (wrongList.Count > 0)
            {
                remaining.AddRange(wrongList);
                wrongList.Clear();
                IsFehlerrunde = true;
            }
            else
            {
                remaining.AddRange(source);
                IsFehlerrunde = false;
            }

            Shuffle(remaining);
        }

        int lastIndex = remaining.Count - 1;
        CurrentWord = remaining[lastIndex];
        remaining.RemoveAt(lastIndex);
    }
}