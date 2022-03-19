namespace Strings
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            txtInput.Clear();
        }

        private void bntNumberCharac_Click(object sender, EventArgs e)
        {
            string input;
            
            input = txtInput.Text;
            //string[]  numCharac = input.Split();
            

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("There is no input");
            }
            else
            {
                lstResult.Items.Add(input + " has " + input.Length + " Characters");
            }

            

        }

        private void bntIntToString_Click(object sender, EventArgs e)
        {
            string numbers;

            numbers = Convert.ToString(txtInput.Text);
            string[] eachNumber = numbers.Split('\u002C');
            string[] stringNumber = {};


            if (string.IsNullOrEmpty(numbers))
            {
                MessageBox.Show("There is no input");
            }
            else
            {
                for (int i = 0; i < eachNumber.Length; i++)
                {
                    switch (i)
                    {
                        case 1:
                            stringNumber.Append("One");
                            break;
                        case 2:
                            stringNumber.Append("Two");
                            break;
                        case 3:
                            stringNumber.Append("Three");
                            break;
                        case 4:
                            stringNumber.Append("Four");
                            break;
                        case 5:
                            stringNumber.Append("Five");
                            break;
                        case 6:
                            stringNumber.Append("Six");
                            break;
                        case 7:
                            stringNumber.Append("Seven");
                            break;
                        case 8:
                            stringNumber.Append("Eight");
                            break;
                        case 9:
                            stringNumber.Append("Nine");
                            break;
                        case 0:
                            stringNumber.Append("Zero");
                            break;
                    }
                    lstResult.Items.Add("Result: " + stringNumber);
                }
            }
        }


        private void bntUpper_Click(object sender, EventArgs e)
        {
            string numberOfCharac, upper;


            numberOfCharac = txtInput.Text;
            upper = numberOfCharac.ToUpper();

            if (string.IsNullOrEmpty(numberOfCharac))
            {
                MessageBox.Show("There is no input");
            }
            else
            {
                lstResult.Items.Add(upper);
            }
        }

        private void bntVowel_Click(object sender, EventArgs e)
        {
            string input;
            int countVowels;

            input = txtInput.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("There is no input");
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string  c = i;
                    
                    //if (c == "a" || c == "e" || c == "i" || c == "o" || c == "u") 
                    //countVowels = +1;

                }
                //lstResult.Items.Add("Number of vowels: " + countVowels);
            }          
        }
    }
}