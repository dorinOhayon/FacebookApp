using System;

namespace FacebookAppLogic
{
    public interface ISorter
    {
        bool checkIfNeedToBeSwapped(string i_FriendName1, string i_FriendName2);
    }
}
