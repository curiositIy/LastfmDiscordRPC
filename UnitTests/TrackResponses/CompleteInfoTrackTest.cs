using static System.String;

namespace UnitTests.TrackResponses;

public class CompleteInfoTrackTest
{
    // All tests completed at the time they were completed
    private LastfmResponse _response = null!;
    private const string Username = "mabdi36";
    private const string APIKey = "05467a3191853eb8da38dfb38ed3c733";

    [SetUp]
    public async Task Setup()
    {
        LastfmClient client = new LastfmClient();
        try
        {
            _response = await client.CallAPI(Username, APIKey);
        } catch (LastfmException)
        {
            Fail();
        } catch (HttpRequestException)
        {
            Fail();
        }
    }

    [Test]
    public void Name()
    {
        const string actualTrack = "bye bye cubase";
        string? respondedTrackName = _response.Track?.Name;
        That(respondedTrackName, Is.EqualTo(actualTrack));
    }

    [Test]
    public void Artist()
    {
        const string actualArtist = "鈴木ねんど";
        string? respondedTrackArtist = _response.Track?.Artist.Name;
        That(respondedTrackArtist, Is.EqualTo(actualArtist));
    }

    [Test]
    public void Album()
    {
        const string actualArtist = "鈴木ねんどのアーメン粘土細工EP";
        string? respondedTrackArtist = _response.Track?.Album.Name;
        That(respondedTrackArtist, Is.EqualTo(actualArtist));
    }

    [Test]
    public void NowPlaying()
    {
        const string actualNowPlaying = "true";
        string? respondedNowPlaying = _response.Track?.NowPlaying.State;
        That(respondedNowPlaying, Is.EqualTo(actualNowPlaying));
    }

    [Test]
    public void Timestamp()
    {
        string actualTimestamp =  Empty;
        string? respondedTimestamp = _response.Track?.Date.Timestamp;
        That(actualTimestamp, Is.EqualTo(respondedTimestamp));
    }

    [Test]
    public void Image()
    {
        string? respondedImage = _response.Track?.Images[3].URL;
        That(respondedImage, Is.EqualTo(Track.DefaultSingleCover));
    }
}