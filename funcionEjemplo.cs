private void Added(object sender, EventArgs e)
{
    BoxView newB = new BoxView();
    string newc = NewColor.Text;
    newB.Color = Color.FromArgb(newc);
    newB.HeightRequest = 100;
    newB.WidthRequest = 100;
    newB.CornerRadius = 25;
    newB.Margin = 10;
    content.Add(newB);
}
private void Deleted(object sender, EventArgs e)
{
    content.Clear();
}