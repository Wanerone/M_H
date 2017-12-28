﻿using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class SqlServerVideoComment:IVideoComment
    {
        public int addcomment_video(VideoComment comment_video)
        {
            string sql = "insert into VideoComment values(@Vid_id,@email,@ComContent,@ComTime)";
            SqlParameter[] sp = new SqlParameter[]
            {


                 new SqlParameter("@Vid_id",comment_video.Vid_id),
                  new SqlParameter("@email",comment_video.email),
                new SqlParameter("@ComContent",comment_video.ComContent),
                 new SqlParameter("@ComTime",comment_video.ComTime)

            };
            return SQLHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()
        {
            string sql = "select  a.*,b.UserName,c.Name from Comment_Video a, Users b,Video c where a.Users_id=b.Users_id and a.Video_id=c.Video_id";
            return SQLHelper.GetFillData(sql);
        }
        public DataTable SelectcoutID(int VideoComment_ID)
        {
            string sql = "select  * from VideoComment where  VideoComment_ID=@ VideoComment_ID";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@ VideoComment_ID", VideoComment_ID)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectTop(int top)
        {
            string sql = "select  top " + top + " a.*,b.userName from VideoComment a, Users b where a.email=b.email order by ComTime desc";

            return SQLHelper.GetFillData(sql);
        }

        public DataTable SelectID(int id)
        {
            string sql = "select a.*,b.userName from VideoComment a, Users b where Vid_id='" + id + "'and a.email=b.email order by ComTime";
            SqlParameter[] sp = new SqlParameter[]{
                new SqlParameter("@VideoComment_ID",id)
            };
            DataTable dt = SQLHelper.GetFillData(sql, sp);
            return dt;
        }

        public int Delete(int id)
        {
            string sql = "delete from VideoComment where VideoComment_ID='" + id + "'";
            return SQLHelper.GetExcuteNonQuery(sql);
        }

        public int CountComment()
        {
            string sql = "select count(*) from VideoComment";
            return SQLHelper.ExecuteScalar<int>(sql);
        }
    }
}
