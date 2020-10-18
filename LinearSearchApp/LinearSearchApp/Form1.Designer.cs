namespace LinearSearchApp
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
            this.ListofNumbers = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.Fillbutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.TextBox();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListofNumbers
            // 
            this.ListofNumbers.FormattingEnabled = true;
            this.ListofNumbers.Location = new System.Drawing.Point(12, 12);
            this.ListofNumbers.Name = "ListofNumbers";
            this.ListofNumbers.Size = new System.Drawing.Size(221, 511);
            this.ListofNumbers.TabIndex = 0;
            this.ListofNumbers.SelectedIndexChanged += new System.EventHandler(this.ListofNumbers_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(732, 354);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(105, 60);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Fillbutton
            // 
            this.Fillbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fillbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fillbutton.Location = new System.Drawing.Point(732, 270);
            this.Fillbutton.Name = "Fillbutton";
            this.Fillbutton.Size = new System.Drawing.Size(105, 60);
            this.Fillbutton.TabIndex = 2;
            this.Fillbutton.Text = "Fill list";
            this.Fillbutton.UseVisualStyleBackColor = false;
            this.Fillbutton.Click += new System.EventHandler(this.Fillbutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(732, 438);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 60);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResult
            // 
            this.searchResult.Location = new System.Drawing.Point(346, 207);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(365, 20);
            this.searchResult.TabIndex = 5;
            this.searchResult.TextChanged += new System.EventHandler(this.searchResult_TextChanged);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(346, 79);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(365, 20);
            this.searchInput.TabIndex = 6;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Search Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LinearSearchApp.Properties.Resources.Hello_Kitty_Background_Wallpaper;
            this.ClientSize = new System.Drawing.Size(890, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.Fillbutton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ListofNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListofNumbers;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button Fillbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchResult;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

