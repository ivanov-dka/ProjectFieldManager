using Microsoft.ProjectServer.Client;
using Microsoft.SharePoint.Client;
using ProjectFieldsManager.Classes;
using ProjectFieldsManager.Extensions;
using ProjectFieldsManager.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ProjectFieldsManager.Forms
{
    public partial class ExportImportForm : System.Windows.Forms.Form
    {
        bool gvGridFieldsToggle = false;
        bool gvGridTablesToggle = false;

        public ExportImportForm()
        {
            InitializeComponent();

            this.UseWaitCursor = true;

            Thread thread = new Thread(new ThreadStart(FillGrids));
            thread.Start();
        }

        public void FillGrids()
        {
            try
            {
                var data = ProjectHelper.GetCustomEntities();

                gvFields.Invoke((Action)(() =>
                {
                    gvFields.DataSource = new BindingSource(new BindingList<ExportEnterpriseField>(data.Fields), null);
                    foreach (DataGridViewColumn dc in gvFields.Columns)
                    {
                        dc.ReadOnly = !dc.Index.Equals(0);
                    }

                    foreach(DataGridViewRow r in gvFields.Rows)
                    {
                        r.Cells["IsExported"].Value = true;
                    }

                    gvFields.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    
                }));

                gvTables.Invoke((Action)(() =>
                {
                    gvTables.DataSource = new BindingSource(new BindingList<ExportLookupTable>(data.Tables), null);
                    foreach (DataGridViewColumn dc in gvTables.Columns)
                    {
                        dc.ReadOnly = !dc.Index.Equals(0);
                    }

                    foreach (DataGridViewRow r in gvTables.Rows)
                    {
                        r.Cells["IsExported"].Value = true;
                    }

                    gvTables.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Invoke((Action)(() =>
                {
                    this.UseWaitCursor = false;
                    bExport.Enabled = true;
                    bImport.Enabled = true;
                    bGenerate.Enabled = true;
                }));
            }
        }


        #region Event handlers

        private void gvFields_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            foreach (DataGridViewRow row in ((DataGridView)sender).Rows)
            {
                row.Cells[0].Value = gvGridFieldsToggle;
            }

            gvGridFieldsToggle = !gvGridFieldsToggle;
        }

        private void gvTables_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            foreach (DataGridViewRow row in ((DataGridView)sender).Rows)
            {
                row.Cells[0].Value = gvGridTablesToggle;
            }

            gvGridTablesToggle = !gvGridTablesToggle;
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            try
            {
                bExport.Enabled = false;

                saveDialog.Title = "Save exported fields and tables";               
                saveDialog.RestoreDirectory = true;
                saveDialog.DefaultExt = "json";
                saveDialog.Filter = "json files (*.json)|*.json";
                saveDialog.FilterIndex = 1;
                saveDialog.CheckPathExists = true;
                saveDialog.FileName = $"{DateTime.Now.ToString("dd.MM.yyyy_HH.mm")}.json";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var exportEntity = new ExportEntity();
                    exportEntity.Fields = ((IEnumerable)gvFields.DataSource).Cast<ExportEnterpriseField>().ToList();
                    exportEntity.Tables = ((IEnumerable)gvTables.DataSource).Cast<ExportLookupTable>().ToList();
                    var json = new JavaScriptSerializer().Serialize(exportEntity);

                    System.IO.File.WriteAllText(saveDialog.FileName, json);
                    saveDialog.Dispose();

                    MessageBox.Show("Selected fields are successfully exported!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bExport.Enabled = true;
            }
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;

            Thread thread = new Thread(new ThreadStart(FillGrids));
            thread.Start();
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;

            Thread thread = new Thread(new ThreadStart(FillGrids));
            thread.Start();
        }

        #endregion
    }
}
