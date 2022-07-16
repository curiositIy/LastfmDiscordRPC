﻿using static System.String;

namespace LastfmDiscordRPC.MVVM.ViewModels;

public sealed class PreviewViewModel : ViewModelBase
{
    private string _imageURL;
    public string ImageURL
    {
        get => _imageURL;
        set
        {
            if (value == _imageURL) return;
            _imageURL = value;
            HighResURL = _imageURL.Replace(@"/300x300", "");
            OnPropertyChanged(nameof(ImageURL));
        }
    }
    
    private string _highResURL;
    public string HighResURL
    {
        get => _highResURL;
        set
        {
            if (value == _highResURL) return;
            _highResURL = value == @"https://lastfm.freetls.fastly.net/i/u/4128a6eb29f94943c9d206c08e625904.jpg" ? Empty : value;
            OnPropertyChanged(nameof(HighResURL));
        }
    }

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            if (value == _name) return;
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    private string _artistName;
    public string ArtistName
    {
        get => _artistName;
        set
        {
            if (value == _artistName) return;
            _artistName = value;
            OnPropertyChanged(nameof(ArtistName));
        }
    }

    private string _albumName;
    public string AlbumName
    {
        get => _albumName;
        set
        {
            if (value == _albumName) return;
            _albumName = value;
            OnPropertyChanged(nameof(AlbumName));
        }
    }

    public PreviewViewModel()
    {
        _imageURL = Empty;
        _highResURL = Empty;
        _name = Empty;
        _artistName = Empty;
        _albumName = Empty;
    }
}