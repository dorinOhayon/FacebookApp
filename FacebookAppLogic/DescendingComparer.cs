using System;

namespace FacebookAppLogic
{
    public class DescendingComparer : ISorter
    {
        public bool checkIfNeedToBeSwapped(string i_FriendName1, string i_FriendName2)
        {
            bool isNeedToBeSwapped;
            bool ignoreCase = true;

            if (string.Compare(i_FriendName2, i_FriendName1, ignoreCase) > 0)
            {
                isNeedToBeSwapped = true;
            }
            else
            {
                isNeedToBeSwapped = false;
            }

            return isNeedToBeSwapped;
        }
    }
}

