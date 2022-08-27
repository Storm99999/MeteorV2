namespace DiscordSetup
{
    partial class FMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.hideOBS = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.bypOBS = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.ssedRn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.siticoneCheckBox2 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.rnbw = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rnbwChecker = new System.Windows.Forms.Timer(this.components);
            this.recovText = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.recov = new System.Windows.Forms.Label();
            this.slf = new Siticone.UI.WinForms.SiticoneButton();
            this.obs = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.siticoneButton2);
            this.panel1.Controls.Add(this.siticoneButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 0;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(708, -2);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(43, 33);
            this.siticoneButton2.TabIndex = 4;
            this.siticoneButton2.Text = "-";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(757, -2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(43, 33);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "×";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "METEOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.hideOBS);
            this.panel2.Controls.Add(this.bypOBS);
            this.panel2.Controls.Add(this.ssedRn);
            this.panel2.Controls.Add(this.siticoneCheckBox2);
            this.panel2.Controls.Add(this.rnbw);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 52);
            this.panel2.TabIndex = 1;
            // 
            // hideOBS
            // 
            this.hideOBS.AutoSize = true;
            this.hideOBS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hideOBS.CheckedState.BorderRadius = 2;
            this.hideOBS.CheckedState.BorderThickness = 0;
            this.hideOBS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hideOBS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideOBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.hideOBS.Location = new System.Drawing.Point(119, 22);
            this.hideOBS.Name = "hideOBS";
            this.hideOBS.Size = new System.Drawing.Size(107, 21);
            this.hideOBS.TabIndex = 8;
            this.hideOBS.Text = "Hide On OBS";
            this.hideOBS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hideOBS.UncheckedState.BorderRadius = 2;
            this.hideOBS.UncheckedState.BorderThickness = 0;
            this.hideOBS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hideOBS.UseVisualStyleBackColor = true;
            this.hideOBS.CheckedChanged += new System.EventHandler(this.hideOBS_CheckedChanged);
            this.hideOBS.Click += new System.EventHandler(this.hideOBS_Click);
            // 
            // bypOBS
            // 
            this.bypOBS.AutoSize = true;
            this.bypOBS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bypOBS.CheckedState.BorderRadius = 2;
            this.bypOBS.CheckedState.BorderThickness = 0;
            this.bypOBS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bypOBS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bypOBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.bypOBS.Location = new System.Drawing.Point(459, 22);
            this.bypOBS.Name = "bypOBS";
            this.bypOBS.Size = new System.Drawing.Size(92, 21);
            this.bypOBS.TabIndex = 7;
            this.bypOBS.Text = "F5 Toggler";
            this.bypOBS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bypOBS.UncheckedState.BorderRadius = 2;
            this.bypOBS.UncheckedState.BorderThickness = 0;
            this.bypOBS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bypOBS.UseVisualStyleBackColor = true;
            this.bypOBS.CheckedChanged += new System.EventHandler(this.bypOBS_CheckedChanged);
            // 
            // ssedRn
            // 
            this.ssedRn.AutoSize = true;
            this.ssedRn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ssedRn.CheckedState.BorderRadius = 2;
            this.ssedRn.CheckedState.BorderThickness = 0;
            this.ssedRn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ssedRn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssedRn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.ssedRn.Location = new System.Drawing.Point(591, 22);
            this.ssedRn.Name = "ssedRn";
            this.ssedRn.Size = new System.Drawing.Size(63, 21);
            this.ssedRn.TabIndex = 6;
            this.ssedRn.Text = "IsSS\'d";
            this.ssedRn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ssedRn.UncheckedState.BorderRadius = 2;
            this.ssedRn.UncheckedState.BorderThickness = 0;
            this.ssedRn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ssedRn.UseVisualStyleBackColor = true;
            this.ssedRn.CheckedChanged += new System.EventHandler(this.ssedRn_CheckedChanged);
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.Checked = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.siticoneCheckBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.siticoneCheckBox2.Location = new System.Drawing.Point(671, 22);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(125, 21);
            this.siticoneCheckBox2.TabIndex = 5;
            this.siticoneCheckBox2.Text = "NoTaskbarShow";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UseVisualStyleBackColor = true;
            this.siticoneCheckBox2.CheckedChanged += new System.EventHandler(this.siticoneCheckBox2_CheckedChanged);
            // 
            // rnbw
            // 
            this.rnbw.AutoSize = true;
            this.rnbw.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rnbw.CheckedState.BorderRadius = 2;
            this.rnbw.CheckedState.BorderThickness = 0;
            this.rnbw.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rnbw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnbw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.rnbw.Location = new System.Drawing.Point(12, 22);
            this.rnbw.Name = "rnbw";
            this.rnbw.Size = new System.Drawing.Size(90, 21);
            this.rnbw.TabIndex = 4;
            this.rnbw.Text = "IsRainbow";
            this.rnbw.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rnbw.UncheckedState.BorderRadius = 2;
            this.rnbw.UncheckedState.BorderThickness = 0;
            this.rnbw.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rnbw.UseVisualStyleBackColor = true;
            this.rnbw.CheckedChanged += new System.EventHandler(this.rnbw_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(347, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "SETTINGS";
            // 
            // rnbwChecker
            // 
            this.rnbwChecker.Enabled = true;
            this.rnbwChecker.Interval = 150;
            this.rnbwChecker.Tick += new System.EventHandler(this.rnbwChecker_Tick);
            // 
            // recovText
            // 
            this.recovText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.recovText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.recovText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.recovText.DefaultText = "";
            this.recovText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.recovText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.recovText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recovText.DisabledState.Parent = this.recovText;
            this.recovText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recovText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.recovText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recovText.FocusedState.Parent = this.recovText;
            this.recovText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.recovText.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recovText.HoveredState.Parent = this.recovText;
            this.recovText.Location = new System.Drawing.Point(0, 365);
            this.recovText.Name = "recovText";
            this.recovText.PasswordChar = '\0';
            this.recovText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.recovText.PlaceholderText = "Enter A Key Authentication Password So You Are Able To Get Back To Cheating AFTER" +
    " the SS.";
            this.recovText.SelectedText = "";
            this.recovText.ShadowDecoration.Parent = this.recovText;
            this.recovText.Size = new System.Drawing.Size(800, 27);
            this.recovText.TabIndex = 2;
            this.recovText.Visible = false;
            // 
            // recov
            // 
            this.recov.AutoSize = true;
            this.recov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.recov.Location = new System.Drawing.Point(277, 332);
            this.recov.Name = "recov";
            this.recov.Size = new System.Drawing.Size(226, 30);
            this.recov.TabIndex = 4;
            this.recov.Text = "ENTER RECOVERY KEY";
            this.recov.Visible = false;
            // 
            // slf
            // 
            this.slf.CheckedState.Parent = this.slf;
            this.slf.CustomImages.Parent = this.slf;
            this.slf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.slf.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            this.slf.HoveredState.Parent = this.slf;
            this.slf.Location = new System.Drawing.Point(524, 329);
            this.slf.Name = "slf";
            this.slf.ShadowDecoration.Parent = this.slf;
            this.slf.Size = new System.Drawing.Size(192, 30);
            this.slf.TabIndex = 5;
            this.slf.Text = "SELF-DESTRUCT";
            this.slf.Visible = false;
            this.slf.Click += new System.EventHandler(this.slf_Click);
            // 
            // obs
            // 
            this.obs.Enabled = true;
            this.obs.Interval = 50;
            this.obs.Tick += new System.EventHandler(this.obs_Tick);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.slf);
            this.Controls.Add(this.recov);
            this.Controls.Add(this.recovText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Panel panel2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneCheckBox rnbw;
        private Siticone.UI.WinForms.SiticoneCheckBox siticoneCheckBox2;
        private System.Windows.Forms.Timer rnbwChecker;
        private Siticone.UI.WinForms.SiticoneCheckBox ssedRn;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox recovText;
        private System.Windows.Forms.Label recov;
        private Siticone.UI.WinForms.SiticoneButton slf;
        private Siticone.UI.WinForms.SiticoneCheckBox bypOBS;
        private System.Windows.Forms.Timer obs;
        private Siticone.UI.WinForms.SiticoneCheckBox hideOBS;
    }
}