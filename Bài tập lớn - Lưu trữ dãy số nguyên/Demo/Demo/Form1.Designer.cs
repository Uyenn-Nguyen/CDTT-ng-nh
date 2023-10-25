namespace Demo
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
            groupBoxKetqua = new GroupBox();
            CalculateButton = new Button();
            lstSum = new ListBox();
            ReadButton = new Button();
            lstNumbers = new ListBox();
            buttonSave = new Button();
            labelTong = new Label();
            labelday = new Label();
            groupBoxNhap = new GroupBox();
            buttonNhapStack = new Button();
            sizeTextBox = new TextBox();
            labelnhapso = new Label();
            buttonNhapLinkedList = new Button();
            textBoxNhap = new TextBox();
            buttonRandom = new Button();
            textBoxExecutionTime = new TextBox();
            labelTime = new Label();
            groupBoxKetqua.SuspendLayout();
            groupBoxNhap.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxKetqua
            // 
            groupBoxKetqua.Controls.Add(CalculateButton);
            groupBoxKetqua.Controls.Add(lstSum);
            groupBoxKetqua.Controls.Add(ReadButton);
            groupBoxKetqua.Controls.Add(lstNumbers);
            groupBoxKetqua.Controls.Add(buttonSave);
            groupBoxKetqua.Controls.Add(labelTong);
            groupBoxKetqua.Controls.Add(labelday);
            groupBoxKetqua.Location = new Point(94, 195);
            groupBoxKetqua.Name = "groupBoxKetqua";
            groupBoxKetqua.Size = new Size(651, 260);
            groupBoxKetqua.TabIndex = 18;
            groupBoxKetqua.TabStop = false;
            groupBoxKetqua.Text = "Kết quả";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(500, 176);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(135, 29);
            CalculateButton.TabIndex = 15;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // lstSum
            // 
            lstSum.FormattingEnabled = true;
            lstSum.ItemHeight = 20;
            lstSum.Location = new Point(128, 146);
            lstSum.Name = "lstSum";
            lstSum.Size = new Size(313, 104);
            lstSum.TabIndex = 17;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(500, 86);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(127, 29);
            ReadButton.TabIndex = 16;
            ReadButton.Text = "Đọc file";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // lstNumbers
            // 
            lstNumbers.FormattingEnabled = true;
            lstNumbers.ItemHeight = 20;
            lstNumbers.Location = new Point(127, 22);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(314, 104);
            lstNumbers.TabIndex = 15;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(500, 26);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(127, 29);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelTong
            // 
            labelTong.AutoSize = true;
            labelTong.Location = new Point(50, 146);
            labelTong.Name = "labelTong";
            labelTong.Size = new Size(71, 20);
            labelTong.TabIndex = 7;
            labelTong.Text = "Tổng dãy";
            // 
            // labelday
            // 
            labelday.AutoSize = true;
            labelday.Location = new Point(21, 43);
            labelday.Name = "labelday";
            labelday.Size = new Size(100, 20);
            labelday.TabIndex = 4;
            labelday.Text = "Dãy vừa nhập";
            // 
            // groupBoxNhap
            // 
            groupBoxNhap.Controls.Add(buttonNhapStack);
            groupBoxNhap.Controls.Add(sizeTextBox);
            groupBoxNhap.Controls.Add(labelnhapso);
            groupBoxNhap.Controls.Add(buttonNhapLinkedList);
            groupBoxNhap.Controls.Add(textBoxNhap);
            groupBoxNhap.Controls.Add(buttonRandom);
            groupBoxNhap.Location = new Point(94, 30);
            groupBoxNhap.Name = "groupBoxNhap";
            groupBoxNhap.Size = new Size(651, 141);
            groupBoxNhap.TabIndex = 17;
            groupBoxNhap.TabStop = false;
            groupBoxNhap.Text = "Nhập số";
            // 
            // buttonNhapStack
            // 
            buttonNhapStack.Location = new Point(314, 82);
            buttonNhapStack.Name = "buttonNhapStack";
            buttonNhapStack.Size = new Size(105, 29);
            buttonNhapStack.TabIndex = 13;
            buttonNhapStack.Text = "Nhập (Stack)";
            buttonNhapStack.UseVisualStyleBackColor = true;
            buttonNhapStack.Click += buttonNhapStack_Click;
            // 
            // sizeTextBox
            // 
            sizeTextBox.Location = new Point(516, 26);
            sizeTextBox.Name = "sizeTextBox";
            sizeTextBox.Size = new Size(95, 27);
            sizeTextBox.TabIndex = 12;
            // 
            // labelnhapso
            // 
            labelnhapso.AutoSize = true;
            labelnhapso.Location = new Point(80, 31);
            labelnhapso.Name = "labelnhapso";
            labelnhapso.Size = new Size(64, 20);
            labelnhapso.TabIndex = 3;
            labelnhapso.Text = "Nhập số";
            // 
            // buttonNhapLinkedList
            // 
            buttonNhapLinkedList.Location = new Point(150, 82);
            buttonNhapLinkedList.Name = "buttonNhapLinkedList";
            buttonNhapLinkedList.RightToLeft = RightToLeft.Yes;
            buttonNhapLinkedList.Size = new Size(130, 29);
            buttonNhapLinkedList.TabIndex = 10;
            buttonNhapLinkedList.Text = "Nhập (linkedlist)";
            buttonNhapLinkedList.UseVisualStyleBackColor = true;
            // 
            // textBoxNhap
            // 
            textBoxNhap.Location = new Point(150, 24);
            textBoxNhap.Name = "textBoxNhap";
            textBoxNhap.Size = new Size(302, 27);
            textBoxNhap.TabIndex = 2;
            // 
            // buttonRandom
            // 
            buttonRandom.Location = new Point(476, 82);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(135, 29);
            buttonRandom.TabIndex = 1;
            buttonRandom.Text = "Random";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += buttonRandom_Click_1;
            // 
            // textBoxExecutionTime
            // 
            textBoxExecutionTime.Location = new Point(185, 498);
            textBoxExecutionTime.Name = "textBoxExecutionTime";
            textBoxExecutionTime.Size = new Size(189, 27);
            textBoxExecutionTime.TabIndex = 16;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(43, 501);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(125, 20);
            labelTime.TabIndex = 15;
            labelTime.Text = "Thời gian thực thi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 562);
            Controls.Add(groupBoxKetqua);
            Controls.Add(groupBoxNhap);
            Controls.Add(textBoxExecutionTime);
            Controls.Add(labelTime);
            Name = "Form1";
            Text = "Form1";
            groupBoxKetqua.ResumeLayout(false);
            groupBoxKetqua.PerformLayout();
            groupBoxNhap.ResumeLayout(false);
            groupBoxNhap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxKetqua;
        private Button CalculateButton;
        private ListBox lstSum;
        private Button ReadButton;
        private ListBox lstNumbers;
        private Button buttonSave;
        private Label labelTong;
        private Label labelday;
        private GroupBox groupBoxNhap;
        private Button buttonNhapStack;
        private TextBox sizeTextBox;
        private Label labelnhapso;
        private Button buttonNhapLinkedList;
        private TextBox textBoxNhap;
        private Button buttonRandom;
        private TextBox textBoxExecutionTime;
        private Label labelTime;
    }
}