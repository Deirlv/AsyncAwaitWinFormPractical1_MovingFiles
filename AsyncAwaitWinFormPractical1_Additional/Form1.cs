namespace AsyncAwaitWinFormPractical1_Additional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            await MoveFiles(textBoxSource.Text, textBoxDestination.Text);

            MessageBox.Show("Your files was moved successfully. Please check the file information.");
        }

        private async Task MoveFiles(string sourceDir, string destinationDir)
        {
            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("No source directory. Error");
                return;
            }

            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            string[] files = Directory.GetFiles(sourceDir);
            int countSource = files.Length;

            int countDestination = 0;
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string destination = Path.Combine(destinationDir, name);

                if (!File.Exists(destination))
                {
                    File.Move(file, destination);
                    countDestination++;
                }
            }

            using (StreamWriter sw = new StreamWriter("results.txt"))
            {
                sw.WriteLine($"Original files count: {countSource}\nMoved files count: {countDestination}");
            }
        }
    }
}
