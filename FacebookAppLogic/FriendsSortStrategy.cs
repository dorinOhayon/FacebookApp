using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FriendsSortStrategy
    {
        public ISorter SorterComparer { get; set; }
    
        public FriendsSortStrategy()
        {
        }

        public void SortUserFriendsList(FacebookObjectCollection<User> io_FriendsList)
        {
            for (int t = io_FriendsList.Count / 2; t > 0; t /= 2)
            {
                for (int i = t; i < io_FriendsList.Count; i++)
                {
                    for (int j = i - t; j >= 0; j -= t)
                    {
                        if (SorterComparer.checkIfNeedToBeSwapped(io_FriendsList[j].Name, io_FriendsList[j + t].Name))
                        {
                            doFriendsSwap(io_FriendsList, j, j + t);
                        }
                    }
                }
            }
        }

        private void doFriendsSwap(FacebookObjectCollection<User> freindsList, int i, int j) // - לבדוק
        {
            User temp = freindsList[i];
            freindsList[i] = freindsList[j];
            freindsList[j] = temp;
        }
    }
}
