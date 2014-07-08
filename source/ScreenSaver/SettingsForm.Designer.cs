namespace ScreenSaver
{
    partial class SettingsForm
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
            this.separatorTextBox = new System.Windows.Forms.TextBox();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.caretCheckBox = new System.Windows.Forms.CheckBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.sourceButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.speedLabel = new System.Windows.Forms.Label();
            this.minSpeedTextBox = new System.Windows.Forms.TextBox();
            this.maxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.speedMidLabel = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.fontButton = new System.Windows.Forms.Button();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorLabel = new System.Windows.Forms.Label();
            this.canvasLabel = new System.Windows.Forms.Label();
            this.trimCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultsButton = new System.Windows.Forms.Button();
            this.removeSourceButton = new System.Windows.Forms.Button();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.dividerTextBox = new System.Windows.Forms.TextBox();
            this.sourcesListBox = new System.Windows.Forms.ListBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.clearSourcesButton = new System.Windows.Forms.Button();
            this.colorPreviewLabel = new System.Windows.Forms.Label();
            this.canvasPreviewLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.canvasComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // separatorTextBox
            // 
            this.separatorTextBox.Location = new System.Drawing.Point(77, 85);
            this.separatorTextBox.MaxLength = 24;
            this.separatorTextBox.Name = "separatorTextBox";
            this.separatorTextBox.Size = new System.Drawing.Size(173, 20);
            this.separatorTextBox.TabIndex = 4;
            // 
            // separatorLabel
            // 
            this.separatorLabel.AutoSize = true;
            this.separatorLabel.Location = new System.Drawing.Point(10, 88);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(61, 13);
            this.separatorLabel.TabIndex = 0;
            this.separatorLabel.Text = "Separators:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(13, 283);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(173, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // caretCheckBox
            // 
            this.caretCheckBox.AutoSize = true;
            this.caretCheckBox.Location = new System.Drawing.Point(13, 260);
            this.caretCheckBox.Name = "caretCheckBox";
            this.caretCheckBox.Size = new System.Drawing.Size(101, 17);
            this.caretCheckBox.TabIndex = 15;
            this.caretCheckBox.Text = "Caret ON / OFF";
            this.caretCheckBox.UseVisualStyleBackColor = true;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(10, 14);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(49, 13);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Sources:";
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(13, 33);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(24, 22);
            this.sourceButton.TabIndex = 0;
            this.sourceButton.TabStop = false;
            this.sourceButton.Text = "+";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.sourceButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "TXT|*.txt";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Source";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(10, 113);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(42, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "Delays:";
            // 
            // minSpeedTextBox
            // 
            this.minSpeedTextBox.Location = new System.Drawing.Point(77, 110);
            this.minSpeedTextBox.MaxLength = 8;
            this.minSpeedTextBox.Name = "minSpeedTextBox";
            this.minSpeedTextBox.Size = new System.Drawing.Size(75, 20);
            this.minSpeedTextBox.TabIndex = 5;
            this.minSpeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpeedTextBox_KeyPress);
            // 
            // maxSpeedTextBox
            // 
            this.maxSpeedTextBox.Location = new System.Drawing.Point(175, 110);
            this.maxSpeedTextBox.MaxLength = 8;
            this.maxSpeedTextBox.Name = "maxSpeedTextBox";
            this.maxSpeedTextBox.Size = new System.Drawing.Size(75, 20);
            this.maxSpeedTextBox.TabIndex = 6;
            this.maxSpeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpeedTextBox_KeyPress);
            // 
            // speedMidLabel
            // 
            this.speedMidLabel.AutoSize = true;
            this.speedMidLabel.Location = new System.Drawing.Point(159, 113);
            this.speedMidLabel.Name = "speedMidLabel";
            this.speedMidLabel.Size = new System.Drawing.Size(10, 13);
            this.speedMidLabel.TabIndex = 13;
            this.speedMidLabel.Text = "-";
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(226, 134);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(24, 22);
            this.fontButton.TabIndex = 8;
            this.fontButton.TabStop = false;
            this.fontButton.Text = "...";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(10, 138);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(31, 13);
            this.fontLabel.TabIndex = 0;
            this.fontLabel.Text = "Font:";
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(77, 135);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(143, 20);
            this.fontTextBox.TabIndex = 7;
            this.fontTextBox.TabStop = false;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(10, 163);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(34, 13);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Color:";
            // 
            // canvasLabel
            // 
            this.canvasLabel.AutoSize = true;
            this.canvasLabel.Location = new System.Drawing.Point(10, 188);
            this.canvasLabel.Name = "canvasLabel";
            this.canvasLabel.Size = new System.Drawing.Size(46, 13);
            this.canvasLabel.TabIndex = 0;
            this.canvasLabel.Text = "Canvas:";
            // 
            // trimCheckBox
            // 
            this.trimCheckBox.AutoSize = true;
            this.trimCheckBox.Location = new System.Drawing.Point(13, 211);
            this.trimCheckBox.Name = "trimCheckBox";
            this.trimCheckBox.Size = new System.Drawing.Size(150, 17);
            this.trimCheckBox.TabIndex = 13;
            this.trimCheckBox.Text = "Trim + NewLine ON / OFF";
            this.trimCheckBox.UseVisualStyleBackColor = true;
            // 
            // defaultsButton
            // 
            this.defaultsButton.CausesValidation = false;
            this.defaultsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.defaultsButton.Location = new System.Drawing.Point(93, 283);
            this.defaultsButton.Name = "defaultsButton";
            this.defaultsButton.Size = new System.Drawing.Size(75, 23);
            this.defaultsButton.TabIndex = 17;
            this.defaultsButton.Text = "Defaults";
            this.defaultsButton.UseVisualStyleBackColor = true;
            this.defaultsButton.Click += new System.EventHandler(this.defaultsButton_Click);
            // 
            // removeSourceButton
            // 
            this.removeSourceButton.Location = new System.Drawing.Point(40, 33);
            this.removeSourceButton.Name = "removeSourceButton";
            this.removeSourceButton.Size = new System.Drawing.Size(24, 22);
            this.removeSourceButton.TabIndex = 1;
            this.removeSourceButton.TabStop = false;
            this.removeSourceButton.Text = "-";
            this.removeSourceButton.UseVisualStyleBackColor = true;
            this.removeSourceButton.Click += new System.EventHandler(this.removeSourceButton_Click);
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(10, 237);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(43, 13);
            this.dividerLabel.TabIndex = 0;
            this.dividerLabel.Text = "Divider:";
            // 
            // dividerTextBox
            // 
            this.dividerTextBox.Location = new System.Drawing.Point(77, 234);
            this.dividerTextBox.MaxLength = 256;
            this.dividerTextBox.Name = "dividerTextBox";
            this.dividerTextBox.Size = new System.Drawing.Size(173, 20);
            this.dividerTextBox.TabIndex = 14;
            // 
            // sourcesListBox
            // 
            this.sourcesListBox.FormattingEnabled = true;
            this.sourcesListBox.HorizontalScrollbar = true;
            this.sourcesListBox.Location = new System.Drawing.Point(77, 11);
            this.sourcesListBox.Name = "sourcesListBox";
            this.sourcesListBox.Size = new System.Drawing.Size(173, 69);
            this.sourcesListBox.TabIndex = 0;
            this.sourcesListBox.TabStop = false;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(40, 58);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(24, 22);
            this.pathButton.TabIndex = 3;
            this.pathButton.TabStop = false;
            this.pathButton.Text = "?";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // clearSourcesButton
            // 
            this.clearSourcesButton.Location = new System.Drawing.Point(13, 58);
            this.clearSourcesButton.Name = "clearSourcesButton";
            this.clearSourcesButton.Size = new System.Drawing.Size(24, 22);
            this.clearSourcesButton.TabIndex = 2;
            this.clearSourcesButton.TabStop = false;
            this.clearSourcesButton.Text = "X";
            this.clearSourcesButton.UseVisualStyleBackColor = true;
            this.clearSourcesButton.Click += new System.EventHandler(this.clearSourcesButton_Click);
            // 
            // colorPreviewLabel
            // 
            this.colorPreviewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPreviewLabel.Location = new System.Drawing.Point(227, 160);
            this.colorPreviewLabel.Name = "colorPreviewLabel";
            this.colorPreviewLabel.Size = new System.Drawing.Size(22, 20);
            this.colorPreviewLabel.TabIndex = 10;
            // 
            // canvasPreviewLabel
            // 
            this.canvasPreviewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPreviewLabel.Location = new System.Drawing.Point(227, 185);
            this.canvasPreviewLabel.Name = "canvasPreviewLabel";
            this.canvasPreviewLabel.Size = new System.Drawing.Size(22, 20);
            this.canvasPreviewLabel.TabIndex = 12;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(77, 160);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(143, 20);
            this.colorComboBox.TabIndex = 9;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // canvasComboBox
            // 
            this.canvasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.canvasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.canvasComboBox.FormattingEnabled = true;
            this.canvasComboBox.Location = new System.Drawing.Point(77, 185);
            this.canvasComboBox.Name = "canvasComboBox";
            this.canvasComboBox.Size = new System.Drawing.Size(143, 20);
            this.canvasComboBox.TabIndex = 11;
            this.canvasComboBox.SelectedIndexChanged += new System.EventHandler(this.canvasComboBox_SelectedIndexChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 315);
            this.Controls.Add(this.canvasComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.canvasPreviewLabel);
            this.Controls.Add(this.colorPreviewLabel);
            this.Controls.Add(this.clearSourcesButton);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.sourcesListBox);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.dividerTextBox);
            this.Controls.Add(this.removeSourceButton);
            this.Controls.Add(this.defaultsButton);
            this.Controls.Add(this.trimCheckBox);
            this.Controls.Add(this.canvasLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.fontLabel);
            this.Controls.Add(this.fontTextBox);
            this.Controls.Add(this.speedMidLabel);
            this.Controls.Add(this.maxSpeedTextBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.minSpeedTextBox);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.caretCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.separatorTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phosphorus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox separatorTextBox;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox caretCheckBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox minSpeedTextBox;
        private System.Windows.Forms.TextBox maxSpeedTextBox;
        private System.Windows.Forms.Label speedMidLabel;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label canvasLabel;
        private System.Windows.Forms.CheckBox trimCheckBox;
        private System.Windows.Forms.Button defaultsButton;
        private System.Windows.Forms.Button removeSourceButton;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.TextBox dividerTextBox;
        private System.Windows.Forms.ListBox sourcesListBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Button clearSourcesButton;
        private System.Windows.Forms.Label colorPreviewLabel;
        private System.Windows.Forms.Label canvasPreviewLabel;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.ComboBox canvasComboBox;
    }
}