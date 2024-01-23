using GamRent.Model;
using GamRent.Models;
using GamRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamRent
{
    public partial class Settings : Form
    {
        private readonly IDataService<AssetCategory> _dataService;
        private readonly IDataService<RentalCategory> _rentalService;
        private readonly CrudContextFactory _crudContextFactory = new CrudContextFactory();
        public Settings()
        {
            InitializeComponent();
            _dataService = new DataService<AssetCategory>(_crudContextFactory);
            _rentalService = new DataService<RentalCategory>(_crudContextFactory);
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql, typeid, unitid;

        private void btnTypesave_Click(object sender, EventArgs e)
        {
            AssetCategory category = new AssetCategory()
            {
                Name = txtCategory.Text,
            };
            category = _dataService.Create(category).Result;
            frmSettings_Load(sender, e);
        }

        private void btntypeLoad_Click(object sender, EventArgs e)
        {
            this.dtgtypelist.DataSource = null;
            this.dtgtypelist.Refresh();
            var category = _dataService.GetAll().Result;
            dtgtypelist.DataSource = category;
            funct.ResponsiveDtg(dtgtypelist);
            dtgtypelist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgtypelist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgtypelist.Columns[0].Visible = false;
            txtCategory.Clear();
        }
        private void btnrenttypeLoad_Click(object sender, EventArgs e)
        {
            this.dtgulist.DataSource = null;
            this.dtgulist.Refresh();
            var category = _rentalService.GetAll().Result;
            dtgulist.DataSource = category;
            funct.ResponsiveDtg(dtgulist);
            dtgulist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgulist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgulist.Columns[0].Visible = false;
            txtunit.Clear();
        }

        private void btncdel_Click(object sender, EventArgs e)
        {
            var category = _dataService.SearchForAnEntity(e => e.Id == Guid.Parse(dtgtypelist.CurrentRow.Cells[0].Value.ToString())).Result;
            var flg = _dataService.Delete(category).Result;

            frmSettings_Load(sender, e);
        }

        private void dtgtypelist_Click(object sender, EventArgs e)
        {
            txtCategory.Text = dtgtypelist.CurrentRow.Cells[1].Value.ToString();
            typeid = dtgtypelist.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnuload_Click(object sender, EventArgs e)
        {
            var category = _dataService.GetAll().Result;

            dtgtypelist.DataSource = category;
            dtgtypelist.Columns[0].Visible = false;
            txtCategory.Clear();
        }

        private void rentbtnuload_Click(object sender, EventArgs e)
        {
            var category = _rentalService.GetAll().Result;

            dtgulist.DataSource = category;
            dtgulist.Columns[0].Visible = false;
            txtunit.Clear();
        }
        private void btnusave_Click(object sender, EventArgs e)
        {

            AssetCategory category = new AssetCategory()
            {
                Name = txtunit.Text,
            };
            category = _dataService.Create(category).Result;
            if (category != null)
            {
                MessageBox.Show("Data has been saved in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Error in saving date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            frmSettings_Load(sender, e);
        }
        private void btnusaverent_Click(object sender, EventArgs e)
        {

            RentalCategory category = new RentalCategory()
            {
                Name = txtunit.Text,
            };
            category = _rentalService.Create(category).Result;
            if (category != null)
            {
                MessageBox.Show("Data has been saved in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Error in saving date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            frmSettings_Load(sender, e);
        }
        private void btnunit_Click(object sender, EventArgs e)
        {
            var category = _dataService.SearchForAnEntity(e => e.Id == Guid.Parse(dtgtypelist.CurrentRow.Cells[0].Value.ToString())).Result;
            var flg = _dataService.Delete(category).Result;
            //sql = "DELETE FROM `tblsettings` WHERE `ID`='" + dtgulist.CurrentRow.Cells[0].Value + "'";
            //config.Execute_CUD(sql, "error to delete date", "Data has been deleted in the database.");
            btnuload_Click(sender, e);
        }
        private void rentbtnunit_Click(object sender, EventArgs e)
        {
            var category = _rentalService.SearchForAnEntity(e => e.Id == Guid.Parse(dtgulist.CurrentRow.Cells[0].Value.ToString())).Result;
            var flg = _rentalService.Delete(category).Result;
            //sql = "DELETE FROM `tblsettings` WHERE `ID`='" + dtgulist.CurrentRow.Cells[0].Value + "'";
            //config.Execute_CUD(sql, "error to delete date", "Data has been deleted in the database.");
            rentbtnuload_Click(sender, e);
        }
        private void dtgulist_Click(object sender, EventArgs e)
        {
            //txtunit.Text = dtgtypelist.CurrentRow.Cells[1].Value.ToString();
            txtCategory.Text = dtgtypelist.CurrentRow.Cells[1].Value.ToString();
        }
        private void rentdtgulist_Click(object sender, EventArgs e)
        {
            txtunit.Text = dtgulist.CurrentRow.Cells[1].Value.ToString();
            //unitid = dtgulist.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnuupdate_Click(object sender, EventArgs e)
        {
            var category = _dataService.SearchForAnEntity(e => e.Id == Guid.Parse(unitid)).Result;
            category.Name = txtunit.Text;
            var flg = _dataService.Update(category).Result;
            btnuload_Click(sender, e);
        }
        private void rentcategorybtnuupdate_Click(object sender, EventArgs e)
        {
            var category = _rentalService.SearchForAnEntity(e => e.Id == Guid.Parse(unitid)).Result;
            category.Name = txtunit.Text;
            var flg = _rentalService.Update(category).Result;
            btnuload_Click(sender, e);
        }
        private void btntypeupdate_Click(object sender, EventArgs e)
        {
            var category = _dataService.SearchForAnEntity(e => e.Id == Guid.Parse(typeid)).Result;

            if (!string.IsNullOrEmpty(txtCategory.Text))
            {
                category.Name = txtCategory.Text;
                var flg = _dataService.Update(category).Result;
            }


            frmSettings_Load(sender, e);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            btntypeLoad_Click(sender, e);
            btnrenttypeLoad_Click(sender, e);
        }

        private void dtgulist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
