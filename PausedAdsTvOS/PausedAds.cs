using Xamarin.Forms;
using XamarinAdsLibrary;

[assembly: Dependency(typeof(IPausedAds))]
namespace PausedAdsTvOS
{
    public class PausedAds : IPausedAds
    {
        public PausedAds(string testText)
        {
            TestText = testText;
        }

        public string TestText { get; }
        public void StartAds(bool skipped)
        {
            throw new System.NotImplementedException();
        }

    }
}