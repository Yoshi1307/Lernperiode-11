using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VociTrainer.Models;

namespace VociTrainer.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly Random _random = new();

    public ObservableCollection<Word> Words { get; } = new()
    {
        new Word { German = "Haus", English = "house" },
        new Word { German = "Hund", English = "dog" },
        new Word { German = "Katze", English = "cat" },
        new Word { German = "Buch", English = "book" },
        new Word { German = "Wasser", English = "water" },
    };

    [ObservableProperty]
    private Word _currentWord;

    [ObservableProperty]
    private string _userAnswer = "";

    [ObservableProperty]
    private string _feedbackText = "";

    public MainViewModel()
    {
        _currentWord = Words[_random.Next(Words.Count)];
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
        CurrentWord = Words[_random.Next(Words.Count)];
    }
}