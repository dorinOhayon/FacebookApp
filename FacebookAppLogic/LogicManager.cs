using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
    public sealed class LogicManager
    {
        private static volatile LogicManager _instance;
        private static object _lockObject = new object();
        public User LoggedInUser { get; set; }
        public LoginResult LoginResult { get; set; }


        private LogicManager()
        {
            // Private constructor to prevent instantiation.
        }

        public static LogicManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new LogicManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void LoginToFacebook()
        {
            LoginResult = FacebookService.Login(
                  "1634326403644567",
                  "email",
                  "public_profile",
                  "user_age_range",
                  "user_birthday",
                  "user_events",
                  "user_friends",
                  "user_gender",
                  "user_hometown",
                  "user_likes",
                  "user_link",
                  "user_location",
                  "user_photos",
                  "user_posts",
                  "user_videos",
                  "groups_access_member_info",
                  "publish_to_groups",
                  "pages_manage_posts"
              );


            if (IsLoginResultAccessTokenNullOrEmpty())
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception("Login Failed!");
            }
        }

        public bool IsLoginResultAccessTokenNullOrEmpty()
        {
            return (!string.IsNullOrEmpty(LoginResult?.AccessToken));
        }

        public void LogoutFromFacebook()
        {
            FacebookService.LogoutWithUI();
            LoginResult = null;
        }
    }
}

