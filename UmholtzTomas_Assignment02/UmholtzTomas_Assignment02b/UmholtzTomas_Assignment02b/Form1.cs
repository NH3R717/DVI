using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UmholtzTomas_Assignment02b
{
    public partial class Form1 : Form
    {
        List<ContactDetails> lsContacts = new List<ContactDetails>();
        int toggleSize = 0;
        string Lastname = "";
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opening new contact entry form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
            pnlView.Visible = false;
            pnlListView.Visible = false;
        }
        /// <summary>
        /// Toggle view from 100% to 200% and vice versa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            if (toggleSize == 0)
            {
                LoadList(true);
                toggleSize = 1;
            }
            else
            {
                LoadList(true);
                toggleSize = 0;
            }
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNew.Visible = false;
            pnlView.Visible = false;
            pnlListView.Visible = true;

            lstContacts.SmallImageList = smallImgList;
            LoadList(false);
        }
        /// <summary>
        /// Back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = false;
            pnlView.Visible = false;
            pnlListView.Visible = true;
        }
        /// <summary>
        /// Saving/Updating contact based on Last Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var contact = lsContacts.Find(x => x.LastName == Lastname);
            if (contact != null && contact.LastName != "")
            {
                contact.LastName = txtLastName.Text;
                contact.FirstName = txtFirstName.Text;
                contact.PhoneNo = txtPhone.Text;
                contact.Email = txtEmail.Text;
                contact.Gender = rdMale.Checked ? "Male" : "Female";
            }
            else
            {
                if (IsValid())
                {
                    ContactDetails cd = new ContactDetails();
                    cd.LastName = txtLastName.Text;
                    cd.FirstName = txtFirstName.Text;
                    cd.PhoneNo = txtPhone.Text;
                    cd.Email = txtEmail.Text;
                    cd.Gender = rdMale.Checked ? "Male" : "Female";
                    lsContacts.Add(cd);
                }
                else
                {
                    MessageBox.Show("Some information was not entered correctly or you did not select a gender, please try again.", "Invalid Entry Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Lastname = "";
            ClearAll();
            LoadList(false);
            pnlNew.Visible = false;
            pnlView.Visible = false;
            pnlListView.Visible = true;
        }
        /// <summary>
        /// Clearing all controls
        /// </summary>
        private void ClearAll()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
        }
        /// <summary>
        /// Buisness logic to toggle view and binding data to listview
        /// </summary>
        /// <param name="isZoomed"></param>
        private void LoadList(bool isZoomed)
        {
            lstContacts.Items.Clear();
            lsContacts = lsContacts.OrderBy(o=>o.LastName).ToList();
            if (isZoomed)
            {
                if (toggleSize == 0)
                {
                    lstContacts.SmallImageList = largeImgList;
                    lstContacts.Font = new Font(lstContacts.Font.FontFamily, lstContacts.Font.Size * 2);
                    for (int i = 0; i < lsContacts.Count; i++)
                    {
                        lstContacts.Items.Add(lsContacts[i].LastName, lsContacts[i].Gender.ToLower() == "male" ? "male1.png" : "female1.png");
                    }
                }
                else
                {
                    lstContacts.SmallImageList = smallImgList;
                    lstContacts.Font = new Font(lstContacts.Font.FontFamily, lstContacts.Font.Size / 2);
                    for (int i = 0; i < lsContacts.Count; i++)
                    {
                        lstContacts.Items.Add(lsContacts[i].LastName, lsContacts[i].Gender.ToLower() == "male" ? "male.png" : "female.png");
                    }
                }
            }
            else
            {
                lstContacts.SmallImageList = smallImgList;
                for (int i = 0; i < lsContacts.Count; i++)
                {
                    lstContacts.Items.Add(lsContacts[i].LastName, lsContacts[i].Gender.ToLower() == "male" ? "male.png" : "female.png");
                }
            }
          
        }
        /// <summary>
        /// loading view of selected contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewContact();
        }
        /// <summary>
        /// Editing an existing contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlNew.Visible = true;
            pnlListView.Visible = false;
            pnlView.Visible = false;
            var contact = lsContacts.Find(x => x.LastName == txtLName.Text);
            Lastname = contact.LastName;
            txtLastName.Text = contact.LastName;
            txtFirstName.Text = contact.FirstName;
            txtPhone.Text = contact.PhoneNo;
            txtEmail.Text = contact.Email;
            if (contact.Gender.ToLower() == "male")
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
        }
        /// <summary>
        /// Deleting an existing contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var contact = lsContacts.Find(x => x.LastName == txtLName.Text);
            if (contact != null)
            {
                if (MessageBox.Show("Do you want to delete this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lsContacts.Remove(contact);
                    pnlNew.Visible = false;
                    pnlListView.Visible = true;
                    pnlView.Visible = false;
                    LoadList(false);
                }
            }
        }
        /// <summary>
        /// Buisness Logic to view details of selected contact
        /// </summary>
        private void ViewContact()
        {
            if (lstContacts.SelectedItems.Count > 0)
            {
                pnlNew.Visible = false;
                pnlListView.Visible = false;
                pnlView.Visible = true;
                var contact = lsContacts.Find(x => x.LastName == lstContacts.SelectedItems[0].Text);
                txtLName.Text = contact.LastName;
                txtFname.Text = contact.FirstName;
                txtPNo.Text = contact.PhoneNo;
                txtMail.Text = contact.Email;
                picGender.Image = contact.Gender.ToLower() == "male" ? UmholtzTomas_Assignment02b.Properties.Resources.male : UmholtzTomas_Assignment02b.Properties.Resources.female;
            }
        }
        /// <summary>
        /// contact list click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstContacts_Click(object sender, EventArgs e)
        {
            ViewContact();
        }
        /// <summary>
        /// Validating form before saving contact details
        /// </summary>
        /// <returns></returns>
        private bool IsValid()
        {
            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && (rdFemale.Checked == true || rdMale.Checked == true))
            {
                if (IsValidEmail() && txtPhone.Text.Length>=10)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// restricting character entry only to first name box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        /// <summary>
        /// restricting character entry only to last name box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        /// <summary>
        /// validating Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            IsValidEmail();
        }
        /// <summary>
        /// Buisness logic too valid Email
        /// </summary>
        /// <returns></returns>
        private bool IsValidEmail()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                txtEmail.ForeColor = Color.Red;
                return false;
            }
            else
            {
                txtEmail.ForeColor = Color.Black;
                return true;
            }
        }
    }
}
