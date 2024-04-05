namespace wfa_hobby
{
    partial class AssocierHobbyEtudiantForm
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
            etudiantComboBox = new ComboBox();
            hobbyComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            associerHobbyButton = new Button();
            SuspendLayout();
            // 
            // etudiantComboBox
            // 
            etudiantComboBox.FormattingEnabled = true;
            etudiantComboBox.Location = new Point(75, 9);
            etudiantComboBox.Name = "etudiantComboBox";
            etudiantComboBox.Size = new Size(121, 23);
            etudiantComboBox.TabIndex = 0;
            etudiantComboBox.SelectedIndexChanged += etudiantComboBox_SelectedIndexChanged;
            // 
            // hobbyComboBox
            // 
            hobbyComboBox.FormattingEnabled = true;
            hobbyComboBox.Location = new Point(75, 38);
            hobbyComboBox.Name = "hobbyComboBox";
            hobbyComboBox.Size = new Size(121, 23);
            hobbyComboBox.TabIndex = 1;
            hobbyComboBox.SelectedIndexChanged += hobbyComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // associerHobbyButton
            // 
            associerHobbyButton.Location = new Point(75, 83);
            associerHobbyButton.Name = "associerHobbyButton";
            associerHobbyButton.Size = new Size(121, 23);
            associerHobbyButton.TabIndex = 4;
            associerHobbyButton.Text = "Associer l'hobby";
            associerHobbyButton.UseVisualStyleBackColor = true;
            // 
            // AssocierHobbyEtudiantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(associerHobbyButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hobbyComboBox);
            Controls.Add(etudiantComboBox);
            Name = "AssocierHobbyEtudiantForm";
            Text = "AssocierHobbyEtudiantForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox etudiantComboBox;
        private ComboBox hobbyComboBox;
        private Label label1;
        private Label label2;
        private Button associerHobbyButton;
    }
}