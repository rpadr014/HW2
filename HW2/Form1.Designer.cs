namespace HW2
{
    partial class HW2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveLocationButton = new System.Windows.Forms.Button();
            this.saveSizeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveLocationButton);
            this.groupBox1.Controls.Add(this.saveSizeButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // saveLocationButton
            // 
            this.saveLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLocationButton.CausesValidation = false;
            this.saveLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveLocationButton.Location = new System.Drawing.Point(850, 99);
            this.saveLocationButton.Name = "saveLocationButton";
            this.saveLocationButton.Size = new System.Drawing.Size(120, 23);
            this.saveLocationButton.TabIndex = 3;
            this.saveLocationButton.Text = "Save Location\r\n";
            this.saveLocationButton.UseVisualStyleBackColor = true;
            this.saveLocationButton.Click += new System.EventHandler(this.saveLocationButton_Click);
            // 
            // saveSizeButton
            // 
            this.saveSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveSizeButton.CausesValidation = false;
            this.saveSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSizeButton.Location = new System.Drawing.Point(12, 99);
            this.saveSizeButton.Name = "saveSizeButton";
            this.saveSizeButton.Size = new System.Drawing.Size(120, 23);
            this.saveSizeButton.TabIndex = 2;
            this.saveSizeButton.Text = "Save Size";
            this.saveSizeButton.UseVisualStyleBackColor = true;
            this.saveSizeButton.Click += new System.EventHandler(this.saveSizeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(850, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(984, 433);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // HW2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "HW2";
            this.Text = "HW2";
            this.Deactivate += new System.EventHandler(this.HW2_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HW2_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private TextBox textBox1;
        private Button button1;
        private ErrorProvider errorProvider1;
        private Button saveSizeButton;

        private Button saveLocationButton;
        private NotifyIcon notifyIcon1;

    }
}