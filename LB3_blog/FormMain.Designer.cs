namespace LB3_blog
{
    partial class FormMain
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
            dataGridViewUsers = new DataGridView();
            panelTop = new Panel();
            buttonSave = new Button();
            panelLeft = new Panel();
            panelFill = new Panel();
            dataGridViewPosts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.Margin = new Padding(4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(508, 540);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            dataGridViewUsers.SelectionChanged += DataGridViewUsers_SelectionChanged;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1029, 70);
            panelTop.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave.Location = new Point(10, 10);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 50);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dataGridViewUsers);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 70);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(528, 560);
            panelLeft.TabIndex = 3;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewPosts);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(528, 70);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(501, 560);
            panelFill.TabIndex = 4;
            // 
            // dataGridViewPosts
            // 
            dataGridViewPosts.BackgroundColor = Color.White;
            dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPosts.Dock = DockStyle.Fill;
            dataGridViewPosts.Location = new Point(10, 10);
            dataGridViewPosts.Name = "dataGridViewPosts";
            dataGridViewPosts.Size = new Size(481, 540);
            dataGridViewPosts.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Panel panelTop;
        private Button buttonSave;
        private Panel panelLeft;
        private Panel panelFill;
        private DataGridView dataGridViewPosts;
    }
}
