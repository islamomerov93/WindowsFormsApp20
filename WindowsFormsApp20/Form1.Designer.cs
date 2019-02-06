namespace WindowsFormsApp20
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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView2 = new System.Windows.Forms.ListView();
            this.play = new System.Windows.Forms.PictureBox();
            this.PageCountLbl = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.bookReaderPnl = new System.Windows.Forms.Panel();
            this.page = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.bookReaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page)).BeginInit();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.Location = new System.Drawing.Point(12, 26);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(331, 501);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
            this.listView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView2_DragEnter);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play.Location = new System.Drawing.Point(518, 487);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(100, 50);
            this.play.TabIndex = 2;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // PageCountLbl
            // 
            this.PageCountLbl.Location = new System.Drawing.Point(518, 461);
            this.PageCountLbl.Name = "PageCountLbl";
            this.PageCountLbl.Size = new System.Drawing.Size(100, 23);
            this.PageCountLbl.TabIndex = 3;
            this.PageCountLbl.Text = "label1";
            this.PageCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.next.Location = new System.Drawing.Point(670, 487);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(100, 50);
            this.next.TabIndex = 4;
            this.next.TabStop = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back.Location = new System.Drawing.Point(353, 487);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 50);
            this.back.TabIndex = 4;
            this.back.TabStop = false;
            // 
            // bookReaderPnl
            // 
            this.bookReaderPnl.Controls.Add(this.page);
            this.bookReaderPnl.Location = new System.Drawing.Point(353, 26);
            this.bookReaderPnl.Name = "bookReaderPnl";
            this.bookReaderPnl.Size = new System.Drawing.Size(424, 432);
            this.bookReaderPnl.TabIndex = 1;
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(3, 3);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(418, 426);
            this.page.TabIndex = 0;
            this.page.TabStop = false;
            this.page.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(785, 539);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.PageCountLbl);
            this.Controls.Add(this.play);
            this.Controls.Add(this.bookReaderPnl);
            this.Controls.Add(this.listView2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.bookReaderPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.Label PageCountLbl;
        private System.Windows.Forms.PictureBox next;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Panel bookReaderPnl;
        private System.Windows.Forms.PictureBox page;
    }
}

