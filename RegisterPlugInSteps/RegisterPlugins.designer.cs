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
            CSRichTextBoxSyntaxHighlighting.XMLViewerSettings xmlViewerSettings3 = new CSRichTextBoxSyntaxHighlighting.XMLViewerSettings();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.ofdBrowsePlugInAssembly = new System.Windows.Forms.OpenFileDialog();
            this.lblRegistrationSteps = new System.Windows.Forms.Label();
            this.btnProcessRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLogMessages = new System.Windows.Forms.RichTextBox();
            this.rtbAssemblyPath = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbSolutionName = new System.Windows.Forms.RichTextBox();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.lblPlugInPath = new System.Windows.Forms.Label();
            this.btnAddUpdatePlugin = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rtbPlugInAssemblyPath = new System.Windows.Forms.RichTextBox();
            this.pnlAddOrUpdatePlugIn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brnBrowsePluginAssemblyFolder = new System.Windows.Forms.Button();
            this.ofdPlugInFolder = new System.Windows.Forms.OpenFileDialog();
            this.rtbRegistrationSteps = new CSRichTextBoxSyntaxHighlighting.XMLViewer();
            this.toolStripMenu.SuspendLayout();
            this.pnlAddOrUpdatePlugIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.toolStripMenu.Size = new System.Drawing.Size(1174, 25);
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
            // lblRegistrationSteps
            // 
            this.lblRegistrationSteps.AutoSize = true;
            this.lblRegistrationSteps.Location = new System.Drawing.Point(-319, -107);
            this.lblRegistrationSteps.Name = "lblRegistrationSteps";
            this.lblRegistrationSteps.Size = new System.Drawing.Size(156, 13);
            this.lblRegistrationSteps.TabIndex = 8;
            this.lblRegistrationSteps.Text = "Enter Plugin Regristration Steps";
            // 
            // btnProcessRegistration
            // 
            this.btnProcessRegistration.Location = new System.Drawing.Point(347, 405);
            this.btnProcessRegistration.Name = "btnProcessRegistration";
            this.btnProcessRegistration.Size = new System.Drawing.Size(253, 36);
            this.btnProcessRegistration.TabIndex = 9;
            this.btnProcessRegistration.Text = "Add/Update PlugIn Assembly and Regirster Steps";
            this.btnProcessRegistration.UseVisualStyleBackColor = true;
            this.btnProcessRegistration.Click += new System.EventHandler(this.btnProcessRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logging Details";
            // 
            // rtbLogMessages
            // 
            this.rtbLogMessages.Location = new System.Drawing.Point(6, 34);
            this.rtbLogMessages.Name = "rtbLogMessages";
            this.rtbLogMessages.Size = new System.Drawing.Size(905, 96);
            this.rtbLogMessages.TabIndex = 11;
            this.rtbLogMessages.Text = "";
            // 
            // rtbAssemblyPath
            // 
            this.rtbAssemblyPath.BackColor = System.Drawing.Color.Silver;
            this.rtbAssemblyPath.Enabled = false;
            this.rtbAssemblyPath.Location = new System.Drawing.Point(9, 290);
            this.rtbAssemblyPath.Name = "rtbAssemblyPath";
            this.rtbAssemblyPath.Size = new System.Drawing.Size(816, 32);
            this.rtbAssemblyPath.TabIndex = 13;
            this.rtbAssemblyPath.Text = "";
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
            this.rtbSolutionName.Location = new System.Drawing.Point(6, 362);
            this.rtbSolutionName.Name = "rtbSolutionName";
            this.rtbSolutionName.Size = new System.Drawing.Size(901, 32);
            this.rtbSolutionName.TabIndex = 15;
            this.rtbSolutionName.Text = "";
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
            // lblPlugInPath
            // 
            this.lblPlugInPath.AutoSize = true;
            this.lblPlugInPath.ForeColor = System.Drawing.Color.Brown;
            this.lblPlugInPath.Location = new System.Drawing.Point(3, 12);
            this.lblPlugInPath.Name = "lblPlugInPath";
            this.lblPlugInPath.Size = new System.Drawing.Size(127, 13);
            this.lblPlugInPath.TabIndex = 17;
            this.lblPlugInPath.Text = "Plugin Assembly Full Path";
            // 
            // btnAddUpdatePlugin
            // 
            this.btnAddUpdatePlugin.Location = new System.Drawing.Point(347, 84);
            this.btnAddUpdatePlugin.Name = "btnAddUpdatePlugin";
            this.btnAddUpdatePlugin.Size = new System.Drawing.Size(253, 36);
            this.btnAddUpdatePlugin.TabIndex = 16;
            this.btnAddUpdatePlugin.Text = "Add/Update PlugIn Assembly";
            this.btnAddUpdatePlugin.UseVisualStyleBackColor = true;
            this.btnAddUpdatePlugin.Click += new System.EventHandler(this.btnAddUpdatePlugin_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(830, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 32);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // rtbPlugInAssemblyPath
            // 
            this.rtbPlugInAssemblyPath.BackColor = System.Drawing.Color.Silver;
            this.rtbPlugInAssemblyPath.Enabled = false;
            this.rtbPlugInAssemblyPath.Location = new System.Drawing.Point(6, 37);
            this.rtbPlugInAssemblyPath.Name = "rtbPlugInAssemblyPath";
            this.rtbPlugInAssemblyPath.Size = new System.Drawing.Size(819, 32);
            this.rtbPlugInAssemblyPath.TabIndex = 18;
            this.rtbPlugInAssemblyPath.Text = "";
            // 
            // pnlAddOrUpdatePlugIn
            // 
            this.pnlAddOrUpdatePlugIn.AccessibleName = "";
            this.pnlAddOrUpdatePlugIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.lblPlugInPath);
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.rtbPlugInAssemblyPath);
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.btnAddUpdatePlugin);
            this.pnlAddOrUpdatePlugIn.Controls.Add(this.btnBrowse);
            this.pnlAddOrUpdatePlugIn.Location = new System.Drawing.Point(36, 542);
            this.pnlAddOrUpdatePlugIn.Name = "pnlAddOrUpdatePlugIn";
            this.pnlAddOrUpdatePlugIn.Size = new System.Drawing.Size(923, 133);
            this.pnlAddOrUpdatePlugIn.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.brnBrowsePluginAssemblyFolder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtbRegistrationSteps);
            this.panel1.Controls.Add(this.lblRegistrationSteps);
            this.panel1.Controls.Add(this.btnProcessRegistration);
            this.panel1.Controls.Add(this.rtbSolutionName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSolutionName);
            this.panel1.Controls.Add(this.rtbAssemblyPath);
            this.panel1.Location = new System.Drawing.Point(36, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 452);
            this.panel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Plugin Registration Steps/XML";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(9, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plugin Assembly Folder Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Solution Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rtbLogMessages);
            this.panel2.Location = new System.Drawing.Point(36, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 148);
            this.panel2.TabIndex = 23;
            // 
            // brnBrowsePluginAssemblyFolder
            // 
            this.brnBrowsePluginAssemblyFolder.Location = new System.Drawing.Point(832, 290);
            this.brnBrowsePluginAssemblyFolder.Name = "brnBrowsePluginAssemblyFolder";
            this.brnBrowsePluginAssemblyFolder.Size = new System.Drawing.Size(79, 32);
            this.brnBrowsePluginAssemblyFolder.TabIndex = 24;
            this.brnBrowsePluginAssemblyFolder.Text = "Browse";
            this.brnBrowsePluginAssemblyFolder.UseVisualStyleBackColor = true;
            this.brnBrowsePluginAssemblyFolder.Click += new System.EventHandler(this.brnBrowsePluginAssemblyFolder_Click);
            // 
            // rtbRegistrationSteps
            // 
            this.rtbRegistrationSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRegistrationSteps.Location = new System.Drawing.Point(10, 34);
            this.rtbRegistrationSteps.Name = "rtbRegistrationSteps";
            xmlViewerSettings3.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings3.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings3.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings3.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings3.Value = System.Drawing.Color.Black;
            this.rtbRegistrationSteps.Settings = xmlViewerSettings3;
            this.rtbRegistrationSteps.Size = new System.Drawing.Size(901, 221);
            this.rtbRegistrationSteps.TabIndex = 20;
            this.rtbRegistrationSteps.Text = "";
            // 
            // RegisterPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAddOrUpdatePlugIn);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "RegisterPlugins";
            this.Size = new System.Drawing.Size(1174, 852);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.pnlAddOrUpdatePlugIn.ResumeLayout(false);
            this.pnlAddOrUpdatePlugIn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.OpenFileDialog ofdBrowsePlugInAssembly;
        private System.Windows.Forms.Label lblRegistrationSteps;
        private System.Windows.Forms.Button btnProcessRegistration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLogMessages;
        private System.Windows.Forms.RichTextBox rtbAssemblyPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbSolutionName;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Label lblPlugInPath;
        private System.Windows.Forms.Button btnAddUpdatePlugin;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbPlugInAssemblyPath;
        private CSRichTextBoxSyntaxHighlighting.XMLViewer rtbRegistrationSteps;
        private System.Windows.Forms.Panel pnlAddOrUpdatePlugIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brnBrowsePluginAssemblyFolder;
        private System.Windows.Forms.OpenFileDialog ofdPlugInFolder;
    }
}
