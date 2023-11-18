using Microsoft.Extensions.Options;
using System.Runtime.InteropServices;

namespace usersNew;

public partial class FlowContentAll : ContentPage
{
    public FlowContentAll(List<Student> entryValue)
	{
        InitializeComponent();
        foreach (Student std in entryValue)
        {
            Frame fr1 = new Frame();
            Label lb = new Label();
            lb.Text = std.id + "\n" + std.name.ToString() + "\n" + std.lastname1.ToString() + " " + std.lastname2.ToString() + "\n" + std.group.ToString();
            lb.VerticalOptions = LayoutOptions.CenterAndExpand;
            lb.HorizontalOptions = LayoutOptions.CenterAndExpand;
            lb.FontSize = 18;
            fr1.Content = lb;
            fr1.Margin = 20;
            fr1.BackgroundColor = Color.FromArgb(std.color);
            fr1.WidthRequest = 200;
            fr1.HeightRequest = 140;
            contentAllBoxes.Add(fr1);
        }
    }
}






