namespace Lab_percent_calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDrinkVolume = new System.Windows.Forms.Label();
            this.labelAlcoholVolume = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxContainerCount = new System.Windows.Forms.TextBox();
            this.textBoxAlcoholPercentage = new System.Windows.Forms.TextBox();
            this.textBoxContainerSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wielkość naczynia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alkohol: (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość naczyń:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Objętość płynu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Objętość alkoholu:";
            // 
            // labelDrinkVolume
            // 
            this.labelDrinkVolume.AutoSize = true;
            this.labelDrinkVolume.Location = new System.Drawing.Point(147, 189);
            this.labelDrinkVolume.Name = "labelDrinkVolume";
            this.labelDrinkVolume.Size = new System.Drawing.Size(0, 17);
            this.labelDrinkVolume.TabIndex = 8;
            // 
            // labelAlcoholVolume
            // 
            this.labelAlcoholVolume.AutoSize = true;
            this.labelAlcoholVolume.Location = new System.Drawing.Point(147, 217);
            this.labelAlcoholVolume.Name = "labelAlcoholVolume";
            this.labelAlcoholVolume.Size = new System.Drawing.Size(0, 17);
            this.labelAlcoholVolume.TabIndex = 9;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(95, 262);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxContainerCount
            // 
            this.textBoxContainerCount.Location = new System.Drawing.Point(147, 129);
            this.textBoxContainerCount.Name = "textBoxContainerCount";
            this.textBoxContainerCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxContainerCount.TabIndex = 2;
            // 
            // textBoxAlcoholPercentage
            // 
            this.textBoxAlcoholPercentage.Location = new System.Drawing.Point(147, 101);
            this.textBoxAlcoholPercentage.Name = "textBoxAlcoholPercentage";
            this.textBoxAlcoholPercentage.Size = new System.Drawing.Size(100, 22);
            this.textBoxAlcoholPercentage.TabIndex = 1;
            // 
            // textBoxContainerSize
            // 
            this.textBoxContainerSize.Location = new System.Drawing.Point(147, 73);
            this.textBoxContainerSize.Name = "textBoxContainerSize";
            this.textBoxContainerSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxContainerSize.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelAlcoholVolume);
            this.Controls.Add(this.labelDrinkVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContainerCount);
            this.Controls.Add(this.textBoxAlcoholPercentage);
            this.Controls.Add(this.textBoxContainerSize);
            this.Name = "Form1";
            this.Text = "Alcohol percentage calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDrinkVolume;
        private System.Windows.Forms.Label labelAlcoholVolume;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxContainerCount;
        private System.Windows.Forms.TextBox textBoxAlcoholPercentage;
        private System.Windows.Forms.TextBox textBoxContainerSize;
    }
}

