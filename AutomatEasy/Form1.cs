using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatEasy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CunstomizeDesing();
        }

        private void CunstomizeDesing() 
        {
            panelRedeSocialSubmenu.Visible = false;
            panelSubMenuConfiguracao.Visible = false;
            panelSubMenuPlataformasInvestimntos.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelRedeSocialSubmenu.Visible == true)
                panelRedeSocialSubmenu.Visible = false;
            if (panelSubMenuConfiguracao.Visible == true)
                panelSubMenuConfiguracao.Visible = false;
            if (panelSubMenuPlataformasInvestimntos.Visible == true)
                panelSubMenuPlataformasInvestimntos.Visible = false;
        }

        private void ShowMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnRedesSociais_Click(object sender, EventArgs e)
        {
            ShowMenu(panelRedeSocialSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {   

            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnPlataformaInvestimento_Click(object sender, EventArgs e)
        {
            ShowMenu(panelSubMenuPlataformasInvestimntos);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            ShowMenu(panelSubMenuConfiguracao);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();       
        }
    }
}
