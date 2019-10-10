namespace CRUD_WSR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_View = new System.Windows.Forms.Panel();
            this.pnl_Edit = new System.Windows.Forms.Panel();
            this.switch_notes = new System.Windows.Forms.Button();
            this.switch_deleted = new System.Windows.Forms.Button();
            this.switch_View = new System.Windows.Forms.Button();
            this.pnl_Deleted = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_instgram = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnl_Top.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_View.SuspendLayout();
            this.pnl_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.BlueViolet;
            this.pnl_Top.Controls.Add(this.btn_Close);
            this.pnl_Top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 25);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(775, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.switch_deleted);
            this.pnl_Menu.Controls.Add(this.switch_View);
            this.pnl_Menu.Controls.Add(this.switch_notes);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 25);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(103, 425);
            this.pnl_Menu.TabIndex = 1;
            // 
            // pnl_View
            // 
            this.pnl_View.Controls.Add(this.panel5);
            this.pnl_View.Controls.Add(this.label5);
            this.pnl_View.Controls.Add(this.txt_search);
            this.pnl_View.Controls.Add(this.dataGridView1);
            this.pnl_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_View.Location = new System.Drawing.Point(103, 25);
            this.pnl_View.Name = "pnl_View";
            this.pnl_View.Size = new System.Drawing.Size(697, 425);
            this.pnl_View.TabIndex = 1;
            // 
            // pnl_Edit
            // 
            this.pnl_Edit.Controls.Add(this.btn_add);
            this.pnl_Edit.Controls.Add(this.label4);
            this.pnl_Edit.Controls.Add(this.label3);
            this.pnl_Edit.Controls.Add(this.label2);
            this.pnl_Edit.Controls.Add(this.label1);
            this.pnl_Edit.Controls.Add(this.panel4);
            this.pnl_Edit.Controls.Add(this.panel3);
            this.pnl_Edit.Controls.Add(this.panel2);
            this.pnl_Edit.Controls.Add(this.panel1);
            this.pnl_Edit.Controls.Add(this.txt_instgram);
            this.pnl_Edit.Controls.Add(this.txt_group);
            this.pnl_Edit.Controls.Add(this.txt_surname);
            this.pnl_Edit.Controls.Add(this.txt_name);
            this.pnl_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Edit.Location = new System.Drawing.Point(103, 25);
            this.pnl_Edit.Name = "pnl_Edit";
            this.pnl_Edit.Size = new System.Drawing.Size(697, 425);
            this.pnl_Edit.TabIndex = 1;
            // 
            // switch_notes
            // 
            this.switch_notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_notes.FlatAppearance.BorderSize = 0;
            this.switch_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_notes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switch_notes.Image = ((System.Drawing.Image)(resources.GetObject("switch_notes.Image")));
            this.switch_notes.Location = new System.Drawing.Point(15, 143);
            this.switch_notes.Name = "switch_notes";
            this.switch_notes.Size = new System.Drawing.Size(72, 35);
            this.switch_notes.TabIndex = 0;
            this.switch_notes.UseVisualStyleBackColor = true;
            // 
            // switch_deleted
            // 
            this.switch_deleted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_deleted.FlatAppearance.BorderSize = 0;
            this.switch_deleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_deleted.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switch_deleted.Image = ((System.Drawing.Image)(resources.GetObject("switch_deleted.Image")));
            this.switch_deleted.Location = new System.Drawing.Point(15, 246);
            this.switch_deleted.Name = "switch_deleted";
            this.switch_deleted.Size = new System.Drawing.Size(72, 35);
            this.switch_deleted.TabIndex = 0;
            this.switch_deleted.UseVisualStyleBackColor = true;
            // 
            // switch_View
            // 
            this.switch_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_View.FlatAppearance.BorderSize = 0;
            this.switch_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switch_View.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.switch_View.Image = ((System.Drawing.Image)(resources.GetObject("switch_View.Image")));
            this.switch_View.Location = new System.Drawing.Point(15, 194);
            this.switch_View.Name = "switch_View";
            this.switch_View.Size = new System.Drawing.Size(72, 35);
            this.switch_View.TabIndex = 0;
            this.switch_View.UseVisualStyleBackColor = true;
            // 
            // pnl_Deleted
            // 
            this.pnl_Deleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Deleted.Location = new System.Drawing.Point(103, 25);
            this.pnl_Deleted.Name = "pnl_Deleted";
            this.pnl_Deleted.Size = new System.Drawing.Size(697, 425);
            this.pnl_Deleted.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(220, 74);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(261, 19);
            this.txt_name.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(220, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 5);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя:";
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(220, 151);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(261, 19);
            this.txt_surname.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Location = new System.Drawing.Point(220, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 5);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // txt_group
            // 
            this.txt_group.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_group.Location = new System.Drawing.Point(220, 223);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(261, 19);
            this.txt_group.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Location = new System.Drawing.Point(220, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 5);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа:";
            // 
            // txt_instgram
            // 
            this.txt_instgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_instgram.Location = new System.Drawing.Point(220, 292);
            this.txt_instgram.Name = "txt_instgram";
            this.txt_instgram.Size = new System.Drawing.Size(261, 19);
            this.txt_instgram.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Location = new System.Drawing.Point(220, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 5);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "instagram:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(296, 341);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 33);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(115, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Location = new System.Drawing.Point(363, 121);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(219, 19);
            this.txt_search.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Поиск:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.BlueViolet;
            this.panel5.Location = new System.Drawing.Point(363, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 5);
            this.panel5.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Edit);
            this.Controls.Add(this.pnl_View);
            this.Controls.Add(this.pnl_Deleted);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_View.ResumeLayout(false);
            this.pnl_View.PerformLayout();
            this.pnl_Edit.ResumeLayout(false);
            this.pnl_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_View;
        private System.Windows.Forms.Panel pnl_Edit;
        private System.Windows.Forms.Button switch_notes;
        private System.Windows.Forms.Button switch_deleted;
        private System.Windows.Forms.Button switch_View;
        private System.Windows.Forms.Panel pnl_Deleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_instgram;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel5;
    }
}

