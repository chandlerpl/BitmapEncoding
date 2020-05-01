using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapEncoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string encodingRunLengths(string stringCode, out Queue<int> code)
        {
            StringBuilder sb = new StringBuilder();

            char start = stringCode.First();

            sb.Append(stringCode.First());
            sb.Append(", ");

            code = new Queue<int>();
            code.Enqueue(start.Equals('0') ? 0 : 1);
            Queue<char> input = new Queue<char>(stringCode.ToCharArray());

            int currRun = 0;
            while(input.Count > 0)
            {
                char current = input.Dequeue();

                if (start.Equals(current))
                    currRun++;
                else
                {
                    code.Enqueue(currRun);
                    sb.Append(currRun);
                    sb.Append(", ");
                    currRun = 1;
                    start = current;
                }
            }
            code.Enqueue(currRun);
            sb.Append(currRun);

            return sb.ToString();
        }

        private string Encoder(Queue<int> input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input.Dequeue());

            while(input.Count > 0)
            {
                string binary = Convert.ToString(input.Dequeue(), 2);
                sb.Append(string.Concat(Enumerable.Repeat("0", binary.Length - 1)));
                sb.Append(binary);
            }

            return sb.ToString();
        }

        private string Decoder(string stringInput)
        {
            StringBuilder sb = new StringBuilder();

            Queue<char> input = new Queue<char>(stringInput.ToCharArray());
            int current = input.Dequeue().Equals('0') ? 0 : 1;

            while (input.Count > 0)
            {
                int run = 0;
                while (input.Peek().Equals('0'))
                {
                    run++;
                    input.Dequeue();
                }
                Console.WriteLine(input.Count);

                StringBuilder binarySB = new StringBuilder();
                for (int i = 0; i < run + 1; i++) binarySB.Append(input.Dequeue());
                int length = Convert.ToInt32(binarySB.ToString(), 2);
                Console.WriteLine(length);
                for (int i = 0; i < length; i++) sb.Append(current);
                current = current == 0 ? 1 : 0;
            }

            return sb.ToString();
        }

        private void encoderButton_Click(object sender, EventArgs e)
        {
            runBox.Text = encodingRunLengths(inputBox.Text, out Queue<int> runlengths);
            outputBox.Text = Encoder(runlengths);

            inputSize.Text = inputBox.Text.Length.ToString();
            outputSize.Text = outputBox.Text.Length.ToString();
            conversionRate.Text = (((outputBox.Text.Length * 1.0) / inputBox.Text.Length) * 100.0).ToString();
        }

        private void decoderButton_Click(object sender, EventArgs e)
        {
            runBox.Text = "";
            outputBox.Text = Decoder(inputBox.Text);
        }
    }
}
