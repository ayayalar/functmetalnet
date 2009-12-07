namespace FunctMetaLRunner
{
    partial class FunctMetaLRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctMetaLRunner));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSuite = new System.Windows.Forms.TabPage();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsButExecute = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tsBundles = new System.Windows.Forms.ToolStripDropDownButton();
            this.coreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forLoopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.whileLoopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doWhileLoopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ifElseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.breakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabSuite.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSuite);
            this.tabControl1.Controls.Add(this.tabResult);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSuite
            // 
            this.tabSuite.Controls.Add(this.txtXml);
            this.tabSuite.Location = new System.Drawing.Point(4, 22);
            this.tabSuite.Name = "tabSuite";
            this.tabSuite.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuite.Size = new System.Drawing.Size(636, 468);
            this.tabSuite.TabIndex = 0;
            this.tabSuite.Text = "Test";
            this.tabSuite.UseVisualStyleBackColor = true;
            // 
            // txtXml
            // 
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXml.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXml.Location = new System.Drawing.Point(3, 3);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.Size = new System.Drawing.Size(630, 462);
            this.txtXml.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.txtResult);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(636, 468);
            this.tabResult.TabIndex = 1;
            this.tabResult.Text = "Result";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(630, 462);
            this.txtResult.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButExecute,
            this.tsBundles});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(668, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsButExecute
            // 
            this.tsButExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsButExecute.Image = ((System.Drawing.Image)(resources.GetObject("tsButExecute.Image")));
            this.tsButExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButExecute.Name = "tsButExecute";
            this.tsButExecute.Size = new System.Drawing.Size(23, 22);
            this.tsButExecute.Text = "Start";
            this.tsButExecute.Click += new System.EventHandler(this.tsButExecute_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play.ico");
            // 
            // tsBundles
            // 
            this.tsBundles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBundles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coreToolStripMenuItem,
            this.utilToolStripMenuItem});
            this.tsBundles.Image = ((System.Drawing.Image)(resources.GetObject("tsBundles.Image")));
            this.tsBundles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBundles.Name = "tsBundles";
            this.tsBundles.Size = new System.Drawing.Size(29, 22);
            this.tsBundles.Text = "toolStripDropDownButton1";
            // 
            // coreToolStripMenuItem
            // 
            this.coreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variableToolStripMenuItem1,
            this.arrayToolStripMenuItem1,
            this.forLoopToolStripMenuItem1,
            this.whileLoopToolStripMenuItem1,
            this.doWhileLoopToolStripMenuItem1,
            this.messageToolStripMenuItem1,
            this.switchToolStripMenuItem1,
            this.ifElseToolStripMenuItem1,
            this.breakToolStripMenuItem1,
            this.evalToolStripMenuItem1,
            this.commentToolStripMenuItem1});
            this.coreToolStripMenuItem.Name = "coreToolStripMenuItem";
            this.coreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coreToolStripMenuItem.Text = "Core";
            // 
            // variableToolStripMenuItem1
            // 
            this.variableToolStripMenuItem1.Name = "variableToolStripMenuItem1";
            this.variableToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.variableToolStripMenuItem1.Text = "Variable";
            this.variableToolStripMenuItem1.Click += new System.EventHandler(this.variableToolStripMenuItem1_Click);
            // 
            // arrayToolStripMenuItem1
            // 
            this.arrayToolStripMenuItem1.Name = "arrayToolStripMenuItem1";
            this.arrayToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.arrayToolStripMenuItem1.Text = "Array";
            this.arrayToolStripMenuItem1.Click += new System.EventHandler(this.arrayToolStripMenuItem1_Click);
            // 
            // forLoopToolStripMenuItem1
            // 
            this.forLoopToolStripMenuItem1.Name = "forLoopToolStripMenuItem1";
            this.forLoopToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.forLoopToolStripMenuItem1.Text = "For Loop";
            this.forLoopToolStripMenuItem1.Click += new System.EventHandler(this.forLoopToolStripMenuItem1_Click);
            // 
            // whileLoopToolStripMenuItem1
            // 
            this.whileLoopToolStripMenuItem1.Name = "whileLoopToolStripMenuItem1";
            this.whileLoopToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.whileLoopToolStripMenuItem1.Text = "While Loop";
            this.whileLoopToolStripMenuItem1.Click += new System.EventHandler(this.whileLoopToolStripMenuItem1_Click);
            // 
            // doWhileLoopToolStripMenuItem1
            // 
            this.doWhileLoopToolStripMenuItem1.Name = "doWhileLoopToolStripMenuItem1";
            this.doWhileLoopToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.doWhileLoopToolStripMenuItem1.Text = "Do While Loop";
            this.doWhileLoopToolStripMenuItem1.Click += new System.EventHandler(this.doWhileLoopToolStripMenuItem1_Click);
            // 
            // messageToolStripMenuItem1
            // 
            this.messageToolStripMenuItem1.Name = "messageToolStripMenuItem1";
            this.messageToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.messageToolStripMenuItem1.Text = "Message";
            this.messageToolStripMenuItem1.Click += new System.EventHandler(this.messageToolStripMenuItem1_Click);
            // 
            // switchToolStripMenuItem1
            // 
            this.switchToolStripMenuItem1.Name = "switchToolStripMenuItem1";
            this.switchToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.switchToolStripMenuItem1.Text = "Switch";
            this.switchToolStripMenuItem1.Click += new System.EventHandler(this.switchToolStripMenuItem1_Click);
            // 
            // ifElseToolStripMenuItem1
            // 
            this.ifElseToolStripMenuItem1.Name = "ifElseToolStripMenuItem1";
            this.ifElseToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.ifElseToolStripMenuItem1.Text = "If/Else";
            this.ifElseToolStripMenuItem1.Click += new System.EventHandler(this.ifElseToolStripMenuItem1_Click);
            // 
            // breakToolStripMenuItem1
            // 
            this.breakToolStripMenuItem1.Name = "breakToolStripMenuItem1";
            this.breakToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.breakToolStripMenuItem1.Text = "Break";
            this.breakToolStripMenuItem1.Click += new System.EventHandler(this.breakToolStripMenuItem1_Click);
            // 
            // evalToolStripMenuItem1
            // 
            this.evalToolStripMenuItem1.Name = "evalToolStripMenuItem1";
            this.evalToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.evalToolStripMenuItem1.Text = "Eval";
            this.evalToolStripMenuItem1.Click += new System.EventHandler(this.evalToolStripMenuItem1_Click);
            // 
            // commentToolStripMenuItem1
            // 
            this.commentToolStripMenuItem1.Name = "commentToolStripMenuItem1";
            this.commentToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.commentToolStripMenuItem1.Text = "Comment";
            this.commentToolStripMenuItem1.Click += new System.EventHandler(this.commentToolStripMenuItem1_Click);
            // 
            // utilToolStripMenuItem
            // 
            this.utilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.pluginToolStripMenuItem,
            this.processToolStripMenuItem});
            this.utilToolStripMenuItem.Name = "utilToolStripMenuItem";
            this.utilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.utilToolStripMenuItem.Text = "Util";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processToolStripMenuItem.Text = "Process";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // pluginToolStripMenuItem
            // 
            this.pluginToolStripMenuItem.Name = "pluginToolStripMenuItem";
            this.pluginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pluginToolStripMenuItem.Text = "Plugin";
            this.pluginToolStripMenuItem.Click += new System.EventHandler(this.pluginToolStripMenuItem_Click);
            // 
            // FunctMetaLRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 534);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FunctMetaLRunner";
            this.Text = "FunctMetaL Runner";
            this.tabControl1.ResumeLayout(false);
            this.tabSuite.ResumeLayout(false);
            this.tabSuite.PerformLayout();
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSuite;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsButExecute;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripDropDownButton tsBundles;
        private System.Windows.Forms.ToolStripMenuItem coreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arrayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem forLoopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem whileLoopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doWhileLoopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ifElseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem breakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
    }
}

