using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicManagerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Function

        private void Resetpanel()
        {
            StoragePanel.Visible = false;
        }
        private void StorageFuctionBtn_Click(object sender, EventArgs e)
        {
            StoragePanel.Visible = true;
        }


        #endregion

        
    }
}
