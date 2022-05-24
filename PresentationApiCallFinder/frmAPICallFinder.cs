using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationApiCallFinder
{
    public partial class frmAPICallFinder : Form
    {
        public frmAPICallFinder()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openHARFileDialog.Reset();

            openHARFileDialog.ShowDialog();
            if(!string.IsNullOrEmpty(openHARFileDialog.FileName))
            {
                txtHARFilePath.Text = openHARFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void btnProcessHARFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(openHARFileDialog.FileName) || !File.Exists(openHARFileDialog.FileName))
            {
                return;
            }

            var json = File.OpenText(openHARFileDialog.FileName).ReadToEnd();


            try
            {
                JObject apiCallLog = JObject.Parse(json);
                var callLogs = from entry in apiCallLog["log"]["entries"]
                           select new { method=(string)entry["request"]["method"], url=(string)entry["request"]["url"] };
               

                grdCallLog.DataSource = callLogs.Where(i=>i.method!= "OPTIONS" && i.url.ToLowerInvariant().Contains("presentation")).Distinct().ToList();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
