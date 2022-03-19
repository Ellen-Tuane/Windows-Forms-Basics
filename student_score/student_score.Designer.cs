namespace student_score
{
    partial class student_score
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
            this.bntMedia = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtProva1 = new System.Windows.Forms.TextBox();
            this.lblProva1 = new System.Windows.Forms.Label();
            this.txtProva2 = new System.Windows.Forms.TextBox();
            this.lblProva2 = new System.Windows.Forms.Label();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.lstMedia = new System.Windows.Forms.ListBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.bntCleanList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntMedia
            // 
            this.bntMedia.Location = new System.Drawing.Point(25, 249);
            this.bntMedia.Name = "bntMedia";
            this.bntMedia.Size = new System.Drawing.Size(94, 34);
            this.bntMedia.TabIndex = 9;
            this.bntMedia.Text = "Media";
            this.bntMedia.UseVisualStyleBackColor = true;
            this.bntMedia.Click += new System.EventHandler(this.bntMedia_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 27);
            this.txtNome.TabIndex = 7;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(26, 45);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(50, 20);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(105, 9);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(165, 27);
            this.txtMatricula.TabIndex = 11;
            this.txtMatricula.TextChanged += new System.EventHandler(this.Matricula_TextChanged);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(25, 12);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(71, 20);
            this.lblMatricula.TabIndex = 10;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtProva1
            // 
            this.txtProva1.Location = new System.Drawing.Point(159, 75);
            this.txtProva1.Name = "txtProva1";
            this.txtProva1.Size = new System.Drawing.Size(54, 27);
            this.txtProva1.TabIndex = 13;
            // 
            // lblProva1
            // 
            this.lblProva1.AutoSize = true;
            this.lblProva1.Location = new System.Drawing.Point(25, 78);
            this.lblProva1.Name = "lblProva1";
            this.lblProva1.Size = new System.Drawing.Size(98, 20);
            this.lblProva1.TabIndex = 12;
            this.lblProva1.Text = "Nota Prova 1:";
            // 
            // txtProva2
            // 
            this.txtProva2.Location = new System.Drawing.Point(159, 104);
            this.txtProva2.Name = "txtProva2";
            this.txtProva2.Size = new System.Drawing.Size(54, 27);
            this.txtProva2.TabIndex = 15;
            // 
            // lblProva2
            // 
            this.lblProva2.AutoSize = true;
            this.lblProva2.Location = new System.Drawing.Point(25, 107);
            this.lblProva2.Name = "lblProva2";
            this.lblProva2.Size = new System.Drawing.Size(98, 20);
            this.lblProva2.TabIndex = 14;
            this.lblProva2.Text = "Nota Prova 2:";
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Location = new System.Drawing.Point(159, 133);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(54, 27);
            this.txtTrabalho.TabIndex = 17;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Location = new System.Drawing.Point(25, 140);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(119, 20);
            this.lblTrabalho.TabIndex = 16;
            this.lblTrabalho.Text = "Nota Trabalho 1:";
            // 
            // lstMedia
            // 
            this.lstMedia.FormattingEnabled = true;
            this.lstMedia.ItemHeight = 20;
            this.lstMedia.Location = new System.Drawing.Point(26, 219);
            this.lstMedia.Name = "lstMedia";
            this.lstMedia.Size = new System.Drawing.Size(175, 24);
            this.lstMedia.TabIndex = 18;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(26, 196);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(54, 20);
            this.lblMedia.TabIndex = 19;
            this.lblMedia.Text = "Média:";
            // 
            // bntCleanList
            // 
            this.bntCleanList.Location = new System.Drawing.Point(25, 300);
            this.bntCleanList.Name = "bntCleanList";
            this.bntCleanList.Size = new System.Drawing.Size(168, 35);
            this.bntCleanList.TabIndex = 20;
            this.bntCleanList.Text = "Clean all item";
            this.bntCleanList.UseVisualStyleBackColor = true;
            this.bntCleanList.Click += new System.EventHandler(this.bntCleanList_Click);
            // 
            // student_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.bntCleanList);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lstMedia);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.txtProva2);
            this.Controls.Add(this.lblProva2);
            this.Controls.Add(this.txtProva1);
            this.Controls.Add(this.lblProva1);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.bntMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Name = "student_score";
            this.Text = "Student Score";
            this.Load += new System.EventHandler(this.student_score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bntMedia;
        private TextBox txtNome;
        private Label lbNome;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private TextBox txtProva1;
        private Label lblProva1;
        private TextBox txtProva2;
        private Label lblProva2;
        private TextBox txtTrabalho;
        private Label lblTrabalho;
        private ListBox lstMedia;
        private Label lblMedia;
        private Button bntCleanList;
    }
}