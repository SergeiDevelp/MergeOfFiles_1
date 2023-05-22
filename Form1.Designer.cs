namespace MergeOfFiles_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRU_Source = new System.Windows.Forms.Button();
            this.btnENG_Source = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnRU_Source
            // 
            this.btnRU_Source.Location = new System.Drawing.Point(581, 71);
            this.btnRU_Source.Name = "btnRU_Source";
            this.btnRU_Source.Size = new System.Drawing.Size(88, 23);
            this.btnRU_Source.TabIndex = 1;
            this.btnRU_Source.Text = "source _RU";
            this.btnRU_Source.UseVisualStyleBackColor = true;
            this.btnRU_Source.Click += new System.EventHandler(this.btnRU_Source_Click);
            // 
            // btnENG_Source
            // 
            this.btnENG_Source.Location = new System.Drawing.Point(581, 151);
            this.btnENG_Source.Name = "btnENG_Source";
            this.btnENG_Source.Size = new System.Drawing.Size(88, 23);
            this.btnENG_Source.TabIndex = 3;
            this.btnENG_Source.Text = "source _ENG";
            this.btnENG_Source.UseVisualStyleBackColor = true;
            this.btnENG_Source.Click += new System.EventHandler(this.btnENG_Source_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(473, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnENG_Source);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnRU_Source);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Merge of files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRU_Source;
        private System.Windows.Forms.Button btnENG_Source;
        private System.Windows.Forms.TextBox textBox2;
    }
}

