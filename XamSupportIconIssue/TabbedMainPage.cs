using System;

using Xamarin.Forms;

namespace XamSupportIconIssue
{
    public class TabbedMainPage : TabbedPage
    {
        public TabbedMainPage()
        {
            Title = "Tabbed Page";
            Children.Add(new Page1());
            Children.Add(new Page2());
        }
    }
}
