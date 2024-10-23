using Newtonsoft.Json;

namespace BankApp
{
    public partial class Form1 : Form
    {
        public string token;
        public Form1()
        {
            InitializeComponent();
        }


        private void GetAccountData(object sender, EventArgs e)
        {
            //to jest blibioteka do wysy³ania zapytañ http
            //i przetwarzania odpowiedzi otrzymanych z API
            HttpClient client = new HttpClient();
            //adres API
            string url = "http://localhost/bankAPI/account/";
            //dopisz numer konta z textboxa do adresu API
            url += AccountNoTextBox.Text;
            //wysy³amy zapytanie GET do API
            HttpResponseMessage response = client.GetAsync(url).Result;
            //wyci¹gnij z odpowiedzi dane w formacie JSON
            string json = response.Content.ReadAsStringAsync().Result;
            Account account = JsonConvert.DeserializeObject<Account>(json);
            //wypisz dane na formularzu
            AccountNameTextBox.Text = account.name;
            AccountNumberTextBox.Text = account.accountNo.ToString();
            AccountAmountTextBox.Text = account.amount.ToString();

        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if(loginForm.ShowDialog(this) == DialogResult.OK)
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
    }
}
