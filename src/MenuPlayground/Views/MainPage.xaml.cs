namespace MenuPlayground;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
	}

	void OnMenuItemClicked(object sender, EventArgs e)
	{
		if (sender is MenuFlyoutItem mfi)
		{
			MenuLabel.Text = $"You clicked on Menu Item: { mfi.Text}";
		}
	}

	void ToggleMenuBarItem(object sender, EventArgs e)
	{
		MenuBarItem barItem =
			MenuBarItems.FirstOrDefault(x => x.Text == "Dynamic MenuBarItem");

		if (barItem == null)
		{
			barItem = new MenuBarItem()
			{
				Text = "Dynamic MenuBarItem"
			};

			barItem.Add(new MenuFlyoutItem()
			{
				Text = "Dynamic MenuFlyoutItem",
				Command = new Command(() => OnMenuItemClicked(barItem.First(), EventArgs.Empty))
			});

			MenuBarItems.Add(barItem);
		}
		else
		{
			MenuBarItems.Remove(barItem);
		}
	}
}