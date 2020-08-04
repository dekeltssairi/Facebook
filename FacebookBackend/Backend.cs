using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookBackend
{
    public class Backend
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public Backend()
        {
            m_LoginResult = new LoginResult();
        }

        public string Login()
        {
            LoginResult result = FacebookService.Login("343280916704350", /// (desig patter's "Design Patterns Course App 2.4" app)
                 "public_profile",
     "email",
     "publish_to_groups",
     "user_birthday",
     "user_age_range",
     "user_gender",
     "user_link",
     "user_tagged_places",
     "user_videos",
     "publish_to_groups",
     "groups_access_member_info",
     "user_friends",
     "user_events",
     "user_likes",
     "user_location",
     "user_photos",
     "user_posts",
     "user_hometown"


  );




            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                return "success";
            }
            else
            {
                return result.ErrorMessage;
            }


        }
        public void Hey()
        {
            Console.WriteLine("HEY");
        }

        public string GetLastPost()
        {
            return m_LoggedInUser.Posts[0].Message;
        }

        public string getPicutureUrl()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public int getNumOfPost()
        {
            return m_LoggedInUser.Posts.Count;
        }

    }
}

