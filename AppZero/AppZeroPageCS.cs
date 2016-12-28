using System;
using Xamarin.Forms;
namespace AppZero
{
	public class AppZeroPageCS:TabbedPage
	{
		public AppZeroPageCS()
		{
			Children.Add(new SettingsPage());
			Children.Add(new SettingsPage());
			Children.Add(new SettingsPage());
		}
	}
}
