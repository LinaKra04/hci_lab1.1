using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_lab1._1
{
    public partial class lab1_1 : Form
    {
        public int count_click = 0;

        public lab1_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMssg.Select();

            if (mssgBox.Text == " " || string.IsNullOrEmpty(mssgBox.Text))
            {
                mssgBox.Text = "The text field is empty!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showMssgActs.Select();

            if (showMssgActs.Checked)
            {
                enterMssg.Show();
                mssgBox.Show();
                showMssg.Show();
                defMssg1.Show();
                defMssg2.Show();
            }

            else
            {
                enterMssg.Hide();
                mssgBox.Hide();
                showMssg.Hide();
                defMssg1.Hide();
                defMssg2.Hide();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            enableMssgActs.Select();

            if (enableMssgActs.Checked)
            {
                enterMssg.Enabled = true;
                mssgBox.Enabled = true;
                showMssg.Enabled = true;
                defMssg1.Enabled = true;
                defMssg2.Enabled = true;
            }

            else
            {
                enterMssg.Enabled = false;
                mssgBox.Enabled = false;
                showMssg.Enabled = false;
                defMssg1.Enabled = false;
                defMssg2.Enabled = false;
            }
        }

        private void exit__Click(object sender, EventArgs e)
        {
            exit_.Select();
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void enterMssg_Click(object sender, EventArgs e)
        {

        }

        private void defMssg1_Click(object sender, EventArgs e)
        {
            defMssg1.Select();
            mssgBox.Text = "This is my default message";
        }

        private void defMssg2_Click(object sender, EventArgs e)
        {
            defMssg2.Select();
            mssgBox.Text = "This is another default message";
        }

        private void mssgBox_TextChanged(object sender, EventArgs e)
        {
            mssgBox.Select();

        }

        private void showMssg_Click(object sender, EventArgs e)
        {
            showMssg.Select();
            mssgBox.Show();

            if (string.IsNullOrEmpty(mssgBox.Text) || mssgBox.Text == " ")
            {
                mssgBox.Text = "The text field is empty!";
            }
        }

        private void programActsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            programActsList.Select();
        }

        private void execution_Click(object sender, EventArgs e)
        {
            execution.Select();
            if (programActsList.Text == "Clear field")
            {
                mssgBox.Text = " ";
            }

            if (programActsList.Text == "Copy text")
            {
                Clipboard.SetText(mssgBox.Text);
            }

            else if (programActsList.Text == "Paste text")
            {
                mssgBox.Text = Clipboard.GetText();
            }
        }

        private void focusCtrl_Click(object sender, EventArgs e)
        {
            ++count_click;

            if (count_click == 1)
            {
                mssgBox.Focus();
            }

            if (count_click == 2)
            {
                showMssg.Focus();
            }

            if (count_click == 3)
            {
                defMssg1.Focus();
            }

            if (count_click == 4)
            {
                defMssg2.Focus();
            }

            if (count_click == 5)
            {
                programActsList.Focus();
            }

            if (count_click == 6)
            {
                execution.Focus();
            }

            if (count_click == 7)
            {
                exit_.Focus();
                count_click = 0;
            }
        }

        private void showProgActs_CheckedChanged(object sender, EventArgs e)
        {
            showProgActs.Select();
            if (showProgActs.Checked)
            {
                progr.Show();
                programActsList.Show();
                execution.Show();
            }

            else
            {
                progr.Hide();
                programActsList.Hide();
                execution.Hide();
            }
        }

        private void actionsEnable_Enter(object sender, EventArgs e)
        {

        }

        private void enableProgActs_CheckedChanged(object sender, EventArgs e)
        {
            enableProgActs.Select();

            if (enableProgActs.Checked)
            {
                progr.Enabled = true;
                programActsList.Enabled = true;
                execution.Enabled = true;
            }

            else
            {
                progr.Enabled = false;
                programActsList.Enabled = false;
                execution.Enabled = false;
            }
        }

        private void mssgBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void showMssg_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void defMssg1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void defMssg2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void programActsList_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void execution_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void showMssgActs_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void showProgActs_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void enableMssgActs_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void enableProgActs_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void exit__KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
