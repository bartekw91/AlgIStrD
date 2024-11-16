namespace ListaPudlo_Net6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Del1stBtn_Click(object sender, EventArgs e)
        {
            Lista1.Items.RemoveAt(0);
        }

        private void AddToL1Btn_Click(object sender, EventArgs e)
        {
            Lista1.Items.Add(Tekst1.Text);
            Tekst1.Clear();
        }

        private void MoveRightBtn_Click(object sender, EventArgs e)
        {
            Lista2.Items.Add(Lista1.SelectedItem);
            Lista1.Items.RemoveAt(Lista1.SelectedIndex);
        }

        private void MoveLeftBtn_Click(object sender, EventArgs e)
        {
            Lista1.Items.Add(Lista2.SelectedItem);
            Lista2.Items.RemoveAt(Lista2.SelectedIndex);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Lista1.Items.Clear();
            Lista2.Items.Clear();
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iloœæ wyst¹pieñ w liœcie 1: " + Lista1.Items.Count.ToString() +
                "\nIloœæ wyst¹pieñ w liscie 2: " + Lista2.Items.Count.ToString());
        }

        private void AddToL2Btn_Click(object sender, EventArgs e)
        {
            Lista2.Items.Add(Tekst2.Text);
            Tekst2.Clear();
        }

        private void Del1sztL2Btn_Click(object sender, EventArgs e)
        {
            Lista2.Items.RemoveAt(0);
        }
    }
}
