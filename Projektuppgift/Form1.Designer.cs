namespace Projektuppgift
{
    partial class Kontaktboken
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
            label1 = new Label();
            buttonAdd = new Button();
            buttonEdit = new Button();
            button3 = new Button();
            label2 = new Label();
            textName = new TextBox();
            textPhone = new TextBox();
            label3 = new Label();
            textAdress = new TextBox();
            label4 = new Label();
            textMail = new TextBox();
            label5 = new Label();
            textBirth = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            buttonDelete = new Button();
            radioGreen = new RadioButton();
            radioBlue = new RadioButton();
            radioRed = new RadioButton();
            label7 = new Label();
            radioWhite = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(533, 50);
            label1.TabIndex = 0;
            label1.Text = "Välkommen till kontaktboken!!!";
            label1.Click += label1_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Location = new Point(598, 415);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(76, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Rensa";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Location = new Point(680, 415);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(92, 23);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Ändra kontakt";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(778, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Spara";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 111);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Namn:";
            // 
            // textName
            // 
            textName.Location = new Point(138, 108);
            textName.Name = "textName";
            textName.Size = new Size(183, 23);
            textName.TabIndex = 5;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(138, 147);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(183, 23);
            textPhone.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 150);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefonnummer:";
            // 
            // textAdress
            // 
            textAdress.Location = new Point(138, 185);
            textAdress.Name = "textAdress";
            textAdress.Size = new Size(183, 23);
            textAdress.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 188);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Adress:";
            // 
            // textMail
            // 
            textMail.Location = new Point(138, 225);
            textMail.Name = "textMail";
            textMail.Size = new Size(183, 23);
            textMail.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 228);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Mail:";
            // 
            // textBirth
            // 
            textBirth.Location = new Point(138, 265);
            textBirth.Name = "textBirth";
            textBirth.Size = new Size(183, 23);
            textBirth.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 268);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 12;
            label6.Text = "Födelsedatum:";
            label6.Click += label6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 331);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(497, 415);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 23);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Ta bort kontakt";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // radioGreen
            // 
            radioGreen.AutoSize = true;
            radioGreen.Location = new Point(29, 330);
            radioGreen.Name = "radioGreen";
            radioGreen.Size = new Size(51, 19);
            radioGreen.TabIndex = 16;
            radioGreen.TabStop = true;
            radioGreen.Text = "Grön";
            radioGreen.UseVisualStyleBackColor = true;
            radioGreen.CheckedChanged += radioGreen_CheckedChanged;
            // 
            // radioBlue
            // 
            radioBlue.AutoSize = true;
            radioBlue.Location = new Point(29, 355);
            radioBlue.Name = "radioBlue";
            radioBlue.Size = new Size(41, 19);
            radioBlue.TabIndex = 17;
            radioBlue.TabStop = true;
            radioBlue.Text = "Blå";
            radioBlue.UseVisualStyleBackColor = true;
            radioBlue.CheckedChanged += radioBlue_CheckedChanged;
            // 
            // radioRed
            // 
            radioRed.AutoSize = true;
            radioRed.Location = new Point(29, 380);
            radioRed.Name = "radioRed";
            radioRed.Size = new Size(46, 19);
            radioRed.TabIndex = 18;
            radioRed.TabStop = true;
            radioRed.Text = "Röd";
            radioRed.UseVisualStyleBackColor = true;
            radioRed.CheckedChanged += radioRed_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 312);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 19;
            label7.Text = "Ändra färg:";
            // 
            // radioWhite
            // 
            radioWhite.AutoSize = true;
            radioWhite.Location = new Point(29, 405);
            radioWhite.Name = "radioWhite";
            radioWhite.Size = new Size(39, 19);
            radioWhite.TabIndex = 20;
            radioWhite.TabStop = true;
            radioWhite.Text = "Vit";
            radioWhite.UseVisualStyleBackColor = true;
            radioWhite.CheckedChanged += radioVit_CheckedChanged;
            // 
            // Kontaktboken
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(radioWhite);
            Controls.Add(label7);
            Controls.Add(radioRed);
            Controls.Add(radioBlue);
            Controls.Add(radioGreen);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridView1);
            Controls.Add(textBirth);
            Controls.Add(label6);
            Controls.Add(textMail);
            Controls.Add(label5);
            Controls.Add(textAdress);
            Controls.Add(label4);
            Controls.Add(textPhone);
            Controls.Add(label3);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Name = "Kontaktboken";
            Text = "Kontaktboken";
            Load += Kontaktboken_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button button3;
        private Label label2;
        private TextBox textName;
        private TextBox textPhone;
        private Label label3;
        private TextBox textAdress;
        private Label label4;
        private TextBox textMail;
        private Label label5;
        private TextBox textBirth;
        private Label label6;
        private DataGridView dataGridView1;
        private Button buttonDelete;
        private RadioButton radioGreen;
        private RadioButton radioBlue;
        private RadioButton radioRed;
        private Label label7;
        private RadioButton radioWhite;
    }
}