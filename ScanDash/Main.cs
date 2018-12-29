using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ScanDash
{
    public partial class Main : Form
    {
        public static int highDpi = 600;
        public static int mediumDpi = 300;
        public static int lowDpi = 200;

        public static int highJpeg = 100;
        public static int mediumJpeg = 75;
        public static int lowJpeg = 50;

        private readonly double timeoutSeconds = 6;

        public static string suffix = "_";

        enum Levels {
            HIGH,
            MEDIUM,
            LOW
        }


        enum colorType
        {
            COLOR,
            GRAY,
            BW
        }

        Dictionary<Enum, int> dpiQuality = new Dictionary<Enum, int>() {
            { Levels.HIGH, highDpi },
            { Levels.MEDIUM, mediumDpi },
            { Levels.LOW, lowDpi }
        };

        Dictionary<Enum, int> jpegQuality = new Dictionary<Enum, int>() {
            { Levels.HIGH, highJpeg },
            { Levels.MEDIUM, mediumJpeg },
            { Levels.LOW, lowJpeg }
        };
       

        public Main()
        {
            InitializeComponent();
            this.path.Text = Properties.Settings.Default.lastPath;
            this.filename.Text = Properties.Settings.Default.lastFilename;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SelectFolderButton(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
           
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                var folderName = dialog.SelectedPath;
                this.path.Text = folderName+@"\";
                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void executeScript(int jpeg, int dpi, Enum colorType, bool adfEnabled)
        {
            if (!verifyPathAndFilename()) {
                return;
            }
            string quiet = "-q";
            string path = this.path.Text;
            string filename = generateFilename(path, this.filename.Text);
            string completePath = path + filename;
            string boolResult = adfEnabled ? "1" : "0";
            string strCmdText = $"/C cmdTwain {quiet} -c \"DPI {dpi} {colorType.ToString()} ADF {boolResult}\" {jpeg} {completePath}.jpg";
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private string generateFilename(string path, string filename)
        {
            string[] fileArray = Directory.GetFiles(path, $"{filename}*.jpg");
            var numbers = fileArray.Select(name => int.Parse(name.Substring(name.LastIndexOf("_") + 1, name.LastIndexOf(".") - name.LastIndexOf("_") - 1))).ToArray();
      
            if (numbers.Length == 0) {
                return filename+suffix + "1";
            } else {
                return filename+suffix + (numbers.Max() + 1).ToString();
            }
        }

        private bool verifyPathAndFilename()
        {
            if (this.path.Text != "" && this.filename.Text != "") {
                Properties.Settings.Default.lastFilename = this.filename.Text;
                Properties.Settings.Default.lastPath = this.path.Text;
                Properties.Settings.Default.Save();
                fieldValidationWarning.Visible = false;
                return true;
            } else {
                fieldValidationWarning.Text = Properties.Resources.blankTextMsg;
                fieldValidationWarning.Visible = true;
                return false;
            }
               
        }

        private void Flatbed_Bw_Low(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.LOW, out int jpeg);
            dpiQuality.TryGetValue(Levels.LOW, out int dpi);
            executeScript(jpeg, dpi, colorType.BW, false);
        }

        private void Adf_Color_Low_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.LOW, out int jpeg);
            dpiQuality.TryGetValue(Levels.LOW, out int dpi);
            executeScript(jpeg, dpi, colorType.COLOR, true);
        }

        private void Flatbed_Bw_High_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.HIGH, out int jpeg);
            dpiQuality.TryGetValue(Levels.HIGH, out int dpi);
            executeScript(jpeg, dpi, colorType.BW, false);
        }

        private void Flatbed_Grayscale_High_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.HIGH, out int jpeg);
            dpiQuality.TryGetValue(Levels.HIGH, out int dpi);
            executeScript(jpeg, dpi, colorType.GRAY, false);
        }

        private void Flatbed_Color_High_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.HIGH, out int jpeg);
            dpiQuality.TryGetValue(Levels.HIGH, out int dpi);
            executeScript(jpeg, dpi, colorType.COLOR, false);
        }

        private void Flatbed_Bw_Medium_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.MEDIUM, out int jpeg);
            dpiQuality.TryGetValue(Levels.MEDIUM, out int dpi);
            executeScript(jpeg, dpi, colorType.BW, false);
        }

        private void Flatbed_Grayscale_Medium_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.MEDIUM, out int jpeg);
            dpiQuality.TryGetValue(Levels.MEDIUM, out int dpi);
            executeScript(jpeg, dpi, colorType.GRAY, false);
        }

        private void Flatbed_Color_Medium_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.MEDIUM, out int jpeg);
            dpiQuality.TryGetValue(Levels.MEDIUM, out int dpi);
            executeScript(jpeg, dpi, colorType.COLOR, false);
        }

        private void Flatbed_Grayscale_Low_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.LOW, out int jpeg);
            dpiQuality.TryGetValue(Levels.LOW, out int dpi);
            executeScript(jpeg, dpi, colorType.GRAY, false);
        }

        private void Flatbed_Color_Low_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.LOW, out int jpeg);
            dpiQuality.TryGetValue(Levels.LOW, out int dpi);
            executeScript(jpeg, dpi, colorType.COLOR, false);
        }

        private void Adf_Bw_High_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.HIGH, out int jpeg);
            dpiQuality.TryGetValue(Levels.HIGH, out int dpi);
            executeScript(jpeg, dpi, colorType.BW, true);
        }

        private void Adf_Grayscale_High_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.HIGH, out int jpeg);
            dpiQuality.TryGetValue(Levels.HIGH, out int dpi);
            executeScript(jpeg, dpi, colorType.GRAY, true);
        }

        private void Adf_Color_High_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.HIGH, out int jpeg);
            dpiQuality.TryGetValue(Levels.HIGH, out int dpi);
            executeScript(jpeg, dpi, colorType.COLOR, true);
        }

        private void Adf_Bw_Medium_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.MEDIUM, out int jpeg);
            dpiQuality.TryGetValue(Levels.MEDIUM, out int dpi);
            executeScript(jpeg, dpi, colorType.BW, true);
        }

        private void Adf_Grayscale_Medium_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.MEDIUM, out int jpeg);
            dpiQuality.TryGetValue(Levels.MEDIUM, out int dpi);
            executeScript(jpeg, dpi, colorType.GRAY, true);
        }

        private void Adf_Color_Medium_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.MEDIUM, out int jpeg);
            dpiQuality.TryGetValue(Levels.MEDIUM, out int dpi);
            executeScript(jpeg, dpi, colorType.COLOR, true);
        }

        private void Adf_Bw_Low_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.LOW, out int jpeg);
            dpiQuality.TryGetValue(Levels.LOW, out int dpi);
            executeScript(jpeg, dpi, colorType.BW, true);
        }

        private void Adf_Grayscale_Low_Click(object sender, EventArgs e)
        {
            jpegQuality.TryGetValue(Levels.LOW, out int jpeg);
            dpiQuality.TryGetValue(Levels.LOW, out int dpi);
            executeScript(jpeg, dpi, colorType.GRAY, true);
        }

        private void ExecuteAdmin(string arguments)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "CMD.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.Verb = "runas";
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
        }

        private void restartService(object sender, EventArgs e)
        {
           
            try {
                fieldValidationWarning.Text = Properties.Resources.restartingServiceMsg;
                fieldValidationWarning.Visible = true;
                ExecuteAdmin($"/C net stop stisvc & timeout {timeoutSeconds} & net start stisvc");

                fieldValidationWarning.Visible = false;
            }
            catch {
                Console.WriteLine("Something happened with the Service Restarting");
                fieldValidationWarning.Visible = false;
            }
        }
    }
}
