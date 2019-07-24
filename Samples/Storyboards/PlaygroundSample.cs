using System;
using Ooui;
using Xamarin.Forms;

namespace Samples.Storyboards
{
    public class PlaygroundSample : ISample
    {
        public string Title => "Xamarin.Forms Storyboard Animations";
        public string Path => "/storyboards-playground";

        public Ooui.Element CreateElement ()
        {
            var page = new Playground ();
            return page.GetOouiElement ();
        }

        public void Publish ()
        {
            UI.Publish (Path, CreateElement);
        }
    }
}
