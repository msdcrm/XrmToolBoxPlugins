namespace RegisterPlugInSteps
{
    partial class RegisterPlugins
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPlugins));
            CSRichTextBoxSyntaxHighlighting.XMLViewerSettings xmlViewerSettings11 = new CSRichTextBoxSyntaxHighlighting.XMLViewerSettings();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.ofdBrowsePlugInAssembly = new System.Windows.Forms.OpenFileDialog();
            this.lblPlugInPath = new System.Windows.Forms.Label();
            this.btnAddUpdatePlugin = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rtbPlugInAssemblyPath = new System.Windows.Forms.RichTextBox();
            this.pnlAddOrUpdatePlugIn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ofdPlugInFolder = new System.Windows.Forms.OpenFileDialog();
            this.rtbAssemblyPath = new System.Windows.Forms.RichTextBox();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbSolutionName = new System.Windows.Forms.RichTextBox();
            this.btnProcessRegistration = new System.Windows.Forms.Button();
            this.lblRegistrationSteps = new System.Windows.Forms.Label();
            this.rtbRegistrationSteps = new CSRichTextBoxSyntaxHighlighting.XMLViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brnBrowsePluginAssemblyFolder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggingDetails = new System.Windows.Forms.Label();
            this.rtbLogMessages = new System.Windows.Forms.RichTextBox();
            this.toolStripMenu.SuspendLayout();
            this.pnlAddOrUpdatePlugIn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(932, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(23, 22);
            // 
            // ofdBrowsePlugInAssembly
            // 
            this.ofdBrowsePlugInAssembly.FileName = "openFileDialog1";
            // 
            // lblPlugInPath
            // 
            this.lblPlugInPath.AutoSize = true;
            this.lblPlugInPath.ForeColor = System.Drawing.Color.Brown;
            this.lblPlugInPath.Location = new System.Drawing.Point(1, 10);
            this.lblPlugInPath.Name = "lblPlugInPath";
            this.lblPlugInPath.Size = new System.Drawing.Size(127, 13);
            this.lblPlugInPath.TabIndex = 17;
            this.lblPlugInPath.Text = "Plugin Assembly Full Path";
            // 
            // btnAddUpdatePlugin
            // 
            this.btnAddUpdatePlugin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUpdatePlugin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUpdatePlugin.Location = new System.Drawing.Point(299, 90);
            this.btnAddUpdatePlugin.Name = "btnAddUpdatePlugin";
            this.btnAddUpdatePlugin.Size = new System.Drawing.Size(277, 37);
            this.btnAddUpdatePlugin.TabIndex = 16;
            this.btnAddUpdatePlugin.Text = "Add/Update PlugIn Assembly";
            this.btnAddUpdatePlugin.UseVisualStyleBackColor = true;
            this.btnAddUpdatePlugin.Click += new System.EventHandler(this.btnAddUpdatePlugin_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(794, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(111, 32);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // rtbPlugInAssemblyPath
            // 
            this.rtbPlugInAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPlugInAssemblyPath.BackColor = System.Drawing.Color.Silver;
            this.rtbPlugInAssemblyPath.Enabled = false;
            this.rtbPlugInAssemblyPath.Location = new System.Drawing.Point(4, 35);
            this.rtbPlugInAssemblyPath.Name = "rtbPlugInAssemblyPath";
            this.rtbPlugInAssemblyPath.Size = new System.Drawing.Size(784, 32);
            this.rtbPlugInAssemblyPath.TabIndex = 18;
            this.rtbPlugInAssemblyPath.Text = "";
            // 
            // pnlAddOrUpdatePlugIn
            // 
            this.pnlAddOrUpdatePlugIn.AccessibleName = "";
            this.pnlAddOrUpdatePlugIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddOrUpdatePlugIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAddOrUpdatePlugIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.btnBrowse);
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.lblPlugInPath);
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.rtbPlugInAssemblyPath);
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.btnAddUpdatePlugin);
            this.pnlAddOrUpdatePlugIn.Location = new System.Drawing.Point(3, 461);
            this.pnlAddOrUpdatePlugIn.Name = "pnlAddOrUpdatePlugIn";
            this.pnlAddOrUpdatePlugIn.Size = new System.Drawing.Size(923, 150);
            this.pnlAddOrUpdatePlugIn.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblLoggingDetails);
            this.panel2.Controls.Add(this.rtbLogMessages);
            this.panel2.Location = new System.Drawing.Point(3, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 157);
            this.panel2.TabIndex = 23;
            // 
            // rtbAssemblyPath
            // 
            this.rtbAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAssemblyPath.BackColor = System.Drawing.Color.Silver;
            this.rtbAssemblyPath.Enabled = false;
            this.rtbAssemblyPath.Location = new System.Drawing.Point(3, 237);
            this.rtbAssemblyPath.Name = "rtbAssemblyPath";
            this.rtbAssemblyPath.Size = new System.Drawing.Size(785, 32);
            this.rtbAssemblyPath.TabIndex = 13;
            this.rtbAssemblyPath.Text = "";
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Location = new System.Drawing.Point(-307, 292);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(76, 13);
            this.lblSolutionName.TabIndex = 14;
            this.lblSolutionName.Text = "Solution Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-311, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "PlugIn Assembly Folder Location";
            // 
            // rtbSolutionName
            // 
            this.rtbSolutionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSolutionName.Location = new System.Drawing.Point(3, 309);
            this.rtbSolutionName.Name = "rtbSolutionName";
            this.rtbSolutionName.Size = new System.Drawing.Size(901, 32);
            this.rtbSolutionName.TabIndex = 15;
            this.rtbSolutionName.Text = "";
            // 
            // btnProcessRegistration
            // 
            this.btnProcessRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessRegistration.Location = new System.Drawing.Point(299, 353);
            this.btnProcessRegistration.Name = "btnProcessRegistration";
            this.btnProcessRegistration.Size = new System.Drawing.Size(277, 36);
            this.btnProcessRegistration.TabIndex = 9;
            this.btnProcessRegistration.Text = "Add/Update PlugIn Assembly and Register Steps";
            this.btnProcessRegistration.UseVisualStyleBackColor = true;
            this.btnProcessRegistration.Click += new System.EventHandler(this.btnProcessRegistration_Click);
            // 
            // lblRegistrationSteps
            // 
            this.lblRegistrationSteps.AutoSize = true;
            this.lblRegistrationSteps.Location = new System.Drawing.Point(-319, -107);
            this.lblRegistrationSteps.Name = "lblRegistrationSteps";
            this.lblRegistrationSteps.Size = new System.Drawing.Size(156, 13);
            this.lblRegistrationSteps.TabIndex = 8;
            this.lblRegistrationSteps.Text = "Enter Plugin Regristration Steps";
            // 
            // rtbRegistrationSteps
            // 
            this.rtbRegistrationSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRegistrationSteps.Location = new System.Drawing.Point(4, 21);
            this.rtbRegistrationSteps.Name = "rtbRegistrationSteps";
            xmlViewerSettings11.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings11.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings11.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings11.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings11.Value = System.Drawing.Color.Black;
            this.rtbRegistrationSteps.Settings = xmlViewerSettings11;
            this.rtbRegistrationSteps.Size = new System.Drawing.Size(901, 187);
            this.rtbRegistrationSteps.TabIndex = 1;
            this.rtbRegistrationSteps.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Solution Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(3, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plugin Assembly Folder Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Plugin Registration Steps/XML";
            // 
            // brnBrowsePluginAssemblyFolder
            // 
            this.brnBrowsePluginAssemblyFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnBrowsePluginAssemblyFolder.Location = new System.Drawing.Point(794, 237);
            this.brnBrowsePluginAssemblyFolder.Name = "brnBrowsePluginAssemblyFolder";
            this.brnBrowsePluginAssemblyFolder.Size = new System.Drawing.Size(111, 32);
            this.brnBrowsePluginAssemblyFolder.TabIndex = 24;
            this.brnBrowsePluginAssemblyFolder.Text = "Browse";
            this.brnBrowsePluginAssemblyFolder.UseVisualStyleBackColor = true;
            this.brnBrowsePluginAssemblyFolder.Click += new System.EventHandler(this.brnBrowsePluginAssemblyFolder_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.brnBrowsePluginAssemblyFolder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnProcessRegistration);
            this.panel1.Controls.Add(this.rtbRegistrationSteps);
            this.panel1.Controls.Add(this.rtbSolutionName);
            this.panel1.Controls.Add(this.lblRegistrationSteps);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSolutionName);
            this.panel1.Controls.Add(this.rtbAssemblyPath);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 401);
            this.panel1.TabIndex = 1;
            // 
            // lblLoggingDetails
            // 
            this.lblLoggingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggingDetails.AutoSize = true;
            this.lblLoggingDetails.Location = new System.Drawing.Point(1, 5);
            this.lblLoggingDetails.Name = "lblLoggingDetails";
            this.lblLoggingDetails.Size = new System.Drawing.Size(80, 13);
            this.lblLoggingDetails.TabIndex = 24;
            this.lblLoggingDetails.Text = "Logging Details";
            // 
            // rtbLogMessages
            // 
            this.rtbLogMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogMessages.Location = new System.Drawing.Point(3, 24);
            this.rtbLogMessages.Name = "rtbLogMessages";
            this.rtbLogMessages.Size = new System.Drawing.Size(906, 126);
            this.rtbLogMessages.TabIndex = 25;
            this.rtbLogMessages.Text = "";
            // 
            // RegisterPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.pnlAddOrUpdatePlugIn);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterPlugins";
            this.Size = new System.Drawing.Size(932, 795);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.pnlAddOrUpdatePlugIn.ResumeLayout(false);
            this.pnlAddOrUpdatePlugIn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.OpenFileDialog ofdBrowsePlugInAssembly;
        private System.Windows.Forms.Label lblPlugInPath;
        private System.Windows.Forms.Button btnAddUpdatePlugin;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbPlugInAssemblyPath;
        private System.Windows.Forms.Panel pnlAddOrUpdatePlugIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog ofdPlugInFolder;
        private System.Windows.Forms.RichTextBox rtbAssemblyPath;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbSolutionName;
        private System.Windows.Forms.Button btnProcessRegistration;
        private System.Windows.Forms.Label lblRegistrationSteps;
        private CSRichTextBoxSyntaxHighlighting.XMLViewer rtbRegistrationSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnBrowsePluginAssemblyFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggingDetails;
        private System.Windows.Forms.RichTextBox rtbLogMessages;
    }
}
