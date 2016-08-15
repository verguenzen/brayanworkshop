namespace proyectoGame
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
            this.lblNeutralColor = new System.Windows.Forms.Label();
            this.lblErrorColor = new System.Windows.Forms.Label();
            this.lblAciertoColor = new System.Windows.Forms.Label();
            this.lblNeutral = new System.Windows.Forms.Label();
            this.lblFallos = new System.Windows.Forms.Label();
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblColorMatch = new System.Windows.Forms.Label();
            this.lblPositionMatch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNeutralColor
            // 
            this.lblNeutralColor.AutoSize = true;
            this.lblNeutralColor.Location = new System.Drawing.Point(397, 142);
            this.lblNeutralColor.Name = "lblNeutralColor";
            this.lblNeutralColor.Size = new System.Drawing.Size(13, 13);
            this.lblNeutralColor.TabIndex = 59;
            this.lblNeutralColor.Text = "0";
            // 
            // lblErrorColor
            // 
            this.lblErrorColor.AutoSize = true;
            this.lblErrorColor.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColor.Location = new System.Drawing.Point(397, 258);
            this.lblErrorColor.Name = "lblErrorColor";
            this.lblErrorColor.Size = new System.Drawing.Size(13, 13);
            this.lblErrorColor.TabIndex = 58;
            this.lblErrorColor.Text = "0";
            // 
            // lblAciertoColor
            // 
            this.lblAciertoColor.AutoSize = true;
            this.lblAciertoColor.ForeColor = System.Drawing.Color.Green;
            this.lblAciertoColor.Location = new System.Drawing.Point(398, 42);
            this.lblAciertoColor.Name = "lblAciertoColor";
            this.lblAciertoColor.Size = new System.Drawing.Size(13, 13);
            this.lblAciertoColor.TabIndex = 57;
            this.lblAciertoColor.Text = "0";
            // 
            // lblNeutral
            // 
            this.lblNeutral.AutoSize = true;
            this.lblNeutral.Location = new System.Drawing.Point(18, 142);
            this.lblNeutral.Name = "lblNeutral";
            this.lblNeutral.Size = new System.Drawing.Size(13, 13);
            this.lblNeutral.TabIndex = 52;
            this.lblNeutral.Text = "0";
            // 
            // lblFallos
            // 
            this.lblFallos.AutoSize = true;
            this.lblFallos.ForeColor = System.Drawing.Color.Red;
            this.lblFallos.Location = new System.Drawing.Point(18, 258);
            this.lblFallos.Name = "lblFallos";
            this.lblFallos.Size = new System.Drawing.Size(13, 13);
            this.lblFallos.TabIndex = 51;
            this.lblFallos.Text = "0";
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.ForeColor = System.Drawing.Color.Green;
            this.lblAciertos.Location = new System.Drawing.Point(19, 42);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(13, 13);
            this.lblAciertos.TabIndex = 50;
            this.lblAciertos.Text = "0";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Location = new System.Drawing.Point(211, 13);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(13, 13);
            this.lblTrial.TabIndex = 49;
            this.lblTrial.Text = "0";
            // 
            // lblColorMatch
            // 
            this.lblColorMatch.AutoSize = true;
            this.lblColorMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorMatch.Location = new System.Drawing.Point(269, 307);
            this.lblColorMatch.Name = "lblColorMatch";
            this.lblColorMatch.Size = new System.Drawing.Size(167, 29);
            this.lblColorMatch.TabIndex = 46;
            this.lblColorMatch.Text = "L: Color Match";
            // 
            // lblPositionMatch
            // 
            this.lblPositionMatch.AutoSize = true;
            this.lblPositionMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionMatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPositionMatch.Location = new System.Drawing.Point(12, 307);
            this.lblPositionMatch.Name = "lblPositionMatch";
            this.lblPositionMatch.Size = new System.Drawing.Size(197, 29);
            this.lblPositionMatch.TabIndex = 45;
            this.lblPositionMatch.Text = "A: Position Match";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(65, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 252);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(155, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 110);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(155, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 110);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 110);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(7, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 110);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 347);
            this.Controls.Add(this.lblNeutralColor);
            this.Controls.Add(this.lblErrorColor);
            this.Controls.Add(this.lblAciertoColor);
            this.Controls.Add(this.lblNeutral);
            this.Controls.Add(this.lblFallos);
            this.Controls.Add(this.lblAciertos);
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.lblColorMatch);
            this.Controls.Add(this.lblPositionMatch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Game";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNeutralColor;
        private System.Windows.Forms.Label lblErrorColor;
        private System.Windows.Forms.Label lblAciertoColor;
        private System.Windows.Forms.Label lblNeutral;
        private System.Windows.Forms.Label lblFallos;
        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblColorMatch;
        private System.Windows.Forms.Label lblPositionMatch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

