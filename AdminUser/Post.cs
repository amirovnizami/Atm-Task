using System.Reflection.Metadata.Ecma335;

namespace postNamespace;

public class Post
{

    public int id { get; set; }
    public string Content { get; set; }
    public DateOnly CreationDateTime { get; set; }
    public int LikeCount { get; set; }
    public int ViewCount { get; set; }
    public Post(int id, string content, DateTime creationDateTime, int likeCount, int viewCount)
    {
        this.id = id;
        Content = content;
        CreationDateTime = CreationDateTime;
        LikeCount = likeCount;
        ViewCount = viewCount;
    }

    public string ToString()
    {

        return $"Id: {id}\nContent :{Content}\nDate:{CreationDateTime}\nLike: :{LikeCount}\nViewCount :{ViewCount}";
    }
}
