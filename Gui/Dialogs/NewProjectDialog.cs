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
    public partial class NewProjectDialog : Form
    {
        public NewProjectDialog()
        {
            InitializeComponent();

            cbInterface.SelectedIndex = 0;
        }

        /// <summary>
        /// Erases the content of a textbox on first click if the textbox's tag value is null.
        /// </summary>
        /// <param name="sender">The textbox to erase.</param>
        /// <param name="e">The event arguments./param>
        private void EraseClick(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox t = (TextBox)sender;
                if (t.Tag == null)
                {
                    t.Clear();
                    t.Tag = false;
                }
            }
        }

        private void tbCreate_Click(object sender, EventArgs e)
        {
            Project proj = new Project();
            proj.Name = tbName.Text;
            proj.WorkingDirectory = tbWorkingDirectory.Text;
            proj.TargetName = tbTargetName.Text;
            proj.TargetVendor = tbTargetVendor.Text;
            proj.TargetDescription = tbTargetDescription.Text;
            // TODO: Modify the enum parsing to not rely on string conversion
            proj.Interface = (DataInterfaceType)Enum.Parse(typeof(DataInterfaceType), cbInterface.Text, true);

            try
            {
                proj.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Unable to create project. Is your working directory a valid location?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
