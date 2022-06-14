namespace Pomodoro_Novo
{
    public partial class Form1 : Form
    {
        private int totalDeSegundos;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label3.Text = "00:00";
            this.button2.Enabled = false;

            for (int i = 0; i < 61; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.comboBox1.Enabled = false;
            this.comboBox2.Enabled = false;

            int minutos = int.Parse(comboBox1.SelectedItem.ToString());
            int segundos = int.Parse(comboBox2.SelectedItem.ToString());

            totalDeSegundos = (minutos * 60) + segundos;

            this.timer1.Enabled = true;

           // for (int i = 0; i < timer1.Interval; i++)
            {
                
            }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;

            this.timer1.Enabled = false;
            totalDeSegundos = 0;
            this.label3.Text = "00:00";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalDeSegundos > 0)
            {
                int minutos = (totalDeSegundos / 60);
                int segundos = (totalDeSegundos - (minutos * 60));
                this.label3.Text = minutos.ToString() + ":" + segundos.ToString();
                totalDeSegundos--;
            }
            else
            {
                this.timer1.Enabled = false;
                new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav").Play();
                System.Media.SystemSounds.Hand.Play();
                this.WindowState = FormWindowState.Normal;
                MessageBox.Show("Pomodoro Concluido!");
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
                

                //@"C:\Windows\Media\Alarm01.wav");
                // conclusão
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmi_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmi_tempo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label3.Text);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioBtton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 25;
            this.comboBox2.SelectedIndex = 0;
            checkBox1.Checked = false;
            button1.Focus();
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 40;
            this.comboBox2.SelectedIndex = 0;
            checkBox2.Checked = false;
            button1.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 60;
            this.comboBox2.SelectedIndex = 0;
            checkBox3.Checked = false;
            button1.Focus();
        }
    }
} 