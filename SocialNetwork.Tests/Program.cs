using NUnit.Framework;
using SocialNetwork;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL;
using SocialNetwork.PLL.Views;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class Program
    {
        static MessageService messageService = new MessageService();
        static UserService userService = new UserService();
        static MainView mainView = new MainView();
        static RegistrationView registrationView = new RegistrationView(userService);
        static AuthenticationView authenticationView = new AuthenticationView(userService);
        static UserMenuView userMenuView = new UserMenuView(userService);
        static UserInfoView userInfoView = new UserInfoView();
        static UserDataUpdateView userDataUpdateView = new UserDataUpdateView(userService);
        static MessageSendingView messageSendingView = new MessageSendingView(messageService, userService);
        static UserIncomingMessageView userIncomingMessageView = new UserIncomingMessageView();
        static UserOutcomingMessageView userOutcomingMessageView = new UserOutcomingMessageView();
        static AddFriendView friendSendingView = new AddFriendView(messageService, userService);
        static FriendsOfUserView usersFriends = new FriendsOfUserView();
        static User user = new User
            (
            50,
            "John",
            "Wick",
            "der_parol", //email
            "best_of_the_best", //password
            "photo",
            "Knock-knock",
            "twin peaks",
            default,
            default,
            default
            );

        [Test]
        public void ReturnTrueIfUserEqualsEntity()
        {
            UserEntity userEntity = new UserEntity();

            Assert.True(user.FirstName == "John");
        }
    }
}