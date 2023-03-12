namespace Calculadoraora
{
    public partial class Form1 : Form
    {
        double store = 0;
        string operation = "";
        bool resetTxt = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetResult(int eventNumber)
        {
            if (resetTxt)
            {
                txt_result.Text = eventNumber.ToString();
                resetTxt = false;
            }
            else
            {
                txt_result.Text += eventNumber.ToString();
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "0")
                SetResult(0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            SetResult(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            SetResult(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            SetResult(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            SetResult(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            SetResult(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            SetResult(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            SetResult(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            SetResult(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            SetResult(9);
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_result.Text))
                txt_result.Text = Convert.ToDouble(txt_result.Text).ToString();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_result.Text))
            {
                operation = "+";
                store += Convert.ToDouble(txt_result.Text);
                lbl_store.Text = store.ToString();
                txt_result.Text = "";
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_result.Text))
            {
                operation = "-";
                if (store == 0)
                    store = Convert.ToDouble(txt_result.Text);
                else
                    store -= Convert.ToDouble(txt_result.Text);
                lbl_store.Text = store.ToString();
                txt_result.Text = "";
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = store + Convert.ToDouble(txt_result.Text);
                    txt_result.Text = result.ToString();
                    break;
                case "-":
                    result = store - Convert.ToDouble(txt_result.Text);
                    txt_result.Text = result.ToString();
                    break;
                default:
                    break;
            }
            lbl_store.Text = "";
            store = 0;
            operation = "";
            resetTxt = true;
        }
    }
}