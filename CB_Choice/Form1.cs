using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        private string[] SList = new string[] {
               "김밥", "샐러드김밥", "야채김밥",
            "소고기김밥" ,"계란김밥", "라볶이"
        };

        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtList_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }

            this.OrgStr = this.cbList.Text;
            if(this.SList.Length > 0)
            this.cbList.SelectedIndex = 0;


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Checkinput();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Checkinput();
            }
        }

        private bool Checkinput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
                return false;
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.cbList.SelectedIndex = this.cbList.Items.Count - 1;
                this.txtList.Focus();
                return true;
            }
        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbList.Text != "")
            {
                this.lblResult.Text = "선택 결과 : " + OrgStr + this.cbList.Text;
            }
        }
    }
}
