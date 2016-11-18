using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace UmholtzTomas_Assignment02a
{
    public partial class Form1 : Form
    {
        ArrayList lsHave = new ArrayList();
        ArrayList lsNeed = new ArrayList();
        string txtToAppend = "> ";
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Moving selected item from HAVE list to NEED list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picRight_Click(object sender, EventArgs e)
        {
            if (lstHave.SelectedIndex >= 0)
            {
                lsNeed.Add(txtToAppend + lstHave.SelectedItem.ToString().Split(' ')[1]);
                lsHave.Remove(lstHave.SelectedItem);
                lstHave.DataSource = null;
                lstNeed.DataSource = null;
                lstHave.DataSource = lsHave;
                lstNeed.DataSource = lsNeed;
            }
            else
                MessageBox.Show("Please select an item to move.");
        }
        /// <summary>
        /// Moving selected item from NEED to HAVE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picLeft_Click(object sender, EventArgs e)
        {
            if (lstNeed.SelectedIndex >= 0)
            {
                lsHave.Add(txtToAppend + lstNeed.SelectedItem.ToString().Split(' ')[1]);
                lsNeed.Remove(lstNeed.SelectedItem);
                lstHave.DataSource = null;
                lstNeed.DataSource = null;
                lstNeed.DataSource = lsNeed;
                lstHave.DataSource = lsHave;
            }
            else
                MessageBox.Show("Please select an item to move.");
        }
        /// <summary>
        /// Deleting selected item from NEED & HAVE list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picDelete_Click(object sender, EventArgs e)
        {
            if (lstNeed.SelectedIndex >= 0)
                lsNeed.Remove(lstNeed.SelectedItem);

            if (lstHave.SelectedIndex >= 0)
                lsHave.Remove(lstHave.SelectedItem);

            lstHave.DataSource = null;
            lstNeed.DataSource = null;
            lstNeed.DataSource = lsNeed;
            lstHave.DataSource = lsHave;
        }
        /// <summary>
        /// Adding entered text to HAVE list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHave_Click(object sender, EventArgs e)
        {
            if (txtItem.Text != "")
            {
                lsHave.Add(txtToAppend + txtItem.Text);
                txtItem.Text = "";
                lstHave.DataSource = null;
                lstHave.DataSource = lsHave;
            }
            else
                MessageBox.Show("Please enter text to add");
        }
        /// <summary>
        /// Adding entered text to NEED list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNeed_Click(object sender, EventArgs e)
        {
            if (txtItem.Text != "")
            {
                lsNeed.Add(txtToAppend + txtItem.Text);
                txtItem.Text = "";
                lstNeed.DataSource = null;
                lstNeed.DataSource = lsNeed;
            }
            else
                MessageBox.Show("Please enter text to add");
        }
        /// <summary>
        /// Saving list items to XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                string filename = "";
                filename = sv.FileName.IndexOf('.') > 0 ? sv.FileName.Substring(0, sv.FileName.IndexOf('.')) + ".xml" : sv.FileName + ".xml";

                XmlDocument xmlDoc = new XmlDocument();
                XmlNode rootNode = xmlDoc.CreateElement("PartyList");
                xmlDoc.AppendChild(rootNode);
                for (int i = 0; i < lstHave.Items.Count; i++)
                {
                    XmlNode userNode = xmlDoc.CreateElement("Item");
                    XmlAttribute attribute = xmlDoc.CreateAttribute("listType");
                    attribute.Value = "Have";
                    userNode.Attributes.Append(attribute);
                    userNode.InnerText = lstHave.Items[i].ToString();
                    rootNode.AppendChild(userNode);
                }
                for (int i = 0; i < lstNeed.Items.Count; i++)
                {
                    XmlNode userNode = xmlDoc.CreateElement("Item");
                    XmlAttribute attribute = xmlDoc.CreateAttribute("listType");
                    attribute.Value = "Need";
                    userNode.Attributes.Append(attribute);
                    userNode.InnerText = lstNeed.Items[i].ToString();
                    rootNode.AppendChild(userNode);
                }
                xmlDoc.Save(filename);
                if(MessageBox.Show("Party list saved successfully!!!")==DialogResult.OK)
                {
                    lsHave.Clear();
                    lsNeed.Clear();
                    lstHave.DataSource = null;
                    lstNeed.DataSource = null;
                    lstHave.DataSource = lsHave;
                    lstNeed.DataSource = lsNeed;
                }
            }
        }
        /// <summary>
        /// Loading xml to load HAVE & NEED list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                lsHave.Clear();
                lsNeed.Clear();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(op.FileName);
                XmlNodeList userNodes = xmlDoc.SelectNodes("//PartyList/Item");
                foreach (XmlNode userNode in userNodes)
                {
                    if (userNode.Attributes["listType"].Value == "Have")
                        lsHave.Add(userNode.InnerText);
                    else
                        lsNeed.Add(userNode.InnerText);
                }
                lstHave.DataSource = null;
                lstNeed.DataSource = null;
                lstHave.DataSource = lsHave;
                lstNeed.DataSource = lsNeed;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
