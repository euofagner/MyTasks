namespace src;

public partial class MainPage : ContentPage
{
    public List<string> tasks = new();

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        tasks.Add(taskEntry.Text);
    }
}
