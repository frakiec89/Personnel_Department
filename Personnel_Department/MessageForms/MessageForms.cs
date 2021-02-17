using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personnel_Department.MessageForms
{
    public static class MessageForms
    {
        /// <summary>
        /// Для удаления
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static  MessageBoxResult  MessageBoxDell (string message)
        {
            return  MessageBox.Show (message, "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }
        /// <summary>
        /// Для сообщения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static MessageBoxResult MessageBoxMessage(string message)
        {
            return MessageBox.Show(message, "Сообщение",MessageBoxButton.OK , MessageBoxImage.Information);
        }

    }
}
