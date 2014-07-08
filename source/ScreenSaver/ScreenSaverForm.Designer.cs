namespace ScreenSaver
{
    partial class ScreenSaverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.writeTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox = new ScreenSaver.CustomTextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Consolas", 24F);
            this.textBox.ForeColor = System.Drawing.Color.Lime;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox.Size = new System.Drawing.Size(800, 600);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.textBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // ScreenSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaverForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScreenSaverForm_FormClosing);
            this.Load += new System.EventHandler(this.ScreenSaverForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenSaverForm_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaverForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer writeTimer;
        private CustomTextBox textBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

