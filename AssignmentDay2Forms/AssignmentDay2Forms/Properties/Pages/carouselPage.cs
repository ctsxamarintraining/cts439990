using System;
using Xamarin.Forms;
using System.Collections.Generic;


namespace AssignmentDay2Forms
{
	public class carouselPage: CarouselPage
	{
		public carouselPage ()
		{

			List<ContentPage> pages = new List<ContentPage> (3);
			Color[] colors = { Color.Red, Color.Green, Color.Blue };
			foreach (Color c in colors) {
				pages.Add (new ContentPage { Content = new StackLayout {
						Children = {
							new BoxView {
								Color = c,
								VerticalOptions = LayoutOptions.FillAndExpand
							}
						}
					}
				});
			}
			this.Children.Add (pages [0]);
			this.Children.Add (pages [1]);
			this.Children.Add (pages [2]);

		}
	}
}

