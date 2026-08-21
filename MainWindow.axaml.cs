using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TestProjekt1.Views;

public partial class MainWindow : Window
{

    private int Einnahmen_Geld { get; set; } = 0;
    private int Ausgaben_Geld { get; set; } = 0;
    private int Vermögen_Geld;
    public MainWindow()
    {
        InitializeComponent();
    }


    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
       if (int.TryParse(NeueEinnahmen.Text, out int neueEinnahmen))
       {
            Einnahmen_Geld += neueEinnahmen;
            Einnahmen.Text = Einnahmen_Geld.ToString();

            NeueEinnahmen.Text = string.Empty;
        }

       if (int.TryParse(NeueAusgaben.Text, out int neueAusgaben))
       {
            Ausgaben_Geld += neueAusgaben;
            Ausgaben.Text = Ausgaben_Geld.ToString();

            NeueAusgaben.Text = string.Empty;
        }
       
        Vermögen_Geld = Einnahmen_Geld - Ausgaben_Geld;
        Vermögen.Text = Vermögen_Geld.ToString();
    }
}