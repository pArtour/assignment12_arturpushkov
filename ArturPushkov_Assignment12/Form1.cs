namespace ArturPushkov_Assignment12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameTxt.Text;
            int id = Convert.ToInt32(IdTxt.Text);
            int shift = Convert.ToInt32(ShiftTxt.Text);
            decimal pay = Convert.ToDecimal(PayTxt.Text);

            Productive worker = new Productive(name, id, shift, pay);
            ResultTxt.Text =  worker.ToString();
        }
    }
}