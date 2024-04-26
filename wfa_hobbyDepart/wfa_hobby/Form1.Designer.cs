namespace wfa_hobby
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            debuterBouton = new Button();
            codePostalTextBox = new TextBox();
            textBox2 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 47);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Code Postal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 94);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // debuterBouton
            // 
            debuterBouton.Location = new Point(166, 133);
            debuterBouton.Name = "debuterBouton";
            debuterBouton.Size = new Size(135, 23);
            debuterBouton.TabIndex = 2;
            debuterBouton.Text = "Faire le programme";
            debuterBouton.UseVisualStyleBackColor = true;
            // 
            // codePostalTextBox
            // 
            codePostalTextBox.Location = new Point(184, 44);
            codePostalTextBox.Name = "codePostalTextBox";
            codePostalTextBox.Size = new Size(100, 23);
            codePostalTextBox.TabIndex = 3;
            codePostalTextBox.Validating += codePostalTextBox_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(codePostalTextBox);
            Controls.Add(debuterBouton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button debuterBouton;
        private TextBox codePostalTextBox;
        private TextBox textBox2;
        private ErrorProvider errorProvider1;
    }
}