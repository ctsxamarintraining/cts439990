using System;

using Xamarin.Forms;

namespace AssignmentDay2Forms
{
	public class App : Application
	{
		public App ()
		{

			MainPage = new masterDetail {
				
			};

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

