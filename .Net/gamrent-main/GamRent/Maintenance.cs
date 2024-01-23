using CrystalDecisions.ReportAppServer.ReportDefModel;
using GamRent.Model;
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
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace GamRent
{
    public partial class Maintenance : Form
    {
        private readonly CrudContextFactory crudContextFactory = new CrudContextFactory();
        private readonly IDataService<Model.Maintenance> dataService;
        usableFunction funct = new usableFunction();
        public Maintenance()
        {
            InitializeComponent();
            dataService = new DataService<Model.Maintenance>(crudContextFactory);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_AssetNo.Text == "" || txt_RentalNo.Text == "" || txt_Service.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Model.Maintenance frm = new Model.Maintenance()
            {
                Cost = Convert.ToDouble(txt_Cost.Text),
                AssetNo = txt_AssetNo.Text,
                Description = richTextBox1.Text,
                RentNo = txt_RentalNo.Text,
                ServiceName = txt_Service.Text,
            };
            frm = dataService.Create(frm).Result;
            frmMaintenance_Load(sender, e);
        }
        private void btn_New_Click(object sender, EventArgs e)
        {

            var frm = dataService.GetAll().Result.ToList().Select(e => new { e.Id, e.ServiceName, e.AssetNo, e.RentNo, v = (e.IsCompleted == true) ? "Fixed" : "Pending", x = e.CreatedDate.ToShortDateString() });
            dataGridView1.DataSource = frm;
            dataGridView1.Columns[0].Visible = false;
            funct.clearTxt(panel1);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_AssetNo.Text == "" || txt_RentalNo.Text == "" || txt_Service.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var frm = dataService.SearchForAnEntity(e => e.AssetNo == txt_AssetNo.Text && e.RentNo == txt_RentalNo.Text && e.ServiceName == txt_Service.Text).Result;
                frm.UpdatedDate = DateTime.Now;
                frm.AssetNo = txt_AssetNo.Text;
                frm.RentNo = txt_RentalNo.Text;
                frm.ServiceName = txt_Service.Text;
                double cst = frm.Cost;
                if (!string.IsNullOrWhiteSpace(txt_Cost.Text))
                    frm.Cost = Convert.ToDouble(txt_Cost.Text);

                if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    frm.Description = richTextBox1.Text;
                }
                frm = dataService.Update(frm).Result;
                MessageBox.Show("Data has been saved in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //.
                funct.clearTxt(panel1);
                frmMaintenance_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var frm = dataService.SearchForAnEntity(e => e.Id == Guid.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())).Result;
            if (frm != null)
            {
                var flg = dataService.Delete(frm).Result;
                MessageBox.Show("Data has been deleted in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("unable to delete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            frmMaintenance_Load(sender, e);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (txt_AssetNo.Text == "" || txt_RentalNo.Text == "" || txt_Service.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Model.Maintenance maintenance = new Model.Maintenance()
                {
                    AssetNo = txt_AssetNo.Text,
                    RentNo = txt_RentalNo.Text,
                    Cost = Convert.ToDouble(txt_Cost.Text),
                    ServiceName = txt_Service.Text,
                    CreatedDate = DateTime.Now,
                    DateReported = DateTime.Now,
                    Description = richTextBox1.Text,
                    UpdatedDate = DateTime.Now,
                };
                maintenance = dataService.Create(maintenance).Result;
                if (maintenance != null)
                {
                    MessageBox.Show("Data has been saved in the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Failed to saved in the database", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            frmMaintenance_Load(sender, e);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmMaintenance_Load(sender, e);
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }
    }
}
