namespace OOP_Laragon
{
    partial class Form1
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
            Lastname = new TextBox();
            Save = new Button();
            Name = new TextBox();
            SuspendLayout();
            // 
            // Lastname
            // 
            Lastname.Location = new Point(248, 189);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(295, 23);
            Lastname.TabIndex = 1;
            // 
            // Save
            // 
            Save.Location = new Point(248, 239);
            Save.Name = "Save";
            Save.Size = new Size(295, 79);
            Save.TabIndex = 2;
            Save.Text = "button1";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Name
            // 
            Name.Location = new Point(248, 123);
            Name.Name = "Name";
            Name.Size = new Size(295, 23);
            Name.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save);
            Controls.Add(Lastname);
            Controls.Add(Name);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Lastname;
        private Button Save;
        private TextBox Name;
    }
}
