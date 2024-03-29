using System;
using CoderwallLib;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace Coderwall.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		UINavigationController navigation;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);

		    GetProfile();

			var root = new RootElement ("");
			var dv = new DialogViewController (root);
			navigation = new UINavigationController (dv);
			// If you have defined a root view controller, set it here:
			window.RootViewController = navigation;
			
			// make the window visible
			window.MakeKeyAndVisible ();

			return true;
		}

	    private async void GetProfile()
	    {
	        var cw = new CoderwallContext();
	        var profile = await cw.GetProfileAsync("prashantvc");
	        Console.WriteLine(profile);
	    }
	}
}

