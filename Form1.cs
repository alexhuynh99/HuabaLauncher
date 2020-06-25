using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace HuabaLauncher
{
    public partial class Form1 : Form
    {
        private string url = "https://github.com/alexhuynh99/testClientPull/archive/master.zip";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            circularProgressBar1.Value = 0;
        }

        private async void install()
        {
            using (var client = new WebClient())
            {
                // creates event for the progress bar
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_progressed);

                // downloads the zip file to a zip archive in memory
                Uri uri = new Uri(url);
                byte[] data = await client.DownloadDataTaskAsync(uri);
                MemoryStream memoryStream = new MemoryStream(data);
                ZipArchive zipArchive = new ZipArchive(memoryStream);

                foreach (var zipEntry in zipArchive.Entries)
                {
                    if (zipEntry.Name.EndsWith(".wz"))
                    {
                        if (File.Exists(zipEntry.Name))
                        {
                            // if the file already exists, check if its different from what we downloaded
                            Stream os = File.OpenRead(zipEntry.Name);
                            byte[] original = calculate_MD5(os);
                            byte[] downloaded = calculate_MD5(zipEntry.Open());
                            os.Close();

                            // if the files are the same, there is nothing to update
                            if (original.SequenceEqual(downloaded))
                            {
                                continue;
                            }

                            // otherwise make a backup of old copy and delete
                            File.Copy(zipEntry.Name, zipEntry.Name + ".bak", true);
                        }
                        // extract the downloaded files
                        zipEntry.ExtractToFile(Directory.GetCurrentDirectory() + @"\" + zipEntry.Name, true);
                    }
                }

            }
        }

        private void download_progressed(object sender, DownloadProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;
            if (circularProgressBar1.Value == 100) {
                System.Threading.Thread.Sleep(5); 
                play_panel.BringToFront();
            }
        }

        private byte[] calculate_MD5(Stream filename) {
            using (var md5 = MD5.Create()) {
                var hash = md5.ComputeHash(filename);
                return hash;
            }
        }

        private void install_client_Click(object sender, EventArgs e)
        {
            install();
            download_panel.BringToFront();
        }

        private void play_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("test.txt");
        }

        private void website_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }
    }
}
