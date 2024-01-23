using GamRent.Model;
using GamRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamRent
{
    public partial class Assets : Form
    {
        private readonly IDataService<Asset> dataService;
        private readonly CrudContextFactory crudContextFactory = new CrudContextFactory();
        public Assets()
        {
            InitializeComponent();
            dataService = new DataService<Asset>(crudContextFactory);
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxcolumn;
        int inc = 0;
        int maxrow;
        private void select_navigation(string sql)
        {
            config.singleResult(sql);
            maxrow = config.dt.Rows.Count;
        }
        public void navigate_records(int inc)
        {
            config.singleResult("SELECT * FROM `assets`");
            txtname.Text = config.dt.Rows[inc].Field<string>("Name");
            cbotype.Text = config.dt.Rows[inc].Field<string>("Type");
            txtdescription.Text = config.dt.Rows[inc].Field<string>("Location");
            txtlocation.Text = config.dt.Rows[inc].Field<string>("AssetNo");
            txtqty.Text = config.dt.Rows[inc].Field<string>("RentNo");
            //txtqty.Text = config.dt.Rows[inc].Field<int>("Quantity").ToString();
            //cbounit.Text = config.dt.Rows[inc].Field<string>("Units");


        }
        private void btnnew_Click(object sender, EventArgs e)
        {

            inc = 0;
            var data = dataService.GetAll().Result.ToList();
            txt_AssetNo.Text = data.Count.ToString();
            dtglist.DataSource = data;
            funct.ResponsiveDtg(dtglist);
            dtglist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtglist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            maxcolumn = dtglist.Columns.Count - 1;
            dtglist.Columns[0].Visible = false;
            dtglist.Columns[maxcolumn].Visible = false;

            btn_add.Visible = false;

            select_navigation("SELECT AssetNo FROM assets");
            lblmax.Text = maxrow.ToString();
            lblinc.Text = inc.ToString();

            sql = "SELECT Name FROM `AssetCategories`";
            config.fiil_CBO(sql, cbotype);
            funct.clearTxt(pnl_stockmaster);
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" + cbotype.Text + "'";
            //config.autonumber(sql, txtitemid);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // sql = "SELECT concat(`STRT`, `END`) FROM `tblautonumber` WHERE `DESCRIPTION`= '" + cbotype.Text + "'";
            // config.autonumber(sql, txtitemid);
            txt_AssetNo.Text = (dataService.GetAll().Result.ToList().Count + 1).ToString();
            foreach (Control obj in pnl_stockmaster.Controls)
            {

                if (obj is TextBox)
                {
                    if (obj.Text == "")
                    {
                        MessageBox.Show("Action connot be perform. All fields are required to be fill up.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            Asset asset = new Asset()
            {
                AssetNo = txt_AssetNo.Text,
                Type = cbotype.Text,
                Name = txtname.Text,
                Description = txtdescription.Text,
                Location = txtlocation.Text,
                RentalNo = txtqty.Text,
            };
            asset = dataService.Create(asset).Result;

            btnnew_Click(sender, e);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var asset = dataService.SearchForAnEntity(e => e.AssetNo == txt_AssetNo.Text).Result;
            asset.Name = txtname.Text;
            asset.Description = txtdescription.Text;
            asset.Location = txtlocation.Text;
            asset.RentalNo = txtqty.Text;
            asset.Type = cbotype.Text;
            asset = dataService.Update(asset).Result;
            //sql = "UPDATE assets SET `NAME`='" + txtname.Text + "', `DESCRIPTION`='" + txtdescription.Text + "', `TYPE`='" + cbotype.Text + "', `PRICE`='" + txtprice.Text + "'" +
            //",`UNIT`='" + cbounit.Text + "' WHERE ITEMID='" + txtitemid.Text + "'";
            //config.Execute_CUD(sql, "Error to update:" + sql.ToString(), "Data has been updated in the database");
            btnnew_Click(sender, e);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            //sql = "DELETE FROM assets WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value + "'";
            try
            {

                var asset = dataService.SearchForAnEntity(e => e.AssetNo == dtglist.CurrentRow.Cells[0].Value.ToString()).Result; asset.Name = txtname.Text;
                if (asset != null)
                {
                    var flg = dataService.Delete(asset).Result;
                    if (flg) MessageBox.Show("Data has been deleted");
                    else MessageBox.Show("Failed to delete.Data has NOT been deleted");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to delete. Data has NOT been deleted");
            }
            config.Execute_CUD(sql, "error to delete", "Data has been deleted.");
            btnnew_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtitemid_TextChanged(object sender, EventArgs e)
        {


        }

        private void dtglist_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(dtglist.CurrentRow.Cells[0].Value.ToString());
            var asset = dataService.SearchForAnEntity(e => e.Id == id).Result;
            //sql = "SELECT * FROM assets WHERE ITEMID='" + dtglist.CurrentRow.Cells[0].Value.ToString() + "'";
            //config.singleResult(sql);
            if (asset != null)
            {
                txt_AssetNo.Text = asset.AssetNo;// config.dt.Rows[0].Field<string>("ITEMID");
                txtname.Text = asset.Name;// config.dt.Rows[0].Field<string>("NAME");
                txtdescription.Text = asset.Description;// config.dt.Rows[0].Field<string>("DESCRIPTION");
                txtlocation.Text = asset.Location;// config.dt.Rows[0].Field<double>("PRICE").ToString();
                cbotype.Text = asset.Type;// config.dt.Rows[0].Field<string>("TYPE");
                txtqty.Text = asset.RentalNo;// config.dt.Rows[0].Field<int>("QTY").ToString();
                //cbounit.Text = config.dt.Rows[0].Field<string>("UNIT");
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            inc = 1;
            lblinc.Text = inc.ToString();
            inc = 0;
            navigate_records(inc);
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            select_navigation("SELECT AssetNo FROM assets");
            if (inc != maxrow)
            {
                inc = maxrow;
                lblinc.Text = inc.ToString();
                inc = maxrow - 1;
                navigate_records(inc);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            int lbl_inc = 0;

            if (inc > 0)
            {
                inc = inc - 1;
                navigate_records(inc);


                lbl_inc = int.Parse(lblinc.Text) - 1;

                lblinc.Text = lbl_inc.ToString();
            }
            else if (inc == 0)
            {
                navigate_records(inc);
                lbl_inc = 1;
                lblinc.Text = lbl_inc.ToString();
                MessageBox.Show("First Records", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int lbl_inc;

            select_navigation("SELECT AssetNo FROM assets");
            if (inc == maxrow - 1)
            {
                MessageBox.Show("no more rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (inc != maxrow - 1)
                {
                    inc = inc + 1;
                    navigate_records(inc);
                }

                lbl_inc = int.Parse(lblinc.Text) + 1;
                lblinc.Text = lbl_inc.ToString();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM assets WHERE AssetNo LIKE '%" + txtsearch.Text + "%' OR NAME LIKE '%" + txtsearch.Text + "%'";
            config.Load_DTG(sql, dtglist);


            maxcolumn = dtglist.Columns.Count - 1;

            dtglist.Columns[maxcolumn].Visible = false;

        }

        private void txtlocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
