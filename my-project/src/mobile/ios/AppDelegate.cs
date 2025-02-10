using Foundation;
using UIKit;

namespace MyProject.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            return true;
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive.
        }

        public override void OnResignActivation(UIApplication application)
        {
            // This method is called when the application is about to move from active to inactive state.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers, and store enough application state information to restore your application to its current state in case it is terminated later.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transition from the background to the active state; here you can undo many of the changes made on entering the background.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data if appropriate. See also DidEnterBackground.
        }
    }
}