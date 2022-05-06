namespace jogo_memoria
{
    partial class Form1
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.lslStatus = new System.Windows.Forms.Label();
            this.lblTimerLeft = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(585, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(125, 53);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Reiniciar";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // lslStatus
            // 
            this.lslStatus.AutoSize = true;
            this.lslStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lslStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lslStatus.Location = new System.Drawing.Point(589, 167);
            this.lslStatus.Name = "lslStatus";
            this.lslStatus.Size = new System.Drawing.Size(115, 20);
            this.lslStatus.TabIndex = 1;
            this.lslStatus.Text = "Acertou e Errou:";
            this.lslStatus.Click += new System.EventHandler(this.lblStatus);
            // 
            // lblTimerLeft
            // 
            this.lblTimerLeft.AutoSize = true;
            this.lblTimerLeft.Location = new System.Drawing.Point(585, 276);
            this.lblTimerLeft.Name = "lblTimerLeft";
            this.lblTimerLeft.Size = new System.Drawing.Size(119, 20);
            this.lblTimerLeft.TabIndex = 2;
            this.lblTimerLeft.Text = "Tempo Restante:";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimerLeft);
            this.Controls.Add(this.lslStatus);
            this.Controls.Add(this.btnRestart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button btnRestart;
        private Label lslStatus;
        private Label lblTimerLeft;
        private System.Windows.Forms.Timer GameTimer;
    }
}