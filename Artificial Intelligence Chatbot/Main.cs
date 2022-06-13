using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;
using System.Speech;
using System.Speech.Synthesis;
namespace Artificial_Intelligence_Chatbot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GetBotResponse();
        }

        public void GetBotResponse()
        {
            Bot AI = new Bot();
            AI.loadSettings(); 
            AI.loadAIMLFromFiles(); 
            AI.isAcceptingUserInput = false; 
            User myuser = new User("Username Here", AI); 
            AI.isAcceptingUserInput = true; 
            Request r = new Request(InputBox.Text, myuser, AI); 
            Result res = AI.Chat(r); 
            OutputBox.Text = "James: " + res.Output; 
          
            
            SpeechSynthesizer reader = new SpeechSynthesizer(); 
            reader.Speak(res.Output); 

        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                GetBotResponse();
                e.Handled = e.SuppressKeyPress = true; 
            }
        }
    }
}
