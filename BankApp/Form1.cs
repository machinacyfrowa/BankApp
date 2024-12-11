using Newtonsoft.Json;
using System.Net.Http.Json;

namespace BankApp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The token received from the API after successful login
        /// </summary>
        public string token;
        public Form1()
        {
            InitializeComponent();
        }

        public void GetAccountData()
        {
            //to jest blibioteka do wysy³ania zapytañ http
            //i przetwarzania odpowiedzi otrzymanych z API
            HttpClient client = new HttpClient();
            //adres API - endpoint zwraca szczegó³y rachunku na podstawie tokenu
            string url = "http://localhost/bankAPI/account/details/";
            //tworzymy obiekt zawieraj¹cy token
            var data = new { token = token };
            //wysy³amy zapytanie POST do API zawieraj¹ce token
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            //wyci¹gnij z odpowiedzi dane w formacie JSON
            string json = response.Content.ReadAsStringAsync().Result;
            AccountDetailsResponse accountDetailsResponse =
                JsonConvert.DeserializeObject<AccountDetailsResponse>(json);
            Account account = accountDetailsResponse.account;
            //wypisz dane na formularzu
            AccountNameTextBox.Text = account.name;
            AccountNumberTextBox.Text = account.accountNo.ToString();
            //konweruj i dodaj walutê
            AccountAmountTextBox.Text = account.amount / 100f + " PLN";
        }

        /// <summary>
        /// Method to get account data from API and fill the form with it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshData(object sender, EventArgs e)
        {
            GetAccountData();
        }
        /// <summary>
        /// This method is invoked when the application is loaded
        /// and its used to show login form before the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                //jeœli zalogowano poprawnie to poka¿ formularz
                this.Show();
                tokenTextBox.Text = token;
            }
            else
            {
                //jeœli nie to zamknij aplikacjê
                Application.Exit();
            }
        }
        /// <summary>
        /// Method creates and shows the form for new transfer between accounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTransferButton_Click(object sender, EventArgs e)
        {
            //otwórz formularz nowego przelewu
            NewTransfer newTransfer = new NewTransfer();

            newTransfer.token = token;
            newTransfer.parent = this;
            newTransfer.source = AccountNumberTextBox.Text;

            newTransfer.ShowDialog();
            //TODO: poka¿ zaktualizowany stan konta po wykonaniu przelewu
        }

        private void TransferHistoryButton_Click(object sender, EventArgs e)
        {
            TransferHistory transferHistory = new TransferHistory();

            transferHistory.ShowDialog();
        }
    }
}
