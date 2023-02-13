using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Alerts;
namespace MauiApp20;

public partial class NewPage1 : Popup
{
	public NewPage1()
    {
        InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Close(true);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Close(false);
    }
}