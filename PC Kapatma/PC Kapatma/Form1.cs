using System.Diagnostics;

namespace PC_Kapatma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int dakika = Convert.ToInt16(numericUpDown1.Text) * 60;
            if (numericUpDown1.Text == "0")
            {
                DialogResult dialogResult = MessageBox.Show("PC Hemen Kapat�lacak Onayl�yor Musunuz", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start("shutdown", " -s -t 0");
                }
                else
                {
                    MessageBox.Show("��lem Kullan�c� Taraf�ndan �ptal Edildi","Uyar�",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                System.Diagnostics.Process.Start("shutdown", " -s -t " + dakika);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", " -a");
        }
    }
}
