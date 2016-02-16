using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using System.Configuration;

namespace ConnectionBuilder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonMakeString_Click(object sender, EventArgs e)
        {
            var d = new DataConnectionDialog();
            DataSource.AddStandardDataSources(d);
            var result = DataConnectionDialog.Show(d);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBoxConnection.Text = d.ConnectionString;
                var provider = d.GetSelectedDataProvider(d.SelectedDataSource);
                textBoxProvider.Text = provider.Name;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var cs = new System.Configuration.ConnectionStringSettings("name", textBoxConnection.Text, textBoxProvider.Text);

            //get the proper factory 
            DbProviderFactory factory =
              DbProviderFactories.GetFactory(cs.ProviderName);

            //create a command of the proper type.
            DbConnection conn = factory.CreateConnection();
            //set the connection string
            conn.ConnectionString = cs.ConnectionString;

            //open the connection
            conn.Open();

            conn.Close();
        }
    }
}
