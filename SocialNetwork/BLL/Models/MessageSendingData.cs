using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * класс, отвечающий за просмотр отправленных сообщений
 */

namespace SocialNetwork.BLL.Models
{
    public class MessageSendingData
    {
        public int SenderId { get; set; }   //ID отправителя
        public string? Content { get; set; } //тело сообщения
        public string? RecipientEmail { get; set; }  //почтовый адрес получателя
    }
}
