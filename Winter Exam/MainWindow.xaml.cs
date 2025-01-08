//https://github.com/PaddyMcL/Winter-Exam-object-oriented-programming.git
// I got the github created and added you as a collaberator but was unable to push the project from visual studio for a while as I had to configure my account
// and it didn't tell me or give me the option until nearer the end of the exam which is why it is only one big push of all my code rather than in stages.

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Winter_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // To allow the user to purchase a ticket and lower the avaliability by the amount of tickets purchased
        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            tblkNumberOfTickets.Visibility = Visibility.Visible;
            if (tblkNumberOfTickets != null)
            {
                int ticketAmount = int.Parse(tblkNumberOfTickets);
                AvaliableTickets = AvaliableTickets - ticketAmount;
                MessageBox.Show($"Ticket succesfully ordered, Avaliable Tickets remaining {AvaliableTickets}");
            }
            else
            {
                MessageBox.Show("Please input ticket quantity required");
            }
        }

        //Refactored method
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Display();
        }

        //Pull code from the event and ticket class to display in the Event listbox and Tickets listbox
        private void Display()
        {
            lbxEvents.ItemsSource = Event().ToString();
            lbxTickets.ItemsSource = Ticket().ToString();
        }

        //Search function for events, removes the other name of event
        private void tblkSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (tblkSearch.Text == "Oasis Croke Park".ToLower())
            { 
                lbxEvents.TextInput = tblkSearch.Text.Remove();
            }
            else if (tblkSearch.Text == "Electric Picnic".ToLower())
            {
                lbxEvents.TextInput = tblkSearch.Text.Remove();
            }
            else
            {
                Display();
            }
        }
    }
}