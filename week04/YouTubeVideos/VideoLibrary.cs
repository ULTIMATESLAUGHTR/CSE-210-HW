using System;
using System.Collections.Generic;

public class VideoLibrary
{
    private List<Video> _videos;

    public VideoLibrary()
    {
        _videos = new List<Video>();
        ViewVideoCollection();
    }

    private void ViewVideoCollection()
    {
        _videos.Add(new Video("Sample YoutubeVideo", "Smosh", 120));
        _videos.Add(new Video("Another YoutubeVideo", "PewDiePie", 300));
        _videos.Add(new Video("Yet Another YoutubeVideo", "MrBeast", 600));
        _videos.Add(new Video("Fourth YoutubeVideo", "Freddie Wong", 180));
    }

    public void AddVideo(Video video)
    {
        if (video != null)
        {
            _videos.Add(video);
        }
    }

    public List<Video> GetAllVideos()
    {
        return new List<Video>(_videos);
    }
    public Video GetVideoByTitle(string title)
    {
        foreach (var video in _videos)
        {
            if (video.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return video;
            }
        }
        return null;
    }

    public int GetVideoCount()
    {
        return _videos.Count;
    }
}