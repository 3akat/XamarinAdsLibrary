using Xamarin.Forms;
using XamarinAdsLibrary;

[assembly: Dependency(typeof(IPausedAds))]
namespace PausedAdsTvOS
{
    public class PausedAds : IPausedAds
    {
        public PausedAds()
        {
        }
        
        public PausedAds(string testText)
        {
            TestText = testText;
        }

        public string TestText { get; }
        
         
        public void StartAds(bool skipped)
        {
            AppleTVAds.AppleTVAds appleTvAds = new AppleTVAds.AppleTVAds();
            appleTvAds.OpenSDK();
        }
        
        public AppleTVAds.TVAdsViewController GetAdsViewController()
        {
            AppleTVAds.TVAdsViewController tVAdsViewController = new AppleTVAds.TVAdsViewController();
            return tVAdsViewController;
        }

    }
}