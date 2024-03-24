using System.Windows;

namespace taskManagerWPF.Views
{
    public partial class InputDialog : Window
    {
        public string Answer { get; private set; }

        public InputDialog(string title, string question, string defaultAnswer = "")
        {
            InitializeComponent();

            Title = title;
            QuestionTextBlock.Text = question;
            AnswerTextBox.Text = defaultAnswer;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Answer = AnswerTextBox.Text;
            DialogResult = true;
        }
    }
}
