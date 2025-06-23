namespace TemplateRewriterTool
{
    partial class MainForm
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
            btnSelectTemplate = new Button();
            lstKeys = new ListBox();
            txtReplaceValue = new TextBox();
            rtxPreview = new RichTextBox();
            btnExport = new Button();
            SuspendLayout();
            // 
            // btnSelectTemplate
            // 
            btnSelectTemplate.Location = new Point(23, 21);
            btnSelectTemplate.Name = "btnSelectTemplate";
            btnSelectTemplate.Size = new Size(121, 23);
            btnSelectTemplate.TabIndex = 0;
            btnSelectTemplate.Text = "Chọn File template";
            btnSelectTemplate.UseVisualStyleBackColor = true;
            btnSelectTemplate.Click += btnSelectTemplate_Click;
            // 
            // lstKeys
            // 
            lstKeys.FormattingEnabled = true;
            lstKeys.ItemHeight = 15;
            lstKeys.Location = new Point(23, 66);
            lstKeys.Name = "lstKeys";
            lstKeys.Size = new Size(121, 319);
            lstKeys.TabIndex = 1;
            lstKeys.SelectedIndexChanged += lstKeys_SelectedIndexChanged;
            // 
            // txtReplaceValue
            // 
            txtReplaceValue.Location = new Point(23, 401);
            txtReplaceValue.Name = "txtReplaceValue";
            txtReplaceValue.Size = new Size(363, 23);
            txtReplaceValue.TabIndex = 2;
            txtReplaceValue.TextChanged += txtReplaceValue_TextChanged;
            // 
            // rtxPreview
            // 
            rtxPreview.Location = new Point(164, 21);
            rtxPreview.Name = "rtxPreview";
            rtxPreview.ReadOnly = true;
            rtxPreview.Size = new Size(615, 364);
            rtxPreview.TabIndex = 3;
            rtxPreview.Text = "";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(630, 401);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(149, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Xuất File";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(rtxPreview);
            Controls.Add(txtReplaceValue);
            Controls.Add(lstKeys);
            Controls.Add(btnSelectTemplate);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectTemplate;
        private ListBox lstKeys;
        private TextBox txtReplaceValue;
        private RichTextBox rtxPreview;
        private Button btnExport;
    }
}
