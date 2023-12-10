using System;

class Video{
    private string _videoTitle;
    private string _videoAuthor;
    private double _videoLength;
    private List<Comment> _CommentList = new List<Comment>();   

    public Video(string title, string author, double length){
        this._videoTitle = title;
        this._videoAuthor = author;
        this._videoLength = length;
    }

    public string GetVideoTitle(){
        return this._videoTitle;
    }

    public string GetVideoAuthor(){
        return this._videoAuthor;
    }

    public double GetVideoLength(){
        return this._videoLength;
    }

    public void AddVideoComment(Comment comment){
        this._CommentList.Add(comment);
    }

    public List<Comment> GetCommentList(){
        return this._CommentList;
    }
}