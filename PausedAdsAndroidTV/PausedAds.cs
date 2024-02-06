using System.Diagnostics;
using Android.Content;
using Com.Example.Androidtvlibrary.Main;
using PausedAds.CustomView;
using Xamarin.Forms;
using XamarinAdsLibrary;

[assembly: Dependency(typeof(IPausedAds))]
namespace PausedAds
{
  public class PausedAds : IPausedAds
  {
    private Context _context;
    public PausedAds(Context context)
    {
      _context = context;
      PlayerView = new PlayerView(_context);
      TestText = "sometesthere";
      TvTestLibrary = new TVTestLibrary();
    }

    public void StartAds(bool skipped)
    {
      Debug.Assert(TvTestLibrary != null, nameof(TvTestLibrary) + " != null");
      TvTestLibrary.StartAdsLoader(_context, skipped);
    }

    public TVTestLibrary TvTestLibrary { get; }
    public PlayerView PlayerView { get; }
    public string TestText { get; }
  }
}