using System;
using System.Threading;
using System.Windows.Forms;

namespace ConsumableBuy
{
    public partial class Form1 : Form
    {
        public Thread Thread;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            LoginData.Email = TbMail.Text;
            LoginData.Password = TbPassword.Text;
            LoginData.SecurityHash = TbSecurity.Text;
            LoginData.Platform = "ps3";

            login.StartLogin();

            if (AccountData.WebPhishingToken != "")
            {
                MessageBox.Show(DateTime.Now.ToLongTimeString() + @": Erfolgreich angemeldet");
            }
        }

        private void BT_start_Click(object sender, EventArgs e)
        {
            Thread = new Thread(delegate()
            {
                if (cB_art.SelectedIndex != -1)
                {
                    dG_Prices.Rows.Clear();
                    int art = cB_art.SelectedIndex;
                    SetPriceTable(art);
                    Pricecheck(art);
                }
            });
            Thread.Start();
        }

        public void SetPriceTable(int num)
        {
            if (num == 0)
            {
                dG_Prices.Rows.Add("Fitness Player Bronze", "1615614737");
                dG_Prices.Rows.Add("Fitness Player Silver", "1615614738");
                dG_Prices.Rows.Add("Fitness Player Gold", "1615614739");
                dG_Prices.Rows.Add("Fitness Player Bronze", "1615614740");
                dG_Prices.Rows.Add("Fitness Player Silver", "1615614741");
                dG_Prices.Rows.Add("Fitness Player Gold", "1615614742");
            }
            else if (num == 1)
            {
                dG_Prices.Rows.Add("Player Bronze", "1615613737");
                dG_Prices.Rows.Add("Player Silver", "1615613738");
                dG_Prices.Rows.Add("Player Gold", "1615613739");
                dG_Prices.Rows.Add("Player Rare Bronze", "1615613740");
                dG_Prices.Rows.Add("Player Rare Silver", "1615613741");
                dG_Prices.Rows.Add("Player Rare Gold", "1615613742");
            }
            else if (num == 2)
            {
            }
            else if (num == 3)
            {
            }
        }

        public void Pricecheck(int num)
        {
            if (num == 1)
            {
                EaWebApi ea = new EaWebApi();
                for (int i = 0; i < dG_Prices.Rows.Count - 1; i++)
                {

                    listBox1.Items.Add(DateTime.Now.ToLongTimeString() + ": " + i + ". Schritt gestartet");
                    dG_Prices.Rows[i].Cells[2].Value = ea.PricecheckContracts(dG_Prices.Rows[i].Cells[1].Value.ToString());
                    listBox1.Items.Add(DateTime.Now.ToLongTimeString() + ": " + i + ". Schritt beendet");
                }
            }
        }
    }
}
