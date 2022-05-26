namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;

            BackColor = Color.FromArgb(tBar_red.Value, tBar_green.Value, tBar_blue.Value);

            lbl_updown.Text = numericUpDown1.Value.ToString();
            lbl_progbar.Text = progressBar1.Value.ToString();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            lbl_progbar.Text = progressBar1.Value.ToString();


            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;


            progressBar1.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Start();

            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
                btn_progBar.Text = "Pause ProgressBar";
            else
                btn_progBar.Text = "Load ProgressBar";
        }



        private void ScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Location = new Point(hScrollBar1.Value, vScrollBar1.Value);
        }

        private void tBar_Color_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(tBar_red.Value, tBar_green.Value, tBar_blue.Value);
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbl_updown.Text = numericUpDown1.Value.ToString();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            stripStatusLabel1.Text = e.Location.ToString();
        }

        private void repositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Repository");

        }
    }
}