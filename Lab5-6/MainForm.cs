using System;
using System.IO;
using System.Windows.Forms;


namespace Lab5_6
{
    public partial class mainForm : Form
    {
        private  string path;
        private string text;
        string key= "<RSAKeyValue><Modulus>0Pd/qHAxAGtUmK1Cgu9RiTqAS79mLG2dT58LgW/oxoXihpe9Jv9N6bCTRrJp83XHJLknek50NXFb2AgoC7Fb8Jwh0XK2Ha08nyDEjwG0e3oq49mTjimQKolBEmeg5J+nd5y8GG725OwFFKqOfo2HhVbwAIWm5nTh2t6MZkWNBCU=</Modulus><Exponent>AQAB</Exponent><P>3SVP1RVIYt/iNQnAiewBf7A95pdeDacLc0VvBdKkU5aYO+dNwHdgBb7BIe2NBf75vhtOSvz9KE9DIY6ZfpJLtw==</P><Q>8ebLt4OptncP2PbnVkzrzl9/4PlRYHJN+MRgehZo6Lkde/i6ZsGksUXBkJm3u0yBY91vg2/zz8mVTEz3fJznAw==</Q><DP>2sNxUMon/F+bR3ppNEb6SJVQ9s5gZUMNKa/TH0B7/JBp8kBjgvTUUXqdVXHIYtkTt0MN1VKlIH4gW47UOwh/yw==</DP><DQ>erHemElO1n7Tae/p7Kr9W+KygRDURsATbl9ks+gT9B6Ypt3E5gPIHiZMhKSDPZwTcOzK9/bbyoPrlxTe3rTSsw==</DQ><InverseQ>T10Vnakomhqo/TARvhU4JCsVIvN6S69TtR53gM33LVMP2k+PTwac4W0eS3G9f5LZRlhs2WeZZ57OjUkgKQLqQQ==</InverseQ><D>Es/1Qii3gJ4pA4W1kywQXxZRLoCQpjdIDj73PjPg9N5gwlUuxi/9x6gJ2jd9qllUEE5K64vckmMeLZiuYj8ZU6pK5hFNVvr9llM2J7yv7uCxoP/GGl8uFy1WKEPMHSvoXqBH339V7LVY08tMezuTvCeAixULtroBLqMOiGUlhRE=</D></RSAKeyValue>";
        Files files = new Files();


        public mainForm()
        {
            InitializeComponent();
            An();
        }
        private void Error()
        {
            MessageBox.Show("Please, write text");
        }
      
        private void An()
        {
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 25;
            timer.Start();
        }

 



        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
        
                path = saveFileDialog.FileName;               
                tWay.Text = path;              
            }
            text = tFileText.Text;
            files.WriteFile(path, text);
            tFileText.Text = null;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            path = null;
            tWay.Text = path;
            tFileText.Text = null;                     
        }


        private void bOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                tWay.Text = path;
                tFileText.Text = text;
            }
            else
            {
                openFileDialog.CheckFileExists = false;
            }
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tWay.Text == String.Empty)
            {
                Error();
            }
            else
            {
                text = files.ReadFile(path);
                tFileText.Text = text;
            }
           
        }

        private void decompressionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tWay.Text == String.Empty)
            {
                Error();
            }
            else
            {
                string pathDempr = @"D:\StudiesProject\C#\Lab5-6\Lab5-6\Lab5-6\files\decompr.txt";
                files.DecompressFile(path);            
            }
        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tWay.Text == String.Empty)
            {
                Error();
            }
            else
            {
                files.Decrypt(path, key);
            }
        }

        private void compressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tWay.Text == String.Empty)
            {
                Error();
            }
            else
            {              
                files.ComprFile(path);  
                files.ResultCompr(path);            
            }
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tWay.Text == String.Empty)
            {
                Error();
            }
            else
            {     
                files.Encrypt(path,key);
            }
        }

        private void tWay_TextChanged(object sender, EventArgs e)
        {
            path = tWay.Text;
        }
    }
}
