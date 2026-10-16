namespace Zadania_09._10._2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btt_Click(object sender, EventArgs e)
        {
            int[] tablica = Sortowanie.Konwertuj(tb.Text);
            Sortowanie.Babelkowe(tablica);
            MessageBox.Show(String.Join(", ", tablica));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var metody = typeof(Sortowanie).GetMethods()
                .Where(m => m.GetParameters().Length == 1
                         && m.GetParameters().First().ParameterType == typeof(int[])
                         && m.ReturnType == typeof(void)
                         && m.IsStatic)
                .ToArray();
            cb.DataSource = metody;
            cb.DisplayMember = "Name";
        }
    }
}