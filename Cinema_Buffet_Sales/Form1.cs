namespace Cinema_Buffet_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0; // global alan,  
        private void button1_Click(object sender, EventArgs e)
        {

            int popcorn, ticket, water, tea, total;


            popcorn = Convert.ToInt16(TxtMisir.Text);
            ticket = Convert.ToInt16(TxtBilet.Text);
            water = Convert.ToInt16(TxtSu.Text);
            tea = Convert.ToInt16(TxtCay.Text);

            total = popcorn * 4 + ticket * 8 + water * 1 + tea * 2;
            LblToplam.Text = total.ToString();

            kasatutar += total;
            LblKasa.Text = kasatutar.ToString() + " TL";




        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";

        }
    }
}
