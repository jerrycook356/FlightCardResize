using Foundation;
using System;
using UIKit;

namespace practice2
{
    public partial class AboutViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            myScrollView.ContentSize = new CoreGraphics.CGSize(
                View.Frame.Width + 200, View.Frame.Height + 300);
        }
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }
    }
}