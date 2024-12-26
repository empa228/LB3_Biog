using LB3_blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;

namespace LB3_blog
{
    public partial class FormMain : Form
    {
        // �������� ��������� ��������� ������, ������� ����� ��������������
        // ��� �������� � ������������ ��������� � �������������
        private BlogContext? db;

        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // ����� OnLoad ���������� ��� �������� �����
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new BlogContext();

            // ����� Load ���������� ������������ ��� �������� ���� ������������� �� ���� ������ � DbContext ���� ������
            this.db.Users.Load();
            this.dataGridViewUsers.DataSource = db.Users.Local.ToBindingList();
        }

        // ����� OnClosing ���������� ��� �������� �����
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var user = (Models.User)this.dataGridViewUsers.CurrentRow.DataBoundItem;

                if (user != null)
                {
                    this.db.Entry(user).Collection(e => e.Posts).Load();
                    this.dataGridViewPosts.DataSource = user.Posts;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // ���� ��� �������� SaveChanges DbContext ������, 
            // ������� ��������� ��� ���������, �������� � ���� ������

            this.db!.SaveChanges();

            this.dataGridViewUsers.Refresh();
            this.dataGridViewPosts.Refresh();
        }
    }
}
