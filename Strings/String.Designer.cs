namespace Strings
{
    partial class String
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
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntNumberCharac = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.bntIntToString = new System.Windows.Forms.Button();
            this.bntUpper = new System.Windows.Forms.Button();
            this.bntVowel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 20;
            this.lstResult.Location = new System.Drawing.Point(74, 114);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(360, 204);
            this.lstResult.TabIndex = 11;
            this.lstResult.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 62);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(46, 20);
            this.lblInput.TabIndex = 13;
            this.lblInput.Text = "Input:";
            // 
            // bntReset
            // 
            this.bntReset.Location = new System.Drawing.Point(345, 347);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(89, 31);
            this.bntReset.TabIndex = 14;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntNumberCharac
            // 
            this.bntNumberCharac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNumberCharac.Location = new System.Drawing.Point(35, 347);
            this.bntNumberCharac.Name = "bntNumberCharac";
            this.bntNumberCharac.Size = new System.Drawing.Size(108, 56);
            this.bntNumberCharac.TabIndex = 15;
            this.bntNumberCharac.Text = "Number of Characters";
            this.bntNumberCharac.UseVisualStyleBackColor = true;
            this.bntNumberCharac.Click += new System.EventHandler(this.bntNumberCharac_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(74, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 27);
            this.txtInput.TabIndex = 16;
            // 
            // bntIntToString
            // 
            this.bntIntToString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntIntToString.Location = new System.Drawing.Point(35, 533);
            this.bntIntToString.Name = "bntIntToString";
            this.bntIntToString.Size = new System.Drawing.Size(108, 56);
            this.bntIntToString.TabIndex = 17;
            this.bntIntToString.Text = "int to String";
            this.bntIntToString.UseVisualStyleBackColor = true;
            this.bntIntToString.Click += new System.EventHandler(this.bntIntToString_Click);
            // 
            // bntUpper
            // 
            this.bntUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntUpper.Location = new System.Drawing.Point(35, 409);
            this.bntUpper.Name = "bntUpper";
            this.bntUpper.Size = new System.Drawing.Size(108, 56);
            this.bntUpper.TabIndex = 18;
            this.bntUpper.Text = "Upper";
            this.bntUpper.UseVisualStyleBackColor = true;
            this.bntUpper.Click += new System.EventHandler(this.bntUpper_Click);
            // 
            // bntVowel
            // 
            this.bntVowel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntVowel.Location = new System.Drawing.Point(35, 471);
            this.bntVowel.Name = "bntVowel";
            this.bntVowel.Size = new System.Drawing.Size(108, 56);
            this.bntVowel.TabIndex = 19;
            this.bntVowel.Text = "Vowels";
            this.bntVowel.UseVisualStyleBackColor = true;
            this.bntVowel.Click += new System.EventHandler(this.bntVowel_Click);
            // 
            // String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 698);
            this.Controls.Add(this.bntVowel);
            this.Controls.Add(this.bntUpper);
            this.Controls.Add(this.bntIntToString);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.bntNumberCharac);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lstResult);
            this.Name = "String";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lstResult;
        private Label lblInput;
        private Button bntReset;
        private Button bntNumberCharac;
        private TextBox txtInput;
        private Button bntIntToString;
        private Button bntUpper;
        private Button bntVowel;
    }
}