using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ThreeLayerCore;
using System.Collections.Generic;
using System.Drawing;
using System.Collections;
using System.Text;

namespace SearchDocs
{
    public partial class Form1 : Form
    {
        #region Parameters
        private BUS bus;

        private List<ThreeLayerCore.DTO.Group> groupFromXML;

        private ThreeLayerCore.DTO.Group selectedGroup;
        private ThreeLayerCore.DTO.SubGroup selectedSubGroup;
        private ThreeLayerCore.DTO.Assembly selectedAssembly;

        private DataTable logicRFromDB;

        DataTable datatable_tab1;
        DataTable datatable_tab2;


        DataRow selectedRow;

        #endregion


        #region Form 1 Init
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Left = 0;
            Top = 0;

            //例文参照 init
            bus = new BUS();
            if (!bus.isRead)
            {
                MessageBox.Show("Can't connect to DB, please check again!");
            }
            SetActiveSearchtxb();
            SetActivebtnImport();

            //ロジック参照　init
            //datagrdLogicR.CellClick += DataGridViewAddLocic_CellClick;
            selectedGroup = new ThreeLayerCore.DTO.Group("", "");
            selectedSubGroup = new ThreeLayerCore.DTO.SubGroup("", "");
            selectedAssembly = new ThreeLayerCore.DTO.Assembly("", "");

            linkFile1.Text = "";
            linkFile2.Text = "";
            linkFile3.Text = "";


            lbLogicRTitle.Text = "";

            logicRFromDB = new DataTable();

        }

        public void SetTabindexSearchtxb()
        {
            txbSearch1.TabIndex = 0;
            txbSearch2.TabIndex = 1;
            txbSearch3.TabIndex = 2;
            txbSearch4.TabIndex = 3;
            txbSearch5.TabIndex = 4;
        }
        public void SetActiveSearchtxb()
        {
            if (datagrid.Rows.Count > 0)
            {
                txbSearch1.Enabled = true;
                txbSearch2.Enabled = true;
                txbSearch3.Enabled = true;
                txbSearch4.Enabled = true;
                txbSearch5.Enabled = true;

                cbx1.Enabled = true;
                cbx2.Enabled = true;
                cbx3.Enabled = true;
                cbx4.Enabled = true;
            }
            else
            {
                txbSearch1.Enabled = false;
                txbSearch2.Enabled = false;
                txbSearch3.Enabled = false;
                txbSearch4.Enabled = false;
                txbSearch5.Enabled = false;

                cbx1.Enabled = false;
                cbx2.Enabled = false;
                cbx3.Enabled = false;
                cbx4.Enabled = false;

            }
        }
        public void SetActivebtnImport()
        {
            if (txbFilePath.Text.ToString() == "")
            {
                btnReadFile.Enabled = false;
            }
            else
                btnReadFile.Enabled = true;
        } 
        #endregion


        #region　例文参照　ファイル取込
        private void BrowseFilePath(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Excel or XML Files",

                CheckFileExists = true,
                CheckPathExists = true,

                //DefaultExt = "txt",
                Filter = "Excel Files and XML|*.xls;*.xlsx;*.xlsm;*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txbFilePath.Text = openFileDialog1.FileName;
            }
        }
        private void TxbFilePath_TextChanged(object sender, EventArgs e)
        {
            SetActivebtnImport();
        }
        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            string myFilePath = txbFilePath.Text.ToString();
            string ext = Path.GetExtension(myFilePath);

            bool result = false;

            if (ext == ".xml")
            {
                result = bus.InsertMessFromXML(myFilePath);
            }
            else
            {
                result = bus.GetExcelFile(txbFilePath.Text.ToString());
            }

            if (result)
            {
                txbFilePath.Text = "";
                MessageBox.Show("データの取込が完了しました。");
            }
            else
            {
                MessageBox.Show("データの取込が失敗しました。ファイルを再度チェックしてください");
            }

        }

        #endregion


        #region 例文参照　DB取込
        private void BtnLoadDB(object sender, EventArgs e)
        {
            LoadFromDB();
        }
        public void LoadFromDB()
        {
            ResetDatagridview();

            datatable_tab1 = new DataTable();


            if (rdioSentence.Checked)
            {
                //get sentence
                datatable_tab1 = bus.GetSentence();
            }
            else if (rdioMess.Checked)
            {
                //get message
                datatable_tab1 = bus.GetMessage();
                datatable_tab1.Columns.Remove("メッセージコード");
            }


            datagrid.DataSource = datatable_tab1;

            SetActiveSearchtxb();
            SetTabindexSearchtxb();

            BindDataCombobox();
        }
        public void BindDataCombobox()
        {
            cbx1.SelectedIndex = 0;
            cbx2.SelectedIndex = 0;
            cbx3.SelectedIndex = 0;
            cbx4.SelectedIndex = 0;

        }
        private void ResetDatagridview()
        {
            datagrid.CancelEdit();
            datagrid.Columns.Clear();
            datagrid.DataSource = null;

            datagrid.AutoResizeColumns();
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagrid.AutoResizeRows();
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.RowHeadersVisible = false;
        }
        private void RdioMess_CheckedChanged(object sender, EventArgs e)
        {
            LoadFromDB();
            RefreshtxbSearch_tab1();
        }
        private void RdioSentence_CheckedChanged(object sender, EventArgs e)
        {
            LoadFromDB();
            RefreshtxbSearch_tab1();
        }

        #endregion


        #region 例文参照　検索テキストボックス
        private void TxbSearch2_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab1();
        }
        private void TxbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab1();
        }
        private void TxbSearch3_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab1();
        }
        private void TxbSearch4_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab1();
        }
        private void TxbSearch5_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab1();
        }
        public string ConditionSearch_tab1(string[] keyWords)
        {
            string outputInfo = "";
            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(例文 LIKE '%" + word + "%')";
                }
                else
                {
                    outputInfo += " AND (例文 LIKE '%" + word + "%')";
                }
            }

            return outputInfo;
        }

        public string ConditionSearch_tab2(string[] keyWords)
        {
            string outputInfo = "";
            foreach (string word in keyWords)
            {
                if (outputInfo.Length == 0)
                {
                    outputInfo = "(タイトル LIKE '%" + word + "%')";
                }
                else
                {
                    outputInfo += " AND (タイトル LIKE '%" + word + "%')";
                }
            }

            return outputInfo;
        }

        public string GetFilter_tab1()
        {
            string outputInfo = "";

            if (txbSearch1.Text.ToString() != "")
            {
                outputInfo = string.Concat(outputInfo, ConditionSearch_tab1(txbSearch1.Text.Split(' ')));
            }
            if (txbSearch2.Text.ToString() != "")
            {
                if (outputInfo != "")
                {
                    outputInfo = string.Concat(outputInfo, " ", cbx1.SelectedItem.ToString(), " ");
                }
                outputInfo = string.Concat(outputInfo, ConditionSearch_tab1(txbSearch2.Text.Split(' ')));
            }
            if (txbSearch3.Text.ToString() != "")
            {
                if (outputInfo != "")
                {
                    outputInfo = string.Concat(outputInfo, " ", cbx2.SelectedItem.ToString(), " ");
                }
                outputInfo = string.Concat(outputInfo, ConditionSearch_tab1(txbSearch3.Text.Split(' ')));
            }
            if (txbSearch4.Text.ToString() != "")
            {
                if (outputInfo != "")
                {
                    outputInfo = string.Concat(outputInfo, " ", cbx3.SelectedItem.ToString(), " ");
                }
                outputInfo = string.Concat(outputInfo, ConditionSearch_tab1(txbSearch4.Text.Split(' ')));
            }
            if (txbSearch5.Text.ToString() != "")
            {
                if (outputInfo != "")
                {
                    outputInfo = string.Concat(outputInfo, " ", cbx4.SelectedItem.ToString(), " ");
                }
                outputInfo = string.Concat(outputInfo, ConditionSearch_tab1(txbSearch5.Text.Split(' ')));
            }

            return outputInfo;
        }

        public string GetFilter_tab2()
        {
            string outputInfo = "";

            if (txbLogicSearch1.Text.ToString() != "")
            {
                outputInfo = string.Concat(outputInfo, ConditionSearch_tab2(txbLogicSearch1.Text.Split(' ')));
            }

            return outputInfo;
        }

        private void Cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTable_tab1();
        }
        private void FilterTable_tab1()
        {
            datatable_tab1.DefaultView.RowFilter = GetFilter_tab1();
        }

        private void FilterTable_tab2()
        {
            datatable_tab2.DefaultView.RowFilter = GetFilter_tab2();
        }
        private void Cbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTable_tab1();
        }
        private void Cbx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTable_tab1();
        }
        private void Cbx4_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTable_tab1();
        }
        private void BtnClear_Click(object sender, EventArgs e) => RefreshtxbSearch_tab1();
        public void RefreshtxbSearch_tab1()
        {
            txbSearch1.Text = "";
            txbSearch2.Text = "";
            txbSearch3.Text = "";
            txbSearch4.Text = "";
            txbSearch5.Text = "";


            datatable_tab1.DefaultView.RowFilter = "";
        }
        public void RefreshtxbSearch_tab2()
        {
            txbLogicSearch1.Text = "";

            datatable_tab2.DefaultView.RowFilter = "";
        }
        #endregion


        #region 例文参照　テストデータ削除
        private void Button1_Click(object sender, EventArgs e)
        {
            if (bus.DeleteWorkbook(-2) &&
                bus.DeleteSheet(-2) &&
                bus.DeleteSentence(-2) &&
                bus.DeleteMessage(-2))
            {
                MessageBox.Show("Delete complete");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (bus.DeleteWorkbook(-2) && bus.DeleteSheet(-2) && bus.DeleteSentence(-2))
            {
                MessageBox.Show("Delete complete");
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (bus.DeleteMessage(-2))
            {
                MessageBox.Show("Delete complete");
            }
        }
        #endregion


        #region ロジック参照　XML取込
        private void TabDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTab = tabDocs.SelectedTab.Text;
            if (selectedTab == "ロジック参照")
            {
                txbLogicSearch1.Enabled = false;
                LoadTreeview();
                //Write();
            }
        }

        private void LoadTreeview()
        {
            treeviewR.Nodes.Clear();
            ResetDatagridviewLogicR();

            groupFromXML = new List<ThreeLayerCore.DTO.Group>(bus.GetTreeviewFromXML(@"menu_A1.xml"));


            foreach (var g in groupFromXML)
            {
                TreeNode group = new TreeNode
                {
                    Text = g.Text,
                    Name = g.Name.ToString()
                };
                group.Collapse();
                treeviewR.Nodes.Add(group);

                foreach (var s in g.subGroups)
                {
                    TreeNode subGroup = new TreeNode
                    {
                        Text = s.Text,
                        Name = s.Name.ToString()
                    };
                    treeviewR.Nodes[group.Name].Nodes.Add(subGroup);

                    foreach (var a in s.assemblies)
                    {
                        TreeNode assembly = new TreeNode
                        {
                            Text = a.Text,
                            Name = a.Name.ToString()
                        };
                        treeviewR.Nodes[group.Name].Nodes[subGroup.Name].Nodes.Add(assembly);
                    }
                }
            }
        }

        public void Write()
        {
            //try
            //{
            //    File.WriteAllText(@"TreeViewR.xml", "");
            //}
            //catch
            //{

            //}

            //XmlDocument xmlDoc = new XmlDocument();

            //XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //XmlElement root = xmlDoc.DocumentElement;
            //xmlDoc.InsertBefore(xmlDeclaration, root);

            //XmlNode rootNode = xmlDoc.CreateElement("root");
            //xmlDoc.AppendChild(rootNode);

            //for (int i = 0; i < treeviewR.Nodes.Count; i++)
            //{                
            //    XmlNode categoryNote = xmlDoc.CreateElement("Category");
            //    XmlAttribute id = xmlDoc.CreateAttribute("id");
            //    id.Value = i.ToString();
            //    categoryNote.Attributes.Append(id);

            //    XmlAttribute name = xmlDoc.CreateAttribute("name");
            //    name.Value = treeviewR.Nodes[i].Text;
            //    categoryNote.Attributes.Append(name);

            //    for (int j = 0; j < treeviewR.Nodes[i].Nodes.Count; j++)
            //    {
            //        XmlNode assembly = xmlDoc.CreateElement("Child");
            //        XmlAttribute childId = xmlDoc.CreateAttribute("id");
            //        childId.Value = j.ToString();
            //        assembly.Attributes.Append(childId);

            //        assembly.InnerText = treeviewR.Nodes[i].Nodes[j].Text;
            //        categoryNote.AppendChild(assembly);
            //    }

            //    rootNode.AppendChild(categoryNote);

            //}

            //xmlDoc.Save(@"TreeViewR.xml");
        }
        private void ResetDatagridviewLogicR()
        {
            datagrdLogicR.CancelEdit();
            datagrdLogicR.Columns.Clear();
            if (datagrdLogicR.Rows.Count > 0)
                datagrdLogicR.Rows.Clear();
            datagrdLogicR.Refresh();
            datagrdLogicR.DataSource = null;

            datagrdLogicR.AutoResizeColumns();
            datagrdLogicR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagrdLogicR.AutoResizeRows();
            datagrdLogicR.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrdLogicR.RowHeadersVisible = false;
        } 
        #endregion

        #region ロジック参照　ファイル保存／取得テスト
        public void SaveFileToDB()
        {
            string filePath = @"C:\0. TEMP\大阪廃棄物処理さん.pdf";
            string connectionString = @"Data Source=PC-29-051;Initial Catalog=SekkeiFinding;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=Jm203388;Connect Timeout=20;Encrypt=False";
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);
            byte[] file = reader.ReadBytes((int)stream.Length);
            reader.Close();
            stream.Close();

            SqlCommand command;
            SqlConnection connection = new SqlConnection(connectionString);
            command = new SqlCommand("INSERT INTO FileTable (FileID, Data) Values(@ID, @File)", connection);
            command.Parameters.Add("@File", SqlDbType.Binary, file.Length).Value = file;
            command.Parameters.Add("@ID", SqlDbType.Int, file.Length).Value = 1;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void GetFileFromDB()
        {
            string connectionString = @"Data Source=PC-29-051;Initial Catalog=SekkeiFinding;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=Jm203388;Connect Timeout=20;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            string query =
            @" SELECT Data FROM FileTable where FileID =" + 1;
            SqlCommand command = new SqlCommand(query, connection);

            int bufferSize = 100;
            byte[] outByte = new byte[bufferSize];

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.Default);

            DataTable dataTable = new DataTable();
            //Fill the data table
            dataTable.Load(reader);
            if (dataTable.Rows.Count == 1)
            {
                //Retrieve the PDF file from the data table
                byte[] buffer = (byte[])dataTable.Rows[1]["Data"];
                //Save the PDF file
                using (FileStream fstream = new FileStream("Helloworld.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fstream.Write(buffer, 0, buffer.Length);
                }
                System.Diagnostics.Process.Start("Helloworld.pdf");
            }
            else
            {
                MessageBox.Show("該当ファイルが存在しないため、再度試して下さい。");
            }
            reader.Close();
            connection.Close();
        }
        private void BtnLogicDelete(object sender, EventArgs e)
        {
            int groupID = int.Parse(selectedRow["GroupID"].ToString());
            int subGroupID = int.Parse(selectedRow["SubGroupID"].ToString());
            int assemblyID = int.Parse(selectedRow["AssemblyID"].ToString());
            int logicID = int.Parse(selectedRow["LogicID"].ToString());

            bool result = bus.UpdateLogicDeleteFlag(groupID, subGroupID, assemblyID, logicID);

            if(result)
            {
                MessageBox.Show("削除処理が完了しました。");
                ResetDatagridviewLogicR();
                FillDataGridviewLogicR();
            }
            else
            {
                MessageBox.Show("削除が出来ませんでした。再度実行してください。");
            }
        }

        private void BtnEditLogic(object sender, EventArgs e)
        {
            int groupID = int.Parse(selectedRow["GroupID"].ToString());
            int subGroupID = int.Parse(selectedRow["SubGroupID"].ToString());
            int assemblyID = int.Parse(selectedRow["AssemblyID"].ToString());
            int logicID = int.Parse(selectedRow["LogicID"].ToString());
            string group = GetGroupText(selectedRow["GroupID"].ToString());
            string subGroup = GetSubGroupText(selectedRow["GroupID"].ToString(), selectedRow["SubGroupID"].ToString());
            string assembly = GetAssemblyText(selectedRow["GroupID"].ToString(), selectedRow["SubGroupID"].ToString(), selectedRow["AssemblyID"].ToString());
            string title = selectedRow["Title"].ToString();
            string logic = selectedRow["Logic"].ToString();
            string filename1 = selectedRow["FileName1"].ToString();
            byte[] data1 = (byte[])selectedRow["FileData1"];
            string filename2 = selectedRow["FileName2"].ToString();
            byte[] data2 = (byte[])selectedRow["FileData2"];
            string filename3 = selectedRow["FileName3"].ToString();
            byte[] data3 = (byte[])selectedRow["FileData3"];


            var myform = new AddLogic(groupID, subGroupID, assemblyID, logicID, group, subGroup, assembly, title, logic, filename1, data1, filename2, data2, filename3, data3);
            myform.ShowDialog();

            FillDataGridviewLogicR();
        }
        #endregion

        #region ロジック参照　DB取込

        public void FillDataGridviewLogicR()
        {
            bool result = GetLogicFromDB();

            if (result)
            {
                
                UpdateDetail(0);
                txbLogicSearch1.Enabled = true;

            }
            else
            {
                UpdateDetail(1);
                txbLogicSearch1.Enabled = false;

            }

            for (int j = 1; j < datagrdLogicR.RowCount; j++)
            {
                DataGridViewRow r = datagrdLogicR.Rows[j];
                for (int i = 0; i < datagrdLogicR.ColumnCount; i++)
                {
                    r.Cells[i].Style.BackColor = Color.White;
                    r.Cells[i].Style.ForeColor = Color.Black;
                }
            }
        }

        public void updateSelectedRow(DataGridViewCellEventArgs e)
        {
            try
            {
                int groupID = int.Parse(datagrdLogicR.Rows[e.RowIndex].Cells["GroupID"].Value.ToString());
                int subgroupID = int.Parse(datagrdLogicR.Rows[e.RowIndex].Cells["SubGroupID"].Value.ToString());
                int assemblyID = int.Parse(datagrdLogicR.Rows[e.RowIndex].Cells["AssemblyID"].Value.ToString());
                int logicID = int.Parse(datagrdLogicR.Rows[e.RowIndex].Cells["LogicID"].Value.ToString());

                //var rows = logicRFromDB.AsEnumerable().Where(r => (r.Field<int>("GroupID").Equals(groupID)) &&
                //                                                   (r.Field<int>("SubGroupID").Equals(subgroupID)) &&
                //                                                   (r.Field<int>("AssemblyID").Equals(assemblyID)) &&
                //                                                   (r.Field<int>("LogicID").Equals(assemblyID)));

                //foreach(DataRow r in logicRFromDB.Rows)
                //{
                //    if(r["GroupID"].Equals(groupID) && r["SubGroupID"].Equals(subgroupID) &&
                //        r["AssemblyID"].Equals(assemblyID) && r["LogicID"].Equals(logicID)
                //}
                var rows = from r in logicRFromDB.AsEnumerable()
                        where r.Field<int>("GroupID").Equals(groupID) &&
                              r.Field<int>("SubGroupID").Equals(subgroupID) &&
                              r.Field<int>("AssemblyID").Equals(assemblyID) &&
                              r.Field<int>("LogicID").Equals(logicID)
                        select r;

                if (rows != null)
                {
                    DataTable t = rows.CopyToDataTable();

                    selectedRow = t.Rows[0];
                }
                

            }
            catch(Exception f)
            {
                var a = 1;
            }

            

        }
        private void TreeviewR_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateSelectedNote(e);

            FillDataGridviewLogicR();

        }

        private void TreeviewR_AfterExpand(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show("after expand:" + GetNoteFamily(e));
            treeviewR.SelectedNode = e.Node;
        }

        private void TreeviewR_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show("after collapse:" + GetNoteFamily(e));
            treeviewR.SelectedNode = e.Node;
        }

        private string GetGroupText(string groupName)
        {
            var group = groupFromXML.Find(x => x.Name == groupName);
            return group.Text;
        }

        private string GetSubGroupText(string groupName, string subGroupName)
        {
            var g = groupFromXML.Find(x => x.Name == groupName);
            var subGroup = g.subGroups.Find(x => x.Name == subGroupName);
            return subGroup.Text;
        }

        private string GetAssemblyText(string groupName, string subGroupName, string assemblyName)
        {
            var g = groupFromXML.Find(x => x.Name == groupName);
            var s = g.subGroups.Find(y => y.Name == subGroupName);
            var assembly = s.assemblies.Find(x => x.Name == assemblyName);
            return assembly.Text;
        }


        public void UpdateSelectedNote(TreeViewEventArgs e)
        {
            ResetDatagridviewLogicR();
            DataTable dt = new DataTable();

            if (e.Node.Parent == null)
            {
                selectedGroup.Clone(groupFromXML.Find(x => x.Name == e.Node.Name.ToString()));
                selectedSubGroup.Refresh();
                selectedAssembly.Refresh();
            }
            else
            {
                if (e.Node.Parent.Parent == null)
                {
                    selectedSubGroup.Clone(selectedGroup.subGroups.Find(x => x.Name == e.Node.Name.ToString()));
                    selectedAssembly.Refresh();
                }
                else
                {
                    selectedAssembly.Clone(selectedSubGroup.assemblies.Find(x => x.Name == e.Node.Name.ToString()));
                }
            }
        }

        public bool GetLogicFromDB()
        {
            logicRFromDB.Clear();
            logicRFromDB = bus.GetLogicR(selectedGroup.Name, selectedSubGroup.Name, selectedAssembly.Name);


            if (logicRFromDB.Rows.Count > 0)
            {
                datatable_tab2 = new DataTable();
                datatable_tab2.Columns.Add("GroupID", typeof(int));
                datatable_tab2.Columns.Add("大分類", typeof(string));
                datatable_tab2.Columns.Add("SubGroupID", typeof(int));
                datatable_tab2.Columns.Add("中分類", typeof(string));
                datatable_tab2.Columns.Add("AssemblyID", typeof(int));
                datatable_tab2.Columns.Add("画面名", typeof(string));                
                datatable_tab2.Columns.Add("LogicID", typeof(int));
                datatable_tab2.Columns.Add("タイトル", typeof(string));

                //datatable.Columns.Add("内容", typeof(string));

                foreach (DataRow row in logicRFromDB.Rows)
                {
                    if (!(bool)row[12])
                    {
                        ArrayList al = new ArrayList
                        {
                            row[0],
                            GetGroupText(row[0].ToString()),
                            row[1],
                            GetSubGroupText(row[0].ToString(), row[1].ToString()),
                            row[2],
                            GetAssemblyText(row[0].ToString(), row[1].ToString(), row[2].ToString()),
                            row[3],
                            row[4].ToString()
                        };
                        datatable_tab2.Rows.Add(al.ToArray());
                    }

                }

                datagrdLogicR.DataSource = datatable_tab2;

                datagrdLogicR.Columns["GroupID"].Visible = false;
                datagrdLogicR.Columns["SubGroupID"].Visible = false;
                datagrdLogicR.Columns["AssemblyID"].Visible = false;
                datagrdLogicR.Columns["LogicID"].Visible = false;


                foreach (DataGridViewColumn dgvc in datagrdLogicR.Columns)
                {
                    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                return true;

            }
            else
            {
                return false;
            }
        }

           
        #endregion

        private void BtnAddLogic_Click(object sender, EventArgs e)
        {

            var myForm = new AddLogic(groupFromXML, selectedGroup, selectedSubGroup, selectedAssembly);
            myForm.ShowDialog();
            FillDataGridviewLogicR();

        }

        private void DatagrdLogicR_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDetail(int type)
        {
            if (type == 0)
            {
                var title = selectedRow["Title"].ToString();
                var logic = selectedRow["Logic"].ToString();
                var fileName1 = selectedRow["FileName1"].ToString();
                var fileName2 = selectedRow["FileName2"].ToString();
                var fileName3 = selectedRow["FileName3"].ToString();

                lbLogicRTitle.Text = title.ToString();
                txbLogic.Text = logic.ToString();
                linkFile1.Text = fileName1.ToString();
                linkFile2.Text = fileName2.ToString();
                linkFile3.Text = fileName3.ToString();
            }
            else
            {
                lbLogicRTitle.Text = "";
                txbLogic.Text = "";
                linkFile1.Text = "";
                linkFile2.Text = "";
                linkFile3.Text = "";
            }
        }

        private void DatagrdLogicR_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           // datagrdLogicR.CurrentRow.DefaultCellStyle.BackColor = Color.Maroon;
            //datagrdLogicR.CurrentRow.DefaultCellStyle.ForeColor = Color.White;

            if (logicRFromDB.Rows.Count > e.RowIndex && e.RowIndex >= 0)
            {
                updateSelectedRow(e);
                UpdateDetail(0);
            }
            else
            {
                selectedRow = null;
                UpdateDetail(1);
            }

        }

        private bool DownloadFile(int fileNumber)
        {
            //Create save folder dialog

            var folderBrowserDialog1 = new FolderBrowserDialog();

            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;

                try
                {
                    byte[] buffer;
                    string filePath = "";

                    if (fileNumber == 1)
                    {
                        buffer = (byte[])selectedRow["FileData1"];
                        filePath = folderName + @"\" + linkFile1.Text.ToString();
                    }
                    else if (fileNumber == 2)
                    {
                        buffer = (byte[])selectedRow["FileData2"];
                        filePath = folderName + @"\" + linkFile2.Text.ToString();
                    }
                    else if (fileNumber == 3)
                    {
                        buffer = (byte[])selectedRow["FileData3"];
                        filePath = folderName + @"\" + linkFile3.Text.ToString();
                    }
                    else
                        return false;

                    //Save the PDF file
                    
                    using (FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        fstream.Write(buffer, 0, buffer.Length);
                    }
                    System.Diagnostics.Process.Start(filePath);

                    return true;
                }
                catch
                {
                    MessageBox.Show("該当ファイルが存在しないため、再度試して下さい。");
                    return false;
                }
            }
            else
                return false;
        }
        private void LinkFile1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkFile1.Text != "")
            {
                bool result = DownloadFile(1);
            }
        }

        private void LinkFile2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkFile2.Text != "")
            {
                bool result = DownloadFile(2);
            }
        }

        private void LinkFile3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkFile3.Text != "")
            {
                bool result = DownloadFile(3);
            }
        }

        private void datagrdLogicR_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void datagrdLogicR_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txbLogicSearch1_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab2();
        }

        private void txbLogicSearch2_KeyUp(object sender, KeyEventArgs e)
        {
            FilterTable_tab2();
        }

        private void cbxLogicCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTable_tab2();
        }

        private void datagrdLogicR_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            updateSelectedRow(e);

        }
    }
}

