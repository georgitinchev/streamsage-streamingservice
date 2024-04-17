namespace Animals2
{
    partial class AnimalsForm
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
            listBox1 = new ListBox();
            catRadio = new RadioButton();
            dogRadio = new RadioButton();
            duckRadio = new RadioButton();
            textBox1 = new TextBox();
            label1 = new Label();
            createAnimalGroup = new GroupBox();
            button1 = new Button();
            animalSpeakBtn = new Button();
            animalSpeakLabel = new Label();
            createAnimalGroup.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(12, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(295, 200);
            listBox1.TabIndex = 0;
            // 
            // catRadio
            // 
            catRadio.AutoSize = true;
            catRadio.Font = new Font("Segoe UI", 12F);
            catRadio.Location = new Point(33, 40);
            catRadio.Name = "catRadio";
            catRadio.Size = new Size(62, 32);
            catRadio.TabIndex = 1;
            catRadio.TabStop = true;
            catRadio.Text = "Cat";
            catRadio.UseVisualStyleBackColor = true;
            // 
            // dogRadio
            // 
            dogRadio.AutoSize = true;
            dogRadio.Font = new Font("Segoe UI", 12F);
            dogRadio.Location = new Point(33, 78);
            dogRadio.Name = "dogRadio";
            dogRadio.Size = new Size(71, 32);
            dogRadio.TabIndex = 2;
            dogRadio.TabStop = true;
            dogRadio.Text = "Dog";
            dogRadio.UseVisualStyleBackColor = true;
            // 
            // duckRadio
            // 
            duckRadio.AutoSize = true;
            duckRadio.Font = new Font("Segoe UI", 12F);
            duckRadio.Location = new Point(33, 116);
            duckRadio.Name = "duckRadio";
            duckRadio.Size = new Size(77, 32);
            duckRadio.TabIndex = 3;
            duckRadio.TabStop = true;
            duckRadio.Text = "Duck";
            duckRadio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(143, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(143, 34);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // createAnimalGroup
            // 
            createAnimalGroup.Controls.Add(button1);
            createAnimalGroup.Controls.Add(label1);
            createAnimalGroup.Controls.Add(duckRadio);
            createAnimalGroup.Controls.Add(textBox1);
            createAnimalGroup.Controls.Add(dogRadio);
            createAnimalGroup.Controls.Add(catRadio);
            createAnimalGroup.Font = new Font("Segoe UI", 12F);
            createAnimalGroup.Location = new Point(12, 12);
            createAnimalGroup.Name = "createAnimalGroup";
            createAnimalGroup.Size = new Size(295, 170);
            createAnimalGroup.TabIndex = 6;
            createAnimalGroup.TabStop = false;
            createAnimalGroup.Text = "Create Animal:";
            // 
            // button1
            // 
            button1.Location = new Point(143, 105);
            button1.Name = "button1";
            button1.Size = new Size(125, 43);
            button1.TabIndex = 6;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // animalSpeakBtn
            // 
            animalSpeakBtn.Font = new Font("Segoe UI", 12F);
            animalSpeakBtn.Location = new Point(12, 418);
            animalSpeakBtn.Name = "animalSpeakBtn";
            animalSpeakBtn.Size = new Size(295, 37);
            animalSpeakBtn.TabIndex = 7;
            animalSpeakBtn.Text = "Selected Animal Speak";
            animalSpeakBtn.UseVisualStyleBackColor = true;
            // 
            // animalSpeakLabel
            // 
            animalSpeakLabel.Font = new Font("Segoe UI", 12F);
            animalSpeakLabel.Location = new Point(12, 475);
            animalSpeakLabel.Name = "animalSpeakLabel";
            animalSpeakLabel.Size = new Size(295, 39);
            animalSpeakLabel.TabIndex = 8;
            animalSpeakLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnimalsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 539);
            Controls.Add(animalSpeakLabel);
            Controls.Add(animalSpeakBtn);
            Controls.Add(createAnimalGroup);
            Controls.Add(listBox1);
            Name = "AnimalsForm";
            Text = "Animals";
            createAnimalGroup.ResumeLayout(false);
            createAnimalGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private RadioButton catRadio;
        private RadioButton dogRadio;
        private RadioButton duckRadio;
        private TextBox textBox1;
        private Label label1;
        private GroupBox createAnimalGroup;
        private Button button1;
        private Button animalSpeakBtn;
        private Label animalSpeakLabel;
    }
}
