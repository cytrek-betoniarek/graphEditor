
namespace graphEditor
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.editionGroupBox = new System.Windows.Forms.GroupBox();
            this.editionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.graphColorButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.removeVertexButton = new System.Windows.Forms.Button();
            this.removeGraphButton = new System.Windows.Forms.Button();
            this.graphColorFramingPanel = new System.Windows.Forms.Panel();
            this.graphColorPanel = new System.Windows.Forms.Panel();
            this.backgroundColorFramingPanel = new System.Windows.Forms.Panel();
            this.backgroundColorPanel = new System.Windows.Forms.Panel();
            this.importExportGroupBox = new System.Windows.Forms.GroupBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.graphColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainTableLayoutPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.editionGroupBox.SuspendLayout();
            this.editionTableLayoutPanel.SuspendLayout();
            this.graphColorFramingPanel.SuspendLayout();
            this.backgroundColorFramingPanel.SuspendLayout();
            this.importExportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.Teal;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainTableLayoutPanel.Controls.Add(this.leftPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.editionGroupBox, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.importExportGroupBox, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(1173, 670);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Silver;
            this.leftPanel.Controls.Add(this.pictureBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(4, 3);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leftPanel.Name = "leftPanel";
            this.mainTableLayoutPanel.SetRowSpan(this.leftPanel, 3);
            this.leftPanel.Size = new System.Drawing.Size(965, 664);
            this.leftPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(965, 664);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // editionGroupBox
            // 
            this.editionGroupBox.Controls.Add(this.editionTableLayoutPanel);
            this.editionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editionGroupBox.Location = new System.Drawing.Point(977, 3);
            this.editionGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editionGroupBox.Name = "editionGroupBox";
            this.editionGroupBox.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.mainTableLayoutPanel.SetRowSpan(this.editionGroupBox, 2);
            this.editionGroupBox.Size = new System.Drawing.Size(192, 524);
            this.editionGroupBox.TabIndex = 1;
            this.editionGroupBox.TabStop = false;
            this.editionGroupBox.Text = "Edition";
            // 
            // editionTableLayoutPanel
            // 
            this.editionTableLayoutPanel.ColumnCount = 2;
            this.editionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.editionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.editionTableLayoutPanel.Controls.Add(this.graphColorButton, 0, 0);
            this.editionTableLayoutPanel.Controls.Add(this.backgroundColorButton, 0, 1);
            this.editionTableLayoutPanel.Controls.Add(this.removeVertexButton, 0, 2);
            this.editionTableLayoutPanel.Controls.Add(this.removeGraphButton, 0, 3);
            this.editionTableLayoutPanel.Controls.Add(this.graphColorFramingPanel, 1, 0);
            this.editionTableLayoutPanel.Controls.Add(this.backgroundColorFramingPanel, 1, 1);
            this.editionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editionTableLayoutPanel.Location = new System.Drawing.Point(30, 19);
            this.editionTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editionTableLayoutPanel.Name = "editionTableLayoutPanel";
            this.editionTableLayoutPanel.RowCount = 4;
            this.editionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.editionTableLayoutPanel.Size = new System.Drawing.Size(132, 213);
            this.editionTableLayoutPanel.TabIndex = 0;
            // 
            // graphColorButton
            // 
            this.graphColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphColorButton.Location = new System.Drawing.Point(4, 3);
            this.graphColorButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.graphColorButton.Name = "graphColorButton";
            this.graphColorButton.Size = new System.Drawing.Size(84, 40);
            this.graphColorButton.TabIndex = 0;
            this.graphColorButton.Text = "&Graph color";
            this.graphColorButton.UseVisualStyleBackColor = true;
            this.graphColorButton.Click += new System.EventHandler(this.graphColorButton_Click);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundColorButton.Location = new System.Drawing.Point(4, 56);
            this.backgroundColorButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(84, 40);
            this.backgroundColorButton.TabIndex = 1;
            this.backgroundColorButton.Text = "&Background color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // removeVertexButton
            // 
            this.editionTableLayoutPanel.SetColumnSpan(this.removeVertexButton, 2);
            this.removeVertexButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeVertexButton.Enabled = false;
            this.removeVertexButton.Location = new System.Drawing.Point(4, 109);
            this.removeVertexButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.removeVertexButton.Name = "removeVertexButton";
            this.removeVertexButton.Size = new System.Drawing.Size(124, 40);
            this.removeVertexButton.TabIndex = 2;
            this.removeVertexButton.Text = "&Remove vertex";
            this.removeVertexButton.UseVisualStyleBackColor = true;
            this.removeVertexButton.Click += new System.EventHandler(this.removeVertexButton_Click);
            // 
            // removeGraphButton
            // 
            this.editionTableLayoutPanel.SetColumnSpan(this.removeGraphButton, 2);
            this.removeGraphButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeGraphButton.Location = new System.Drawing.Point(4, 162);
            this.removeGraphButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.removeGraphButton.Name = "removeGraphButton";
            this.removeGraphButton.Size = new System.Drawing.Size(124, 41);
            this.removeGraphButton.TabIndex = 3;
            this.removeGraphButton.Text = "R&emove graph";
            this.removeGraphButton.UseVisualStyleBackColor = true;
            this.removeGraphButton.Click += new System.EventHandler(this.removeGraphButton_Click);
            // 
            // graphColorFramingPanel
            // 
            this.graphColorFramingPanel.BackColor = System.Drawing.Color.White;
            this.graphColorFramingPanel.Controls.Add(this.graphColorPanel);
            this.graphColorFramingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphColorFramingPanel.Location = new System.Drawing.Point(96, 3);
            this.graphColorFramingPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.graphColorFramingPanel.Name = "graphColorFramingPanel";
            this.graphColorFramingPanel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graphColorFramingPanel.Size = new System.Drawing.Size(32, 40);
            this.graphColorFramingPanel.TabIndex = 4;
            // 
            // graphColorPanel
            // 
            this.graphColorPanel.BackColor = System.Drawing.Color.Black;
            this.graphColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphColorPanel.Location = new System.Drawing.Point(4, 3);
            this.graphColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.graphColorPanel.Name = "graphColorPanel";
            this.graphColorPanel.Size = new System.Drawing.Size(24, 34);
            this.graphColorPanel.TabIndex = 0;
            // 
            // backgroundColorFramingPanel
            // 
            this.backgroundColorFramingPanel.BackColor = System.Drawing.Color.Black;
            this.backgroundColorFramingPanel.Controls.Add(this.backgroundColorPanel);
            this.backgroundColorFramingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundColorFramingPanel.Location = new System.Drawing.Point(96, 56);
            this.backgroundColorFramingPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 10);
            this.backgroundColorFramingPanel.Name = "backgroundColorFramingPanel";
            this.backgroundColorFramingPanel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backgroundColorFramingPanel.Size = new System.Drawing.Size(32, 40);
            this.backgroundColorFramingPanel.TabIndex = 5;
            // 
            // backgroundColorPanel
            // 
            this.backgroundColorPanel.BackColor = System.Drawing.Color.White;
            this.backgroundColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundColorPanel.Location = new System.Drawing.Point(4, 3);
            this.backgroundColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backgroundColorPanel.Name = "backgroundColorPanel";
            this.backgroundColorPanel.Size = new System.Drawing.Size(24, 34);
            this.backgroundColorPanel.TabIndex = 0;
            // 
            // importExportGroupBox
            // 
            this.importExportGroupBox.Controls.Add(this.exportButton);
            this.importExportGroupBox.Controls.Add(this.importButton);
            this.importExportGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importExportGroupBox.Location = new System.Drawing.Point(977, 533);
            this.importExportGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importExportGroupBox.Name = "importExportGroupBox";
            this.importExportGroupBox.Padding = new System.Windows.Forms.Padding(30, 10, 30, 15);
            this.importExportGroupBox.Size = new System.Drawing.Size(192, 134);
            this.importExportGroupBox.TabIndex = 3;
            this.importExportGroupBox.TabStop = false;
            this.importExportGroupBox.Text = "Import/Export";
            // 
            // exportButton
            // 
            this.exportButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exportButton.Location = new System.Drawing.Point(30, 79);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(132, 40);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "E&xport";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.importButton.Location = new System.Drawing.Point(30, 26);
            this.importButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(132, 40);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "&Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // backgroundColorDialog
            // 
            this.backgroundColorDialog.Color = System.Drawing.Color.White;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 670);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(726, 562);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.editionGroupBox.ResumeLayout(false);
            this.editionTableLayoutPanel.ResumeLayout(false);
            this.graphColorFramingPanel.ResumeLayout(false);
            this.backgroundColorFramingPanel.ResumeLayout(false);
            this.importExportGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox editionGroupBox;
        private System.Windows.Forms.TableLayoutPanel editionTableLayoutPanel;
        private System.Windows.Forms.Button graphColorButton;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button removeVertexButton;
        private System.Windows.Forms.Button removeGraphButton;
        private System.Windows.Forms.Panel graphColorFramingPanel;
        private System.Windows.Forms.Panel backgroundColorFramingPanel;
        private System.Windows.Forms.GroupBox importExportGroupBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Panel graphColorPanel;
        private System.Windows.Forms.Panel backgroundColorPanel;
        private System.Windows.Forms.ColorDialog graphColorDialog;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;
    }
}

