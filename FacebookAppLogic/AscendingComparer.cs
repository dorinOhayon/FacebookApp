using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class AscendingComparer : ISorter
    {
        public bool checkIfNeedToBeSwapped(string i_FriendName1, string i_FriendName2)
        {
            bool isNeedToBeSwapped;
            bool ignoreCase = true;

            if (string.Compare(i_FriendName1, i_FriendName2, ignoreCase) > 0)
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
