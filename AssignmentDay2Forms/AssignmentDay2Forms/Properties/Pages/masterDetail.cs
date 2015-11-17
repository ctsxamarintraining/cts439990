using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AssignmentDay2Forms
{
	public class masterDetail: MasterDetailPage
	{
		public masterDetail ()
		{




			string[] types = new string[]{ "contentPage", "TabbedPage", "carouselPage" };

			Label header = new Label
			{
				Text = "MasterViewPage",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.Center
			};

			ListView listView = new ListView
			{
			ItemsSource = types
			

			};
		

			listView.ItemSelected+=((sender, e) => 
				{
					if (listView.SelectedItem.ToString() == types[0].ToString()) {
						this.Detail = new ContentPage {
							Content = new StackLayout {
								VerticalOptions = LayoutOptions.Center,
								Children = {
									new Label {
										XAlign = TextAlignment.Center,
										Text = "ContentView!"
									}

								}
							}

						};
					} 
					else if (listView.SelectedItem.ToString() == types[1].ToString()) {
						this.Detail = new tabbedPage ();
					}
					else if(listView.SelectedItem.ToString()==types[2].ToString())
					{
						this.Detail = new NavigationPage(new carouselPage());
					}

					this.IsPresented=false;

				});
			

			this.Master = new ContentPage
			{
				Title = header.Text,
				Content = new StackLayout
				{ 
					VerticalOptions = LayoutOptions.Center,
					Children = 
					{
						header,
						listView
					}
					}
			};
			listView.SelectedItem = types [0];



		}
	}
}

