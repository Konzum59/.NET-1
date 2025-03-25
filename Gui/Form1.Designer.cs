namespace Gui
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
            run = new Button();
            numberOfItems = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            itemsBox = new TextBox();
            SuspendLayout();
            // 
            // run
            // 
            run.Location = new Point(54, 216);
            run.Name = "run";
            run.Size = new Size(75, 23);
            run.TabIndex = 0;
            run.Tag = "";
            run.Text = "Solve";
            run.UseVisualStyleBackColor = true;
            run.Click += run_Click;
            // 
            // numberOfItems
            // 
            numberOfItems.Location = new Point(54, 61);
            numberOfItems.Name = "numberOfItems";
            numberOfItems.Size = new Size(100, 23);
            numberOfItems.TabIndex = 1;
            numberOfItems.Tag = "";
            numberOfItems.TextChanged += textBox1_TextChanged_1;
            // 
            // seed
            // 
            seed.Location = new Point(54, 106);
            seed.Name = "seed";
            seed.Size = new Size(100, 23);
            seed.TabIndex = 2;
            // 
            // capacity
            // 
            capacity.Location = new Point(54, 145);
            capacity.Name = "capacity";
            capacity.Size = new Size(100, 23);
            capacity.TabIndex = 3;
            // 
            // result
            // 
            result.Location = new Point(445, 106);
            result.Multiline = true;
            result.Name = "result";
            result.Size = new Size(162, 219);
            result.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 40);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 5;
            label1.Text = "How many items:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 88);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Seed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 130);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Capacity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 78);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Solution:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 80);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Items:";
            label5.Click += label5_Click;
            // 
            // itemsBox
            // 
            itemsBox.Location = new Point(234, 106);
            itemsBox.Multiline = true;
            itemsBox.Name = "itemsBox";
            itemsBox.Size = new Size(171, 219);
            itemsBox.TabIndex = 10;
            itemsBox.TextChanged += textBox1_TextChanged_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(itemsBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(result);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(numberOfItems);
            Controls.Add(run);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button run;
        private TextBox numberOfItems;
        private TextBox seed;
        private TextBox capacity;
        private TextBox result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox itemsBox;
    }
}
