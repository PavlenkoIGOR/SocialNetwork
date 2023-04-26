using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * здесь принцип как в отправке сообщения. почти.
 * 
 */

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        MessageService messageService;
        public AddFriendView(MessageService messageService, UserService userService)
        {
            this.userService = userService;
            this.messageService = messageService;
        }

        public void Show(User user)
        {
            try
            {
                var friendUserData = new FriendUserData();

                Console.WriteLine("Введите почтовый адрес вашего друга: ");

                friendUserData.FriendEmail = Console.ReadLine();
                friendUserData.UserId = user.Id;

                this.userService.AddFriend(friendUserData);

                SuccessMessage.Show("Друг был добавлен в ваш список.");


                //отправка потенциальному другу оповещения о приудительной дружбе
                var messageSendingData = new MessageSendingData();

                
                messageSendingData.RecipientEmail = friendUserData.FriendEmail;
                                
                messageSendingData.Content = "Вас добавили в друзья!";

                messageSendingData.SenderId = user.Id; 

                messageService.SendMessage(messageSendingData);

                SuccessMessage.Show("Заявка отправлена!");

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с таким почтовым адресом не существует.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении друга.");
            }

        }
    }
}
