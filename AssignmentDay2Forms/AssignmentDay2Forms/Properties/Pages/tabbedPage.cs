using System;
using Xamarin.Forms;

namespace AssignmentDay2Forms
{
	public class tabbedPage: TabbedPage
	{
		public tabbedPage ()
		{
			this.Children.Add (new ContentPage {
				Title="TabOne",
				BackgroundColor=Color.Aqua,
				Content = new StackLayout {
					
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Tab1"
						}

					}
				}
			});
			this.Children.Add (new ContentPage {
				Title="TabTwo",
				BackgroundColor=Color.Gray,
				Content = new StackLayout {
					
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Tab2"
						}

					}
				}
			});

			this.Children.Add (new ContentPage {
				Title="TabThree",
				BackgroundColor=Color.Green,
				Content = new StackLayout {
					
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Tab3"
						}

					}
				}
			});


		}
	}
}

