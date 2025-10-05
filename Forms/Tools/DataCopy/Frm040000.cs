using MasterPrototype.Domain.Entity.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPrototype.Forms.Tools.DataCopy
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Frm040000 : Form
    {
        public Frm040000()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DataCopyListEntity> records = new List<DataCopyListEntity>();

            var action = new Domain.Action.Tools.DataCopyListAction();
            records = action.doSearch();

            if ( records == null || records.Count == 0 )
            {
                MessageBox.Show("該当データがありません。");
                return;
            }
            else
            {
                UpdateEmployeeDataGriid.DataSource = records;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm040100 = new Forms.Tools.DataCopy.Frm040100();
            frm040100.ShowDialog();

        }
    }
}
