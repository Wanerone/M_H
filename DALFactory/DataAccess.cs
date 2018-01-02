using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using System.Configuration;
using System.Reflection;

namespace DALFactory
{
    public class DataAccess
    {
         private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUsers CreateUsers()
        {
             string className = AssemblyName + "." + db + "Users";
           // string className = "DAL.SqlServerUsers";
            return (IUsers)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IUserIn CreateUserIn()
        {
            string className = AssemblyName + "." + db + "UserIn";
            return (IUserIn)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArticle CreateArticle() 
        {
            string className = AssemblyName + "." + db + "Article";
            return (IArticle)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideo CreateVideo()
        {
            string className = AssemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideoComment CreateVideoComment()
        {
            string className = AssemblyName + "." + db + "VideoComment";
            return (IVideoComment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideoReply CreateVideoReply()
        {
            string className = AssemblyName + "." + db + "VideoReply";
            return (IVideoReply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideoStatic CreateVideoStatic()
        {
            string className = AssemblyName + "." + db + "VideoStatic";
            return (IVideoStatic)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IGoods CreateGoods()
        {
            string className = AssemblyName + "." + db + "Goods";
            return (IGoods)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IActivity CreateActivity()
        {
            string className = AssemblyName + "." + db + "Activity";
            return (IActivity)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IActivityJoin CreateActivityJoin()
        {
            string className = AssemblyName + "." + db + "ActivityJoin";
            return (IActivityJoin)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArticleComment CreateArticleComment()
        {
            string className = AssemblyName + "." + db + "ArticleComment";
            return (IArticleComment)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IArticleReply CreateArticleReply()
        {
            string className = AssemblyName + "." + db + "ArticleReply";
            return (IArticleReply)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IArtStatic CreateArtStatic()
        {
            string className = AssemblyName + "." + db + "ArtStatic";
            return (IArtStatic)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAnimeStatic CreateAnimeStatic()
        {
            string className = AssemblyName + "." + db + "AnimeStatic";
            return (IAnimeStatic)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IFriend CreateFriend()
        {
            string className = AssemblyName + "." + db + "Friend";
            return (IFriend)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IManagers CreateManagers()
        {
            string className = AssemblyName + "." + db + "Managers";
            return (IManagers)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IMessage CreateMessage()
        {
            string className = AssemblyName + "." + db + "Message";
            return (IMessage)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IMessageReply CreateMessageReply()
        {
            string className = AssemblyName + "." + db + "MessageReply";
            return (IMessageReply)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static INews CreateNews()
        {
            string className = AssemblyName + "." + db + "News";
            return (INews)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IPicComment CreatePicComment()
        {
            string className = AssemblyName + "." + db + "PicComment";
            return (IPicComment)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IPicReply CreatePicReply()
        {
            string className = AssemblyName + "." + db + "PicReply";
            return (IPicReply)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IPicStatic CreatePicStatic()
        {
            string className = AssemblyName + "." + db + "PicStatic";
            return (IPicStatic)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IPicture CreatePicture()
        {
            string className = AssemblyName + "." + db + "Picture";
            return (IPicture)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static ISourse CreateSourse()
        {
            string className = AssemblyName + "." + db + "Sourse";
            return (ISourse)Assembly.Load(AssemblyName).CreateInstance(className);

        }
        public static IUsersAttention CreateAttention()
        {
            string className = AssemblyName + "." + db + "UsersAttention";
            return (IUsersAttention)Assembly.Load(AssemblyName).CreateInstance(className);

        }

        public static IAnime CreateAnime()
        {
            string className = AssemblyName + "." + db + "Anime";
            return (IAnime)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAnimeComment CreateAnimeComment()
        {
            string className = AssemblyName + "." + db + "AnimeComment";
            return (IAnimeComment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAnimeReply CreateAnimeReply()
        {
            string className = AssemblyName + "." + db + "AnimeReply";
            return (IAnimeReply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArtCollection CreateArtCollection()
        {
            string className = AssemblyName + "." + db + "ArtCollection";
            return (IArtCollection)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
