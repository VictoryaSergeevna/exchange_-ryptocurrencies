namespace WindowsFormsApp30
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSumForBuy = new System.Windows.Forms.TextBox();
            this.textBoxSumForSell = new System.Windows.Forms.TextBox();
            this.textBoxCourseForBuy = new System.Windows.Forms.TextBox();
            this.textBoxCourseForSell = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxBTC = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCourseForBuy = new System.Windows.Forms.Label();
            this.lblSumForSale = new System.Windows.Forms.Label();
            this.lblSumBuy = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblBTC = new System.Windows.Forms.Label();
            this.lblCurrentlyCourse = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSumForBuy
            // 
            this.textBoxSumForBuy.Location = new System.Drawing.Point(241, 195);
            this.textBoxSumForBuy.Name = "textBoxSumForBuy";
            this.textBoxSumForBuy.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumForBuy.TabIndex = 2;
            // 
            // textBoxSumForSell
            // 
            this.textBoxSumForSell.Location = new System.Drawing.Point(241, 283);
            this.textBoxSumForSell.Name = "textBoxSumForSell";
            this.textBoxSumForSell.Size = new System.Drawing.Size(100, 20);
            this.textBoxSumForSell.TabIndex = 3;
            // 
            // textBoxCourseForBuy
            // 
            this.textBoxCourseForBuy.Location = new System.Drawing.Point(62, 195);
            this.textBoxCourseForBuy.Name = "textBoxCourseForBuy";
            this.textBoxCourseForBuy.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseForBuy.TabIndex = 4;
            // 
            // textBoxCourseForSell
            // 
            this.textBoxCourseForSell.Location = new System.Drawing.Point(62, 279);
            this.textBoxCourseForSell.Name = "textBoxCourseForSell";
            this.textBoxCourseForSell.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseForSell.TabIndex = 5;
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(438, 94);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxUSD.TabIndex = 6;
            // 
            // textBoxBTC
            // 
            this.textBoxBTC.Location = new System.Drawing.Point(247, 94);
            this.textBoxBTC.Name = "textBoxBTC";
            this.textBoxBTC.Size = new System.Drawing.Size(100, 20);
            this.textBoxBTC.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(355, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(79, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(448, 66);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(60, 13);
            this.lblUSD.TabIndex = 12;
            this.lblUSD.Text = " Доллары:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Курс для продажи:";
            // 
            // lblCourseForBuy
            // 
            this.lblCourseForBuy.AutoSize = true;
            this.lblCourseForBuy.Location = new System.Drawing.Point(66, 166);
            this.lblCourseForBuy.Name = "lblCourseForBuy";
            this.lblCourseForBuy.Size = new System.Drawing.Size(96, 13);
            this.lblCourseForBuy.TabIndex = 14;
            this.lblCourseForBuy.Text = "Курс для покупки";
            // 
            // lblSumForSale
            // 
            this.lblSumForSale.AutoSize = true;
            this.lblSumForSale.Location = new System.Drawing.Point(244, 249);
            this.lblSumForSale.Name = "lblSumForSale";
            this.lblSumForSale.Size = new System.Drawing.Size(109, 13);
            this.lblSumForSale.TabIndex = 15;
            this.lblSumForSale.Text = "Сумма для продажи";
            // 
            // lblSumBuy
            // 
            this.lblSumBuy.AutoSize = true;
            this.lblSumBuy.Location = new System.Drawing.Point(238, 166);
            this.lblSumBuy.Name = "lblSumBuy";
            this.lblSumBuy.Size = new System.Drawing.Size(109, 13);
            this.lblSumBuy.TabIndex = 16;
            this.lblSumBuy.Text = "Сумма для покупки:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(489, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblBTC
            // 
            this.lblBTC.AutoSize = true;
            this.lblBTC.Location = new System.Drawing.Point(274, 66);
            this.lblBTC.Name = "lblBTC";
            this.lblBTC.Size = new System.Drawing.Size(60, 13);
            this.lblBTC.TabIndex = 18;
            this.lblBTC.Text = "Биткоины:";
            // 
            // lblCurrentlyCourse
            // 
            this.lblCurrentlyCourse.AutoSize = true;
            this.lblCurrentlyCourse.Location = new System.Drawing.Point(486, 229);
            this.lblCurrentlyCourse.Name = "lblCurrentlyCourse";
            this.lblCurrentlyCourse.Size = new System.Drawing.Size(131, 13);
            this.lblCurrentlyCourse.TabIndex = 19;
            this.lblCurrentlyCourse.Text = "Текущий курс биткоина:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(622, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCurrentlyCourse);
            this.Controls.Add(this.lblBTC);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSumBuy);
            this.Controls.Add(this.lblSumForSale);
            this.Controls.Add(this.lblCourseForBuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxBTC);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.textBoxCourseForSell);
            this.Controls.Add(this.textBoxCourseForBuy);
            this.Controls.Add(this.textBoxSumForSell);
            this.Controls.Add(this.textBoxSumForBuy);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSumForBuy;
        private System.Windows.Forms.TextBox textBoxSumForSell;
        private System.Windows.Forms.TextBox textBoxCourseForBuy;
        private System.Windows.Forms.TextBox textBoxCourseForSell;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textBoxBTC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCourseForBuy;
        private System.Windows.Forms.Label lblSumForSale;
        private System.Windows.Forms.Label lblSumBuy;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblBTC;
        private System.Windows.Forms.Label lblCurrentlyCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
    }
}

