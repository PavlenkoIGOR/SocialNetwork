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

            Assert.True(userEntity.firstname == "John");
        }
    }
}