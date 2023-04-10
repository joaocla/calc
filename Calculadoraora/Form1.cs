namespace Calculadoraora
{
    public partial class Form1 : Form
    {
        double store = 0;
        string operation = "";
        bool resetTxt = false;
        string lastButtonPressed = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SetResult(string eventNumber)
        {
            lastButtonPressed = eventNumber;

            if (!txt_result.Text.Contains(',') || eventNumber != ",")
            {
                if (resetTxt)
                {
                    txt_result.Text = eventNumber;
                    resetTxt = false;
                }
                else
                    txt_result.Text += eventNumber;
            }
        }

        private void Calcula(string operacao = "=")
        {
            if (!string.IsNullOrEmpty(txt_result.Text))
            {
                if (operacao != "=")
                {
                    operation = string.IsNullOrEmpty(operation) ? operacao : operation;

                    switch (operation)
                    {
                        case "+":
                            store += Convert.ToDouble(txt_result.Text);
                            break;

                        case "-":
                            if (store == 0)
                                store = Convert.ToDouble(txt_result.Text);
                            else
                                store -= Convert.ToDouble(txt_result.Text);
                            break;

                        case "*":
                            if (store == 0)
                                store = Convert.ToDouble(txt_result.Text);
                            else
                                store *= Convert.ToDouble(txt_result.Text);
                            break;

                        case "/":
                            if (store == 0)
                                store = Convert.ToDouble(txt_result.Text);
                            else
                                store /= Convert.ToDouble(txt_result.Text);
                            break;

                        default:
                            break;
                    }

                    operation = operacao;
                    lbl_store.Text = store.ToString();
                    txt_result.Text = "";
                }
                else
                {
                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = store + Convert.ToDouble(txt_result.Text);
                            break;
                        case "-":
                            result = store - Convert.ToDouble(txt_result.Text);
                            break;

                        case "*":
                            result = store * Convert.ToDouble(txt_result.Text);
                            break;

                        case "/":
                            result = store / Convert.ToDouble(txt_result.Text);
                            break;

                        default:
                            break;
                    }

                    txt_result.Text = Math.Round(result,8).ToString();
                    lbl_store.Text = "";
                    store = 0;
                    operation = "";
                    resetTxt = true;
                    lastButtonPressed = "";
                }
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "0")
                SetResult("0");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            SetResult("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            SetResult("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            SetResult("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            SetResult("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            SetResult("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            SetResult("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            SetResult("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            SetResult("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            SetResult("9");
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            Calcula("+");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            Calcula("-");
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            Calcula();
        }

        private void btn_apagaTxt_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }

        private void btn_zeraCalc_Click(object sender, EventArgs e)
        {
            lbl_store.Text = "";
            store = 0;
            operation = "";
            resetTxt = false;
        }

        private void btn_excluiCaracter_Click(object sender, EventArgs e)
        {
            if (txt_result.Text.Length > 1)
                txt_result.Text = txt_result.Text.Substring(0, txt_result.Text.Length - 1);
            else
                txt_result.Text = "0";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            Calcula("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            Calcula("/");
        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            SetResult(",");
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
            if (!txt_result.Text.Contains(',') && !string.IsNullOrEmpty(txt_result.Text))
                txt_result.Text = Convert.ToDouble(txt_result.Text).ToString();
        }
    }
}