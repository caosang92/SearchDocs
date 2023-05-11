using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SearchDocs
{
    public partial class AddLogic : Form
    {
        private const string fileType = "PDF Files and Image|*.pdf;*.png;*.jpeg;*.jpg";
        List<ThreeLayerCore.DTO.Group> groups;

        ThreeLayerCore.BUS bus;

        string linkFile1 = "";
        string linkFile2 = "";
        string linkFile3 = "";

        int groupID, subGroupID, assemblyID, logicID;

        string title, logic, filename1, filename2, filename3;

        byte[] data1, data2, data3;

        int mode;

        public AddLogic(int groupid, int subgroupid, int assemblyid, int logicid, string group, string subgroup, string assembly, string title, string logic, string filename1, byte[] data1, string filename2, byte[] data2, string filename3, byte[] data3)
        {
            Init();

            groupID = groupid;
            subGroupID = subgroupid ;
            assemblyID = assemblyid;
            logicID = logicid;
            this.title = title;
            this.logic = logic;
            this.filename1 = filename1;
            this.filename2 = filename2;
            this.filename3 = filename3;
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;

            txbAddTitle.Text = this.title;
            txbLogic.Text = this.logic;

            lblUploadFile1.Text = filename1;
            lblUploadFile2.Text = filename2;
            lblUploadFile3.Text = filename3;

            cbxAddGroup.Text = group;
            cbxAddSubGroup.Text = subgroup;
            cbxAddAssembly.Text = assembly;

            cbxAddGroup.Enabled = false;
            cbxAddSubGroup.Enabled = false;
            cbxAddAssembly.Enabled = false;

            btnAddRegister.Text = "更新";
            Text = "ロジック修正";

            SetBtnBrowseActive();
            SetdeleteBtnActive();

            mode = 2;
        }

        public void Init()
        {
            InitializeComponent();

            bus = new ThreeLayerCore.BUS();

            StartPosition = FormStartPosition.Manual;
            Left = 0;
            Top = 0;

            data1 = new byte[0];
            data2 = new byte[0];
            data3 = new byte[0];
        }

        public AddLogic(List<ThreeLayerCore.DTO.Group> groups, ThreeLayerCore.DTO.Group g, ThreeLayerCore.DTO.SubGroup s, ThreeLayerCore.DTO.Assembly a)
        {
            Init();

            this.groups = new List<ThreeLayerCore.DTO.Group>(groups);

            cbxAddGroup.DataSource = this.groups;
            cbxAddGroup.DisplayMember = "Text";
            cbxAddGroup.ValueMember = "Name";

            int indexGroup = 0;
            int indexSubGroup = 0;
            int indexAssembly = 0;

            if (g.Name != "")
            {
                indexGroup = groups.FindIndex(x => x.Name == g.Name);
                if(s.Name != "")
                {
                    indexSubGroup = g.subGroups.FindIndex(x => x.Name == s.Name);
                    cbxAddSubGroup.DataSource = g.subGroups;
                    cbxAddSubGroup.DisplayMember = "Text";
                    cbxAddSubGroup.ValueMember = "Name";

                    if (a.Name != "")
                    {
                        indexAssembly = s.assemblies.FindIndex(x => x.Name == a.Name);
                        cbxAddAssembly.DataSource = s.assemblies;
                        cbxAddAssembly.DisplayMember = "Text";
                        cbxAddAssembly.ValueMember = "Name";
                        
                    }
                }
            }
            cbxAddGroup.SelectedIndex = indexGroup;
            cbxAddSubGroup.SelectedIndex = indexSubGroup;
            cbxAddAssembly.SelectedIndex = indexAssembly;


            btndeleteFile1.Visible = false;
            btndeleteFile2.Visible = false;
            btndeleteFile3.Visible = false;

            lblUploadFile1.Text = "";
            lblUploadFile2.Text = "";
            lblUploadFile3.Text = "";

            mode = 1;

        }

        private void BrowseFilePath(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse PDF or Image Files",

                CheckFileExists = true,
                CheckPathExists = true,

                //DefaultExt = "txt",
                Filter = fileType,
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txbAddFilePath.Text = openFileDialog1.FileName;
                if (lblUploadFile1.Text == "")
                {
                    linkFile1 = openFileDialog1.FileName;
                    lblUploadFile1.Text = openFileDialog1.SafeFileName;
                    btndeleteFile1.Visible = true;
                }
                else if(lblUploadFile2.Text == "")
                {
                    linkFile2 = openFileDialog1.FileName;
                    lblUploadFile2.Text = openFileDialog1.SafeFileName;
                    btndeleteFile2.Visible = true;
                }
                else if(lblUploadFile3.Text == "")
                {
                    linkFile3 = openFileDialog1.FileName;
                    lblUploadFile3.Text = openFileDialog1.SafeFileName;
                    btndeleteFile3.Visible = true;
                }
            }

            SetBtnBrowseActive();

        }

        public void SetBtnBrowseActive()
        {
            if(lblUploadFile1.Text != "" && lblUploadFile2.Text != "" && lblUploadFile3.Text != "")
            {
                btnAddFilePath.Enabled = false;
            }
            else
            {
                btnAddFilePath.Enabled = true;
            }
        }

        private void BtnAddRegister_Click(object sender, EventArgs e)
        {
            
            //check file 1, 2, 3 path
            string mess = "";
            if (linkFile1 != "" && !File.Exists(linkFile1))
            {
                mess += "アップロードファイル１";
            }
            if (linkFile2 != "" && !File.Exists(linkFile2))
            {
                if (mess != "")
                    mess += "\nアップロードファイル２";
                else
                    mess += "アップロードファイル２";
            }
            if (linkFile3 != "" && !File.Exists(linkFile3))
            {
                if (mess != "")
                    mess += "\nアップロードファイル３";
                else
                    mess += "アップロードファイル３";
            }
            if (mess != "")
            {
                mess += "が存在しないため、再度確認してください。";
                MessageBox.Show(mess);
                mess = "";
            }
            if (txbAddTitle.Text == "")
            {
                MessageBox.Show("タイトルが必須項目です。");
                return;
            }


            FileStream stream;
            BinaryReader reader;
            if (linkFile1 != "")
            {
                stream = new FileStream(linkFile1, FileMode.Open, FileAccess.Read);
                reader = new BinaryReader(stream);
                data1 = reader.ReadBytes((int)stream.Length);
                reader.Close();
                stream.Close();
            }

            if (linkFile2 != "")
            {
                stream = new FileStream(linkFile2, FileMode.Open, FileAccess.Read);
                reader = new BinaryReader(stream);
                data2 = reader.ReadBytes((int)stream.Length);
                reader.Close();
                stream.Close();
            }

            if (linkFile3 != "")
            {
                stream = new FileStream(linkFile3, FileMode.Open, FileAccess.Read);
                reader = new BinaryReader(stream);
                data3 = reader.ReadBytes((int)stream.Length);
                reader.Close();
                stream.Close();
            }

            if (mode == 1)
            {
                ThreeLayerCore.DTO.Group g = cbxAddGroup.SelectedItem as ThreeLayerCore.DTO.Group;
                ThreeLayerCore.DTO.SubGroup s = cbxAddSubGroup.SelectedItem as ThreeLayerCore.DTO.SubGroup;
                ThreeLayerCore.DTO.Assembly a = cbxAddAssembly.SelectedItem as ThreeLayerCore.DTO.Assembly;


                bool resutl = bus.InsertLogic(Int32.Parse(g.Name), Int32.Parse(s.Name), Int32.Parse(a.Name), txbAddTitle.Text, txbLogic.Text.ToString(), lblUploadFile1.Text, data1, lblUploadFile2.Text, data2, lblUploadFile3.Text, data3, false);

                if (resutl)
                {
                    MessageBox.Show("ロジックの登録が完了しました。");
                    RefreshSearch();
                }
                else
                    MessageBox.Show("ロジックの登録が失敗しました。");
            }
            else if (mode == 2)
            {
                if (data1 == null)
                    data1 = new byte[0];
                if (data2 == null)
                    data2 = new byte[0];
                if (data3 == null)
                    data3 = new byte[0];


                bool resutl = bus.UpdateLogic(groupID, subGroupID, assemblyID, logicID, txbAddTitle.Text, txbLogic.Text.ToString(), lblUploadFile1.Text, data1, lblUploadFile2.Text, data2, lblUploadFile3.Text, data3, false);
                if (resutl)
                {
                    MessageBox.Show("ロジックの更新が完了しました。");
                    this.Close();
                }
                else
                    MessageBox.Show("ロジックの更新が失敗しました。");
            }
                
        }

        private void CbxAddGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAddGroup.SelectedItem is ThreeLayerCore.DTO.Group selectGroup)
            {
                cbxAddSubGroup.DataSource = selectGroup.subGroups;
                cbxAddSubGroup.DisplayMember = "Text";
                cbxAddSubGroup.ValueMember = "Name";
            }

        }

        private void CbxAddSubGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAddSubGroup.SelectedItem is ThreeLayerCore.DTO.SubGroup selectSubGroup)
            {
                cbxAddAssembly.DataSource = selectSubGroup.assemblies;
                cbxAddAssembly.DisplayMember = "Text";
                cbxAddAssembly.ValueMember = "Name";
            }
        }

        private void BtndeleteFile1_Click(object sender, EventArgs e)
        {
            lblUploadFile1.Text = lblUploadFile2.Text;
            linkFile1 = linkFile2;
            data1 = data2;

            lblUploadFile2.Text = lblUploadFile3.Text;
            linkFile2 = linkFile3;
            data2 = data3;

            lblUploadFile3.Text = "";
            linkFile3 = "";
            data3 = null;

            SetdeleteBtnActive();
            SetBtnBrowseActive();
        }

        private void BtndeleteFile2_Click(object sender, EventArgs e)
        {
            lblUploadFile2.Text = lblUploadFile3.Text;
            linkFile2 = linkFile3;
            data2 = data3;

            lblUploadFile3.Text = "";
            linkFile3 = "";
            data3 = null;

            SetdeleteBtnActive();
            SetBtnBrowseActive();
        }

        private void BtndeleteFile3_Click(object sender, EventArgs e)
        {
            lblUploadFile3.Text = "";
            linkFile3 = "";
            data3 = null;

            SetdeleteBtnActive();
            SetBtnBrowseActive();
        }

        public void SetdeleteBtnActive()
        {
            if(lblUploadFile1.Text == "")
            {
                btndeleteFile1.Visible = false;
            }
            else
            {
                btndeleteFile1.Visible = true;
            }

            if (lblUploadFile2.Text == "")
            {
                btndeleteFile2.Visible = false;
            }
            else
            {
                btndeleteFile2.Visible = true;
            }

            if (lblUploadFile3.Text == "")
            {
                btndeleteFile3.Visible = false;
            }
            else
            {
                btndeleteFile3.Visible = true;
            }
        }

        private void BtnAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshSearch()
        {
            txbAddTitle.Text = "";
            txbLogic.Text = "";
            btndeleteFile1.Visible = false;
            linkFile1 = "";
            lblUploadFile1.Text = "";

            btndeleteFile2.Visible = false;
            linkFile2 = "";
            lblUploadFile2.Text = "";

            btndeleteFile3.Visible = false;
            linkFile3 = "";
            lblUploadFile3.Text = "";

            btnAddFilePath.Enabled = true;

        }


    }
}
