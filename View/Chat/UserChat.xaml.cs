using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wisapp.View.Chat
{
    /// <summary>
    /// Interação lógica para UserChat.xam
    /// </summary>
    public partial class UserChat : UserControl
    {
        public UserChat()
        {
            InitializeComponent();
        }

        public void SubirMensagens()
        {
            string UserMessage;
            UserMessage = UserTextBox.ToString();
            TxbFriend3.Text = TxbFriend2.Text;
            TxbFriend2.Text = TxbFriend1.Text;            
            TxbFriend1.Text = "yES";
        }

        private void BotaoEnviarMensagem_Click(object sender, RoutedEventArgs e)
        {
            SubirMensagens();
        }
    }
}
