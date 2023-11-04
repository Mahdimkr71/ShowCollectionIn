namespace ShowCollectionIn
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
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FisrtNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.Label();
            this.PeopleGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(306, 235);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(79, 20);
            this.AgeTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Age";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(306, 209);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(79, 20);
            this.LastNameTextBox.TabIndex = 12;
            // 
            // FisrtNameTextBox
            // 
            this.FisrtNameTextBox.Location = new System.Drawing.Point(306, 183);
            this.FisrtNameTextBox.Name = "FisrtNameTextBox";
            this.FisrtNameTextBox.Size = new System.Drawing.Size(79, 20);
            this.FisrtNameTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lastname";
            // 
            // Firstname
            // 
            this.Firstname.AutoSize = true;
            this.Firstname.Location = new System.Drawing.Point(248, 183);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(52, 13);
            this.Firstname.TabIndex = 9;
            this.Firstname.Text = "Firstname";
            // 
            // PeopleGridView
            // 
            this.PeopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridView.Location = new System.Drawing.Point(12, 12);
            this.PeopleGridView.Name = "PeopleGridView";
            this.PeopleGridView.Size = new System.Drawing.Size(572, 150);
            this.PeopleGridView.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 317);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FisrtNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.PeopleGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FisrtNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Firstname;
        private System.Windows.Forms.DataGridView PeopleGridView;
    }
}

