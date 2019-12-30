using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurTemplify
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnSourceDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSourceDirectory.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnTargetDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtTargetDirectory.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTemplify_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = true;

            bool canContinue = true;

            foreach (Control control in gbxDirectory.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show("We need more information. Check this out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    canContinue = false;

                    return;
                }
            }

            foreach (Control control in gbxKey.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    MessageBox.Show("We need more information. Check this out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    canContinue = false;

                    return;
                }
            }


            if (canContinue)
            {
                DateTime startDate = DateTime.Now;
                //await TemplifyMe.TemplifyFolder(txtSourceDirectory.Text, txtTargetDirectory.Text, txtSourceKey.Text, txtTargetKey.Text, statusStrip);

                TemplifyMe.FolderExclusions = txtFolderExclusions.Text.Split(txtSeparator.Text[0]);
                TemplifyMe.FileExclusions = txtFileExclusions.Text.Split(txtSeparator.Text[0]);
                TemplifyMe.GlobalExtensionExclusions = txtGlobalExtensionExclusions.Text.Split(txtSeparator.Text[0]);
                TemplifyMe.TokenExtensionExclusions = txtTokenExtensionExclusions.Text.Split(txtSeparator.Text[0]);

                Thread thread = new Thread(() => TemplifyMe.Start(txtSourceDirectory.Text, txtTargetDirectory.Text, txtSourceKey.Text, txtTargetKey.Text, statusStrip));
                thread.Start();

                //TimeSpan processTime = DateTime.Now.Subtract(startDate);

                //MessageBox.Show($"Operacion finalizada en {processTime.TotalHours}:{processTime.TotalMinutes}:{processTime.TotalSeconds}", "Listo!");

                //txtSourceDirectory.Clear();
                //txtSourceKey.Clear();
                //txtTargetDirectory.Clear();
                //txtTargetKey.Clear();

                return;
            }

            MessageBox.Show("Ocurrio un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
