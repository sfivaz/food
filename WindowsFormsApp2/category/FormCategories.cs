﻿using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp2.category;

namespace WindowsFormsApp2
{
    public partial class FormCategories : Form
    {
        static FormCategories instance;
        public FormCategories()
        {
            InitializeComponent();
            instance = this;
        }
        public static FormCategories getInstance()
        {
            if (instance == null)
                new FormCategories();
            return instance;
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            RefreshData();
            dgvCat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCat.Columns[0].HeaderText = "id";
            dgvCat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCat.Columns[1].HeaderText = "nom";
        }

        internal void RefreshData()
        {
            dgvCat.DataSource = new CategoryORM().ListAll();
        }

        private void dgvCat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddCategory fa = new FormAddCategory();

            fa.SetEditMode();
            fa.id = Int32.Parse(dgvCat.CurrentRow.Cells[0].Value.ToString());
            fa.tbxACaName.Text = this.dgvCat.CurrentRow.Cells[1].Value.ToString();
           
            fa.ShowDialog();
        }

        private void btnCatDel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvCat.CurrentRow.Cells[0].Value.ToString());
            new CategoryORM().Delete(id);
            RefreshData();
        }

        private void tbxCatSearchName_TextChanged(object sender, EventArgs e)
        {
            if (tbxCatSearchName.Text.Equals(""))
                RefreshData();
            else
            {
                DataTable data = new CategoryORM().Search(tbxCatSearchName.Text);
                dgvCat.DataSource = data;
            }
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            new FormAddCategory().ShowDialog();
        }
    }
}
