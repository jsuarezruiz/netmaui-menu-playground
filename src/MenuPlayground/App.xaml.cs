﻿namespace MenuPlayground;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CustomNavigationPage(new MainPage());
	}
}
