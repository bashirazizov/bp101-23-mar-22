using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclesFb.ModelF
{
    class Post
    {
        public string Text;
        public DateTime SharedDate;
        public int LikeCount;
        public int CommentCount;
        public Comment[] Comments;
    }
}
