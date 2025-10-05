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
        /// <summary>
        /// 
        /// </summary>
        public Frm040000()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// [検索]ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<DataCopyListEntity> records = new List<DataCopyListEntity>();

            var action = new Domain.Action.Tools.DataCopyListAction();
            records = action.doSearch();

            if ( records == null || records.Count == 0 )
            {
                MessageBox.Show("[FRM04000-01] 該当するデータが存在しません。");
                return;
            }
            else
            {
                UpdateEmployeeDataGrid.DataSource = records;
            }
        }

        /// <summary>
        /// [新規登録]ボタンを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Form frm040100 = new Forms.Tools.DataCopy.Frm040100();
            frm040100.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateEmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            var ColumnIndex = e.ColumnIndex;

            // ヘッダ行またはヘッダ列をクリックした場合は何もしない
            if ((RowIndex < 0) || (ColumnIndex < 0)) return;
            // ボタン列以外の場合は何もしない
            if (ColumnIndex != 1) return;

            // 名前列の内容を表示します。
            var value = (string)UpdateEmployeeDataGrid.Rows[RowIndex].Cells[0].Value;
            MessageBox.Show(value);
        }
    }
}
