using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlDataBinding.Common;
using XmlDataBinding.Model;

namespace XmlDataBinding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string filePath = "databinding.xml";
        private void btnSave_Click(object sender, EventArgs e)
        {
            Data data = new Data
            {
                DataList = (List<DataItem>)dgvData.DataSource
            };
            XmlHelper.SerializeToXml(data, filePath);
            Console.WriteLine("Data saved successfully.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Data data = XmlHelper.DeserializeFromXml(filePath);
            dgvData.DataSource = data.DataList;
        }
    }
}
