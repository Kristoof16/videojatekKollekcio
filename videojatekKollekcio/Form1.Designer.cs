namespace videojatekKollekcio
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
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            megnyitásToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            jatekokLista = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { megnyitásToolStripMenuItem, kilépésToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitásToolStripMenuItem
            // 
            megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            megnyitásToolStripMenuItem.Size = new Size(180, 22);
            megnyitásToolStripMenuItem.Text = "Megnyitás";
            megnyitásToolStripMenuItem.Click += megnyitásToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(180, 22);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // jatekokLista
            // 
            jatekokLista.FormattingEnabled = true;
            jatekokLista.ItemHeight = 15;
            jatekokLista.Location = new Point(31, 72);
            jatekokLista.Name = "jatekokLista";
            jatekokLista.Size = new Size(208, 364);
            jatekokLista.TabIndex = 1;
            jatekokLista.SelectedIndexChanged += jatekokLista_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(434, 344);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(327, 94);
            listBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 3;
            label1.Text = "Videójátékok listája:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 323);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 4;
            label2.Text = "Fejlesztő további játékai:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(666, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(538, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(538, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 23);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 136);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 9;
            label3.Text = "Cím:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 169);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Fejlesztő:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 205);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 11;
            label5.Text = "Platform:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 239);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 12;
            label6.Text = "Megjelenés éve:";
            // 
            // button1
            // 
            button1.Location = new Point(666, 281);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 13;
            button1.Text = "Keresés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(jatekokLista);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Videójáték Kollekció Alkalmazás";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem megnyitásToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private ListBox jatekokLista;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}
