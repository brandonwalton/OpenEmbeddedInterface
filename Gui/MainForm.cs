using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenEmbeddedInterface.Gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Menu Items

        private void tsmiNewProject_Click(object sender, EventArgs e)
        {
            NewProjectDialog project = new NewProjectDialog();
            project.ShowDialog();
        }

        #endregion
    }
}
