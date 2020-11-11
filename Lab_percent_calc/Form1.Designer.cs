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
            this.labelErrors = new System.Windows.Forms.Label();
            this.comboBoxGlasses = new System.Windows.Forms.ComboBox();
            this.comboBoxAlcohols = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wielkość naczynia: (ml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alkohol: (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość naczyń:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Objętość płynu: (ml)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Objętość alkoholu: (ml)";
            // 
            // labelDrinkVolume
            // 
            this.labelDrinkVolume.AutoSize = true;
            this.labelDrinkVolume.Location = new System.Drawing.Point(189, 145);
            this.labelDrinkVolume.Name = "labelDrinkVolume";
            this.labelDrinkVolume.Size = new System.Drawing.Size(0, 17);
            this.labelDrinkVolume.TabIndex = 8;
            // 
            // labelAlcoholVolume
            // 
            this.labelAlcoholVolume.AutoSize = true;
            this.labelAlcoholVolume.Location = new System.Drawing.Point(189, 173);
            this.labelAlcoholVolume.Name = "labelAlcoholVolume";
            this.labelAlcoholVolume.Size = new System.Drawing.Size(0, 17);
            this.labelAlcoholVolume.TabIndex = 9;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(314, 145);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(121, 44);
            this.buttonCalculate.TabIndex = 10;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxContainerCount
            // 
            this.textBoxContainerCount.Location = new System.Drawing.Point(192, 91);
            this.textBoxContainerCount.Name = "textBoxContainerCount";
            this.textBoxContainerCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxContainerCount.TabIndex = 2;
            // 
            // textBoxAlcoholPercentage
            // 
            this.textBoxAlcoholPercentage.Location = new System.Drawing.Point(192, 63);
            this.textBoxAlcoholPercentage.Name = "textBoxAlcoholPercentage";
            this.textBoxAlcoholPercentage.Size = new System.Drawing.Size(100, 22);
            this.textBoxAlcoholPercentage.TabIndex = 1;
            // 
            // textBoxContainerSize
            // 
            this.textBoxContainerSize.Location = new System.Drawing.Point(192, 35);
            this.textBoxContainerSize.Name = "textBoxContainerSize";
            this.textBoxContainerSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxContainerSize.TabIndex = 0;
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Location = new System.Drawing.Point(12, 13);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 17);
            this.labelErrors.TabIndex = 11;
            // 
            // comboBoxGlasses
            // 
            this.comboBoxGlasses.FormattingEnabled = true;
            this.comboBoxGlasses.Location = new System.Drawing.Point(314, 33);
            this.comboBoxGlasses.Name = "comboBoxGlasses";
            this.comboBoxGlasses.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGlasses.TabIndex = 12;
            this.comboBoxGlasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxGlasses_SelectedIndexChanged);
            // 
            // comboBoxAlcohols
            // 
            this.comboBoxAlcohols.FormattingEnabled = true;
            this.comboBoxAlcohols.Location = new System.Drawing.Point(314, 61);
            this.comboBoxAlcohols.Name = "comboBoxAlcohols";
            this.comboBoxAlcohols.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAlcohols.TabIndex = 13;
            this.comboBoxAlcohols.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlcohols_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 215);
            this.Controls.Add(this.comboBoxAlcohols);
            this.Controls.Add(this.comboBoxGlasses);
            this.Controls.Add(this.labelErrors);
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
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.ComboBox comboBoxGlasses;
        private System.Windows.Forms.ComboBox comboBoxAlcohols;
    }
}

