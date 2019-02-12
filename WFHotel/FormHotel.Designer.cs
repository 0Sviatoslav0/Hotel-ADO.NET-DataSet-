namespace WFHotel
{
    partial class FormHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загальнаІнформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рахункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатковіПослугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.порушенняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.співробітникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номериГотелюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.звітиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вільніНомериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зайнятіНомериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.історіяШтрафівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загальнаІнформаціяToolStripMenuItem,
            this.довідникиToolStripMenuItem,
            this.звітиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загальнаІнформаціяToolStripMenuItem
            // 
            this.загальнаІнформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.замовленняToolStripMenuItem,
            this.рахункиToolStripMenuItem});
            this.загальнаІнформаціяToolStripMenuItem.Name = "загальнаІнформаціяToolStripMenuItem";
            this.загальнаІнформаціяToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.загальнаІнформаціяToolStripMenuItem.Text = "Дані";
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            this.замовленняToolStripMenuItem.Click += new System.EventHandler(this.замовленняToolStripMenuItem_Click);
            // 
            // рахункиToolStripMenuItem
            // 
            this.рахункиToolStripMenuItem.Name = "рахункиToolStripMenuItem";
            this.рахункиToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.рахункиToolStripMenuItem.Text = "Рахунки";
            this.рахункиToolStripMenuItem.Click += new System.EventHandler(this.рахункиToolStripMenuItem_Click);
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клієнтиToolStripMenuItem,
            this.додатковіПослугиToolStripMenuItem1,
            this.порушенняToolStripMenuItem1,
            this.співробітникиToolStripMenuItem,
            this.номериГотелюToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.довідникиToolStripMenuItem.Text = "Довідники";
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // додатковіПослугиToolStripMenuItem1
            // 
            this.додатковіПослугиToolStripMenuItem1.Name = "додатковіПослугиToolStripMenuItem1";
            this.додатковіПослугиToolStripMenuItem1.Size = new System.Drawing.Size(248, 30);
            this.додатковіПослугиToolStripMenuItem1.Text = "Додаткові послуги";
            this.додатковіПослугиToolStripMenuItem1.Click += new System.EventHandler(this.додатковіПослугиToolStripMenuItem1_Click);
            // 
            // порушенняToolStripMenuItem1
            // 
            this.порушенняToolStripMenuItem1.Name = "порушенняToolStripMenuItem1";
            this.порушенняToolStripMenuItem1.Size = new System.Drawing.Size(248, 30);
            this.порушенняToolStripMenuItem1.Text = "Порушення";
            this.порушенняToolStripMenuItem1.Click += new System.EventHandler(this.порушенняToolStripMenuItem1_Click);
            // 
            // співробітникиToolStripMenuItem
            // 
            this.співробітникиToolStripMenuItem.Name = "співробітникиToolStripMenuItem";
            this.співробітникиToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.співробітникиToolStripMenuItem.Text = "Співробітники";
            this.співробітникиToolStripMenuItem.Click += new System.EventHandler(this.співробітникиToolStripMenuItem_Click);
            // 
            // номериГотелюToolStripMenuItem
            // 
            this.номериГотелюToolStripMenuItem.Name = "номериГотелюToolStripMenuItem";
            this.номериГотелюToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.номериГотелюToolStripMenuItem.Text = "Номери готелю";
            this.номериГотелюToolStripMenuItem.Click += new System.EventHandler(this.номериГотелюToolStripMenuItem_Click);
            // 
            // звітиToolStripMenuItem
            // 
            this.звітиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вільніНомериToolStripMenuItem,
            this.зайнятіНомериToolStripMenuItem,
            this.історіяШтрафівToolStripMenuItem});
            this.звітиToolStripMenuItem.Name = "звітиToolStripMenuItem";
            this.звітиToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.звітиToolStripMenuItem.Text = "Звіти";
            // 
            // вільніНомериToolStripMenuItem
            // 
            this.вільніНомериToolStripMenuItem.Name = "вільніНомериToolStripMenuItem";
            this.вільніНомериToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.вільніНомериToolStripMenuItem.Text = "Вільні номери";
            this.вільніНомериToolStripMenuItem.Click += new System.EventHandler(this.вільніНомериToolStripMenuItem_Click);
            // 
            // зайнятіНомериToolStripMenuItem
            // 
            this.зайнятіНомериToolStripMenuItem.Name = "зайнятіНомериToolStripMenuItem";
            this.зайнятіНомериToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.зайнятіНомериToolStripMenuItem.Text = "Зайняті номери";
            this.зайнятіНомериToolStripMenuItem.Click += new System.EventHandler(this.зайнятіНомериToolStripMenuItem_Click);
            // 
            // історіяШтрафівToolStripMenuItem
            // 
            this.історіяШтрафівToolStripMenuItem.Name = "історіяШтрафівToolStripMenuItem";
            this.історіяШтрафівToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.історіяШтрафівToolStripMenuItem.Text = "Історія штрафів";
            this.історіяШтрафівToolStripMenuItem.Click += new System.EventHandler(this.історіяШтрафівToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHotel";
            this.Text = "Керування готелем";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHotel_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загальнаІнформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рахункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатковіПослугиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem порушенняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem співробітникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem звітиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вільніНомериToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зайнятіНомериToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem історіяШтрафівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem номериГотелюToolStripMenuItem;
    }
}

