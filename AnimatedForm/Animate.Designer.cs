namespace AnimatedForm
{
    partial class Animate
    {
        private System.ComponentModel.IContainer components = null;

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
            this.increasesize1 = new System.Windows.Forms.Button();
            this.decreasesize1 = new System.Windows.Forms.Button();
            this.testlabel = new System.Windows.Forms.Label();
            this.normalsize1 = new System.Windows.Forms.Button();
            this.sped = new System.Windows.Forms.TrackBar();
            this.slower = new System.Windows.Forms.Label();
            this.faster = new System.Windows.Forms.Label();
            this.normaler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sped)).BeginInit();
            this.SuspendLayout();
            // 
            // increasesize1
            // 
            this.increasesize1.Location = new System.Drawing.Point(78, 12);
            this.increasesize1.Name = "increasesize1";
            this.increasesize1.Size = new System.Drawing.Size(47, 23);
            this.increasesize1.TabIndex = 0;
            this.increasesize1.Text = "GROE";
            this.increasesize1.UseVisualStyleBackColor = true;
            this.increasesize1.Click += new System.EventHandler(this.increasesize1_Click);
            // 
            // decreasesize1
            // 
            this.decreasesize1.Location = new System.Drawing.Point(22, 12);
            this.decreasesize1.Name = "decreasesize1";
            this.decreasesize1.Size = new System.Drawing.Size(50, 23);
            this.decreasesize1.TabIndex = 1;
            this.decreasesize1.Text = "SRINK";
            this.decreasesize1.UseVisualStyleBackColor = true;
            this.decreasesize1.Click += new System.EventHandler(this.decreasesize1_Click);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(396, 308);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(61, 13);
            this.testlabel.TabIndex = 2;
            this.testlabel.Text = "CHEATER!";
            // 
            // normalsize1
            // 
            this.normalsize1.Location = new System.Drawing.Point(131, 12);
            this.normalsize1.Name = "normalsize1";
            this.normalsize1.Size = new System.Drawing.Size(57, 23);
            this.normalsize1.TabIndex = 3;
            this.normalsize1.Text = "DEFOLT";
            this.normalsize1.UseVisualStyleBackColor = true;
            this.normalsize1.Click += new System.EventHandler(this.normalsize1_Click);
            // 
            // sped
            // 
            this.sped.Location = new System.Drawing.Point(22, 42);
            this.sped.Maximum = 32;
            this.sped.Minimum = 1;
            this.sped.Name = "sped";
            this.sped.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sped.Size = new System.Drawing.Size(166, 45);
            this.sped.TabIndex = 4;
            this.sped.TickFrequency = 8;
            this.sped.Value = 1;
            // 
            // slower
            // 
            this.slower.AutoSize = true;
            this.slower.Location = new System.Drawing.Point(19, 74);
            this.slower.Name = "slower";
            this.slower.Size = new System.Drawing.Size(50, 13);
            this.slower.TabIndex = 5;
            this.slower.Text = "SLOPOK";
            // 
            // faster
            // 
            this.faster.AutoSize = true;
            this.faster.Location = new System.Drawing.Point(143, 74);
            this.faster.Name = "faster";
            this.faster.Size = new System.Drawing.Size(45, 13);
            this.faster.TabIndex = 6;
            this.faster.Text = "SHADO";
            // 
            // normaler
            // 
            this.normaler.AutoSize = true;
            this.normaler.Location = new System.Drawing.Point(81, 74);
            this.normaler.Name = "normaler";
            this.normaler.Size = new System.Drawing.Size(44, 13);
            this.normaler.TabIndex = 7;
            this.normaler.Text = "AVERG";
            // 
            // Animate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 204);
            this.Controls.Add(this.normaler);
            this.Controls.Add(this.faster);
            this.Controls.Add(this.slower);
            this.Controls.Add(this.sped);
            this.Controls.Add(this.normalsize1);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.decreasesize1);
            this.Controls.Add(this.increasesize1);
            this.Name = "Animate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example";
            ((System.ComponentModel.ISupportInitialize)(this.sped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button increasesize1;
        private System.Windows.Forms.Button decreasesize1;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.Button normalsize1;
        private System.Windows.Forms.TrackBar sped;
        private System.Windows.Forms.Label slower;
        private System.Windows.Forms.Label faster;
        private System.Windows.Forms.Label normaler;
    }
}

