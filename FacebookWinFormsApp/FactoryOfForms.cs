using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookAppLogic;


namespace FacebookWinFormsApp
{
    class FactoryOfForms
    {   
        private static readonly Dictionary<eFormType, Func<LogicManager, Form>> FormCreators = new Dictionary<eFormType, Func<LogicManager, Form>>
        {
            { eFormType.FormAlbums, logicManager => new FormAlbums(logicManager.LoggedInUser.Albums) },
            { eFormType.FormEvents, logicManager => new FormEvents(logicManager.LoggedInUser.Events) },
            { eFormType.FormFacebookFeatures, logicManager => new FormFeatures(logicManager) },
            { eFormType.FormFavoriteTeams, logicManager => new FormFavoriteTeams(logicManager.LoggedInUser.FavofriteTeams) },
            { eFormType.FormFriends, logicManager => new FormFriends(logicManager.LoggedInUser.Friends) },
            { eFormType.FormGroups, logicManager => new FormGroups(logicManager.LoggedInUser.Groups) },
            { eFormType.FormLikedPages, logicManager => new FormLikedPages(logicManager.LoggedInUser.LikedPages) },
            { eFormType.FormLogin, logicManager => new FormLogin() },
            { eFormType.FormNotAttendEvents, logicManager => new FormNotAttendEvents(logicManager.LoggedInUser.EventsNotYetReplied) },
            { eFormType.FormPosts, logicManager => new FormPosts(logicManager.LoggedInUser) },
            { eFormType.FormTwoPhotosWithMostComments, logicManager => new FormTwoPhotosWithMostComments(logicManager.LoggedInUser.PhotosTaggedIn) }            
        };

        // Create a new form based on the specified eFormType
        public static Form CreateNewForm(eFormType formType, LogicManager logicManager)
        {
            if (FormCreators.TryGetValue(formType, out var formCreator))
            {
                return formCreator(logicManager);
            }

            throw new ArgumentException("Invalid form type.", nameof(formType));
        }
    }
}

