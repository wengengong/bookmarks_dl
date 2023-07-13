namespace song_dl
{
    using System.Diagnostics;
    using System.IO;
    using HtmlAgilityPack;

    public partial class song_dl : Form
    {
        public song_dl()
        {
            InitializeComponent();
        }

        private void songs_btn_Click(object sender, EventArgs e)
        {
            if(select_songs_list.ShowDialog() == DialogResult.OK)
            {
                songs_txt.Text = select_songs_list.FileName;
            }

        }

        private void save_to_btn_Click(object sender, EventArgs e)
        {
            if (save_to_location.ShowDialog() == DialogResult.OK)
            {
                save_to_txt.Text = save_to_location.SelectedPath;
            }
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            if (select_songs_list.FileName == "")
            {
                output_txt.Text = "No bookmarks file selected";
            }
            else if (save_to_location.SelectedPath == "")
            {
                output_txt.Text = "No \"save to\" file selected";
            }
            else 
            {
                output_txt.Text = "";
                //rip the nodes that contain the links and names we want
                var doc = new HtmlDocument();
                doc.Load(select_songs_list.FileName);
                var nodes = doc.DocumentNode.SelectNodes("//a");
                //set up process to run yt-dlp
                var process = new Process();
                process.StartInfo.FileName = "yt-dlp";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                //loop over each link and download it
                foreach (HtmlNode node in nodes)
                {
                    //get file name and stich it to the save file path
                    var file_name = node.InnerText.Replace("&#39;", "'");
                    file_name = file_name.Replace("&amp;", "&");
                    var url = node.Attributes["href"].Value;
                    String save_too_and_name = System.IO.Path.Combine(save_to_location.SelectedPath, file_name);
                    //download the song 
                    try
                    {
                        process.StartInfo.Arguments = String.Format(@"--continue --extract-audio --audio-format mp3 {1} -o ""{0}""", save_too_and_name, url);
                        process.Start();
                        string output = process.StandardOutput.ReadToEnd();
                        output_txt.Text += file_name + "   //// Done ////" + System.Environment.NewLine;
                        //wait 5 seconds so websites don't block us for spamming
                        System.Threading.Thread.Sleep(5000);
                    }
                    catch 
                    {
                        output_txt.Text += file_name + "   !!!! Failed !!!!" + System.Environment.NewLine;
                    }
                }
            }
        }
    }
}