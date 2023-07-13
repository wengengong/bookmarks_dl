namespace song_dl
{
    partial class song_dl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songs_btn = new System.Windows.Forms.Button();
            this.save_to_btn = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.songs_txt = new System.Windows.Forms.TextBox();
            this.save_to_txt = new System.Windows.Forms.TextBox();
            this.output_txt = new System.Windows.Forms.TextBox();
            this.select_songs_list = new System.Windows.Forms.OpenFileDialog();
            this.save_to_location = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // songs_btn
            // 
            this.songs_btn.Location = new System.Drawing.Point(12, 12);
            this.songs_btn.Name = "songs_btn";
            this.songs_btn.Size = new System.Drawing.Size(75, 23);
            this.songs_btn.TabIndex = 0;
            this.songs_btn.Text = "Songs";
            this.songs_btn.UseVisualStyleBackColor = true;
            this.songs_btn.Click += new System.EventHandler(this.songs_btn_Click);
            // 
            // save_to_btn
            // 
            this.save_to_btn.Location = new System.Drawing.Point(12, 41);
            this.save_to_btn.Name = "save_to_btn";
            this.save_to_btn.Size = new System.Drawing.Size(75, 23);
            this.save_to_btn.TabIndex = 1;
            this.save_to_btn.Text = "Save to";
            this.save_to_btn.UseVisualStyleBackColor = true;
            this.save_to_btn.Click += new System.EventHandler(this.save_to_btn_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(260, 71);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(80, 23);
            this.download_btn.TabIndex = 2;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // songs_txt
            // 
            this.songs_txt.Location = new System.Drawing.Point(93, 13);
            this.songs_txt.Name = "songs_txt";
            this.songs_txt.ReadOnly = true;
            this.songs_txt.Size = new System.Drawing.Size(479, 23);
            this.songs_txt.TabIndex = 3;
            // 
            // save_to_txt
            // 
            this.save_to_txt.Location = new System.Drawing.Point(93, 42);
            this.save_to_txt.Name = "save_to_txt";
            this.save_to_txt.ReadOnly = true;
            this.save_to_txt.Size = new System.Drawing.Size(479, 23);
            this.save_to_txt.TabIndex = 4;
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(12, 100);
            this.output_txt.Multiline = true;
            this.output_txt.Name = "output_txt";
            this.output_txt.Size = new System.Drawing.Size(560, 449);
            this.output_txt.TabIndex = 5;
            // 
            // song_dl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.save_to_txt);
            this.Controls.Add(this.songs_txt);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.save_to_btn);
            this.Controls.Add(this.songs_btn);
            this.Name = "song_dl";
            this.Text = "song dl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button songs_btn;
        private Button save_to_btn;
        private Button download_btn;
        private TextBox songs_txt;
        private TextBox save_to_txt;
        private TextBox output_txt;
        private OpenFileDialog select_songs_list;
        private FolderBrowserDialog save_to_location;
    }
}