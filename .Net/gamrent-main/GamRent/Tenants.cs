using GamRent.Model;
using GamRent.Models;
using GamRent.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.FieldOptions.Types;
using static Org.BouncyCastle.Math.EC.ECCurve;
using static System.Net.Mime.MediaTypeNames;

namespace GamRent
{
    public partial class Tenants : Form
    {
        private readonly IDataService<Models.Tenants> _dataService;
        private readonly IDataService<Asset> assetServices;
        private readonly IDataService<Rental> rentalService;
        private readonly CrudContextFactory _crudContextFactory = new CrudContextFactory();
        public Tenants(string cus_id)
        {
            InitializeComponent();
            rentalService = new DataService<Rental>(_crudContextFactory);
            assetServices = new DataService<Asset>(_crudContextFactory);
            _dataService = new DataService<Models.Tenants>(_crudContextFactory);
            //txt_cusid.Text = cus_id;
        }

        //private void frmTenants_Load(object sender, EventArgs e)
        //{
        //    var data = _dataService.GetAll().Result;
        //    dtglist.DataSource = data;

        //}
        //private void txtsearch_TextChanged(object sender, EventArgs e)
        //{
        //    frmTenants_Load(sender, e);
        //}
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        //private void txt_cusid_TextChanged(object sender, EventArgs e)
        //{
        //    //sql = "SELECT * FROM `tblperson` WHERE `SUPLIERCUSTOMERID`='" + txt_cusid.Text + "'";
        //    var tenant = _dataService.SearchForAnEntity(e => e.AssetNo == txt_cusid.Text).Result;
        //    if (tenant != null)
        //    {
        //        txtCus_fname.Text = tenant.FirstName;
        //        txtCus_lname.Text = tenant.LastName;
        //    }
        //    //config.singleResult(sql);
        //    //if (config.dt.Rows.Count > 0)
        //    //{
        //    //    txtCus_fname.Text = config.dt.Rows[0].Field<string>("FIRSTNAME");
        //    //    txtCus_lname.Text = config.dt.Rows[0].Field<string>("LASTNAME");
        //    //}
        //    else
        //    {
        //        txtCus_fname.Clear();
        //        txtCus_lname.Clear();
        //    }
        //}

        private void frmTenants_Load(object sender, EventArgs e)
        {
            //List<string> list = _dataService.GetAll().Result.ToList().Select(e => e.AssetNo).ToList();
            //int cnt = list.Count + 1;
            //dtgCus_itemlist.DataSource = list;
            var data = from item in assetServices.GetAll().Result
                       select item.Name;
            var data1 = from item in _dataService.GetAll
                     ().Result
                        join rent in rentalService.GetAll().Result on item.RentalId equals rent.Id
                        join asset in assetServices.GetAll().Result on item.AssetId equals asset.Id
                        select new
                        {
                            Num = item.Num,
                            Name = item.Name,
                            Rental = rent.RentNo,
                            Asset = asset.Name,
                        };
            dtgCus_itemlist.DataSource = data1.ToList();
            funct.ResponsiveDtg(dtgCus_itemlist);
            asset_comboBox.DataSource = data.ToList();
            dtgCus_itemlist.Columns[0].Visible = false;
            funct.ResponsiveDtg(dtgCus_itemlist);
            //txt_cusid.Text = cnt.ToString();
            var dt = from item in rentalService.SearchFor(e => e.IsOccupaid == false).Result
                     select item.RentNo;
            rental_comboBox.DataSource = dt.ToList();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //sql = "\"SELECT `FirstName` as 'First Name', `LastName` as 'Last Name', `AssetNo` as 'Asset No', `AssetName` as 'Asset Name', `RentNo` as 'Rent No',`RentName` as 'Rent Name' FROM `tenants` WHERE  `FirstName` like '%" + txtsearch.Text + "%' or `LastName` = '" + txtsearch.Text + "'";
            var data = from item in _dataService.SearchFor
                     (e => e.FirstName == txtsearch.Text || e.LastName == txtsearch.Text).Result
                       join rent in rentalService.GetAll().Result on item.RentalId equals rent.Id
                       join asset in assetServices.GetAll().Result on item.AssetId equals asset.Id
                       select new
                       {
                           item.Num,
                           item.Name,
                           rent.RentNo,
                           asset.AssetNo,
                       };
            dtgCus_itemlist.DataSource = data.ToList();
            //config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
        }

        private void dtgCus_itemlist_DoubleClick(object sender, EventArgs e)
        {
            double tot;
            int qty;

            if (dtCus_addedlist.RowCount == 0)
            {


                qty = 1;
                tot = double.Parse(dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString()) * 1;
                string[] row = new string[] { dtgCus_itemlist.CurrentRow.Cells[0].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[1].Value.ToString(),
                dtgCus_itemlist.CurrentRow.Cells[2].Value.ToString(),
                dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString(),
                 qty.ToString(),
                tot.ToString()};

                dtCus_addedlist.Rows.Add(row);


            }
            else
            {
                foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                {
                    if (dtgCus_itemlist.CurrentRow.Cells[0].Value == r.Cells[0].Value)
                    {
                        MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (dtCus_addedlist.CurrentRow.Cells[0].Value != dtgCus_itemlist.CurrentRow.Cells[0].Value)
                {
                    qty = 1;
                    tot = double.Parse(dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString()) * 1;
                    string[] row = new string[] { dtgCus_itemlist.CurrentRow.Cells[0].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[1].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[2].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString(),
                     qty.ToString(),
                    tot.ToString()};
                    dtCus_addedlist.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



            }
        }




        private void dtCus_addedlist_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total;
            if (dtCus_addedlist.CurrentCell.ColumnIndex == 4)
            {
                foreach (DataGridViewRow row in dtCus_addedlist.Rows)
                {
                    total = double.Parse(row.Cells[4].Value.ToString()) * double.Parse(row.Cells[3].Value.ToString());
                    row.Cells[5].Value = total;
                }
            }
        }

        private void btnCus_save_Click(object sender, EventArgs e)
        {
            string assetNo = asset_comboBox.Text;

            var asset = assetServices.SearchForAnEntity(e => e.Name == assetNo).Result;
            var rental = rentalService.SearchForAnEntity(e => e.RentNo == rental_comboBox.Text).Result;
            Models.Tenants tenants = new Models.Tenants()
            {
                Num = rental_comboBox.Text,
                AssetId = asset.Id,
                RentalId = rental.Id,
                RentalNo = rental.RentNo,
                AssetNo = assetNo,
                AssetName = asset.Name,
                RentalName = asset.Name,
                FirstName = txtCus_fname.Text,
                LastName = txtCus_lname.Text,
                Name = txtCus_fname.Text + " " + txtCus_lname.Text
            };
            tenants = _dataService.Create(tenants).Result;
            rental.IsOccupaid = true;
            rental = rentalService.Update(rental).Result;
            frmTenants_Load(sender, e);
        }

        private void btnCus_Remove_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow);
        }

        private void btnCus_clear_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Rows.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewStockout_Click(object sender, EventArgs e)
        {
            //frmListStockout frm = new frmListStockout();
            //frm.Show();
        }

        private void dtCus_addedlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fill_rentalCombox(object sender, EventArgs e)
        {
            string assetName = asset_comboBox.Text;
            var asset = assetServices.SearchForAnEntity(e => e.Name == assetName).Result;
            if (asset != null)
            {
                var data = from item in rentalService.SearchFor(e => e.AssetNo == asset.AssetNo && e.IsOccupaid == false).Result
                           select item.RentNo;
                rental_comboBox.DataSource = data.ToList();
            }
            else
            {
                var data = from item in rentalService.SearchFor(e => e.IsOccupaid == false).Result
                           select item.RentNo;
                rental_comboBox.DataSource = data.ToList();
            }


        }

        private void rental_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgCus_itemlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
