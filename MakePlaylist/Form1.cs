using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MakePlaylist
{
    public partial class Form1 : Form
    {
        private Color hColor = Color.FromArgb(183, 249, 174);
        private Color dupColor = Color.FromArgb(255, 140, 140);
        private CheckBox _checkHeader;
        private bool _isInit = true;
        private bool _customSort = true;
        private bool _extInf = true;

        public int test = 1;

        // NOT YET IMPLEMENTED
        private bool _findDup = false;

        public Form1()
        {
            InitializeComponent();

            IList<ExtPath> paths = new List<ExtPath> { 
                new ExtPath(){ id = Storage.Internal, pathName = ExtPath.INTERNAL_SD },
                new ExtPath(){ id = Storage.External, pathName = ExtPath.EXTERNAL_SD },
                new ExtPath(){ id = Storage.External2, pathName = ExtPath.EXTERNAL_SD2 },
            };
            DataGridViewComboBoxColumn cbox = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColPlaylistRoot"];
            cbox.DataSource = paths;
            cbox.DisplayMember = "pathName";
            cbox.ValueMember = "id";
            
            // Adds tooltip to the top menu items
            TSColumns.ToolTipText = "Toggles column visiblity.";
            TSCustSort.ToolTipText = "Allow or prevent custom #CSN tags. Also toggles the \"Sort Name\" column.\n#CSN tags are used to store custom sorting information.";
            TSExtInf.ToolTipText = "Allow or prevent #EXTINF tags when creating playlist.";

            // Adds tooltip to the Assume button    
            toolTip1.SetToolTip(BtnAssume, "Assumes that the Local Path is the same as the device file structure\nand sets the Playlist Path.\n\n"
                + "I.e.: if your file is in \"C:\\Music\\Instumental\\Song.mp3\",\n"
                + "This will set the Playlist Path to \"/Music/Instrumental/\"."
            );

            // Adds tooltip to the datagridview columns
            dataGridView1.Columns["ColPlaylistRoot"].ToolTipText = "Specifies the root directory of the file.\n\n"
                + "Select " + ExtPath.INTERNAL_SD + " if the file will be located in the internal storage of the device.\n"
                + "Select " + ExtPath.EXTERNAL_SD + " if the file will be located in an SD card.\n";
            dataGridView1.Columns["ColPlaylistPath"].ToolTipText = "Specifies the exact location of the file in the device.\nSet to blank if located in the root directory.";
            dataGridView1.Columns["ColLocalPath"].ToolTipText = "Shows the original location of the file to be added.";
            dataGridView1.Columns["ColCustom"].ToolTipText = "Add your custom sort name here to easily organize files.";

            // Create checkbox without panel
            _checkHeader = new CheckBox();
            _checkHeader.Size = new System.Drawing.Size(16, 16);
            _checkHeader.CheckedChanged += checkbox_CheckedChanged;
            _checkHeader.Location = new Point(8, 5);
            dataGridView1.Controls.Add(_checkHeader);
            
            InitializeForm();

            // NOT YET IMPLEMENTED, HIDE CONTROLS
            TSDup.ToolTipText = "Automatically detects duplicateentries based on title and file type.\n\nNOT YET IMPLEMENTED";
            TSDup.Visible = false;
            BtnSelect.Visible = false;
        }

        // Resets all items to their default values
        private void InitializeForm()
        {
            _isInit = true;
            panel1.BringToFront();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            TBFilename.Text = String.Empty;
            _checkHeader.Checked = false;
            LblItemCount.Text = "0 Items found";
            LblItemSelected.Text = "0 Items selected";
        }

        // Main function that adds files to datagrid
        private void PopulateGrid(string[] files)
        {
            forceToggleHeader(false);
            _isInit = false;

            // Temporarily remove CellEndEdit Event
            dataGridView1.CellEndEdit -= dataGridView1_CellEndEdit;

            if (files.Length > 0)
            {
                for (int x = 0; x < files.Length; x++)
                {
                    string sortName = String.Empty;
                    string extInf = String.Empty;
                    while (files[x][0] == '#' && x < files.Length)
                    {
                        // Find custom sorting comment
                        if (files[x].Contains("#CSN:"))
                        {
                            // Store sort name as playlist information. Unethical but should get the job done...
                            sortName = files[x].Substring(5);
                        }
                        else if (files[x].Contains("#EXTINF:"))
                        {
                            //Preserve playlist information. Users have the option to retain or delete this.
                            extInf = files[x];
                        }
                        // Ignore line if it is an extended M3U header (#EXTM3U)
                        x++;
                    }

                    string localPath = String.Empty;
                    Storage playlistRoot = Storage.Internal;
                    string playlistPath = String.Empty;
                    string file = files[x];

                    if (file[0] == '/')
                    {
                        // Assume that playlist or file is using unix file structure
                        localPath = file.Replace(Path.GetFileName(file), "");

                        string[] splitPath = localPath.Split('/');
                        if (splitPath[2] == "external_sd")
                            playlistRoot = Storage.External;
                        else if (splitPath[2] == "external_sd2")
                            playlistRoot = Storage.External2;

                        if (playlistRoot == Storage.Internal)
                            playlistPath = localPath.Replace(ExtPath.INTERNAL_SD, "");
                        else if (playlistRoot == Storage.External)
                            playlistPath = localPath.Replace(ExtPath.EXTERNAL_SD, "");
                        else
                            playlistPath = localPath.Replace(ExtPath.EXTERNAL_SD2, "");

                        playlistPath = SanitizePath(playlistPath);
                    }
                    else
                    {
                        // Assume that playlist or file is using windows file structure
                        localPath = Path.GetDirectoryName(file);
                    }

                    if (sortName == String.Empty)
                        sortName = Path.GetFileNameWithoutExtension(file);

                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Add()];
                    row.Cells["ColTitle"].Value = Path.GetFileNameWithoutExtension(file);
                    row.Cells["ColLocalPath"].Value = localPath;
                    row.Cells["ColPlaylistRoot"].Value = playlistRoot;
                    row.Cells["ColPlaylistPath"].Value = playlistPath;
                    row.Cells["ColExtension"].Value = Path.GetExtension(file);
                    row.Cells["ColCustom"].Value = sortName;
                    row.Cells["ColExtInf"].Value = extInf;
                }

                UpdateInfo();
            }

            // Restore CellEndEdit event
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        // Function that writes playlist to file based on grid values
        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (TBFilename.Text == String.Empty)
                MessageBox.Show("Playlist name required..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string path = @TBFilename.Text;
                if (Path.GetExtension(path) == String.Empty || Path.GetExtension(path) != ".m3u")
                    path = Path.GetFileNameWithoutExtension(path) + ".m3u";

                try
                {
                    using (StreamWriter file = new StreamWriter(path, false, Encoding.Unicode))
                    {
                        if (_customSort || _extInf)
                            file.WriteLine("#EXTM3U");

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["ColExtInf"].Value.ToString() != String.Empty && _extInf)
                                file.WriteLine(row.Cells["ColExtInf"].Value.ToString());

                            if (_customSort)
                                file.WriteLine("#CSN:" + row.Cells["ColCustom"].Value.ToString());

                            file.WriteLine(row.Cells["ColPlaylistRoot"].EditedFormattedValue.ToString()
                                + row.Cells["ColPlaylistPath"].Value.ToString()
                                + row.Cells["ColTitle"].Value.ToString()
                                + row.Cells["ColExtension"].Value.ToString());
                        }
                    }

                    MessageBox.Show("Playlist created.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Function that updates datagrid item numbering and footer statistics
        private void UpdateInfo()
        {
            dataGridView1.EndEdit();
            int checkCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["ColNumber"].Value = (row.Index + 1).ToString("N0");

                if (Convert.ToBoolean(row.Cells["ColCheck"].Value))
                    checkCount++;
            }

            // Enable or disable the edit and delete buttons based on the number of checked rows
            BtnEdit.Enabled = (checkCount > 0);
            BtnRemove.Enabled = (checkCount > 0);

            LblItemCount.Text = String.Format("{0:n0} Items found", dataGridView1.RowCount);
            LblItemSelected.Text = String.Format("{0:n0} Items selected", checkCount);
        }

        #region form drag/drop events
        // Logic that allows and processes files to be dragged and dropped into the application
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            OnFormDrop((string[])e.Data.GetData(DataFormats.FileDrop));
            panel2.BringToFront();
        }

        private void OnFormDrop(string[] files)
        {
            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".m3u")
                {
                    // Allow reading multiple playlist files
                    TBFilename.Text = Path.GetFileName(@Path.GetFullPath(file));
                    files = File.ReadAllLines(@Path.GetFullPath(file));
                    PopulateGrid(files);
                }
                else
                    // Add single file to grid
                    PopulateGrid(new string[]{ file });
            }
        }
        #endregion

        #region datagrid events
        // Validate the Playlist Path entered after editing
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColPlaylistPath"].Index)
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = SanitizePath(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        // Update the row numbering after sorting
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        #region datagrid drop logic
        // Logic that allows the datagrid to be organized by dragging and dropping the selected row to the desired position

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dataGridView1.DoDragDrop(dataGridView1.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {              
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(
                    new Point(
                        e.X - (dragSize.Width / 2),
                        e.Y - (dragSize.Height / 2)
                    ),
                    dragSize
                );
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropData = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dropData != null)
            {
                OnFormDrop(dropData);
            }
            else
            {
                Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));
                rowIndexOfItemUnderMouseToDrop = dataGridView1.HitTest(clientPoint.X, clientPoint.Y).RowIndex;


                if (e.Effect == DragDropEffects.Move)
                {
                    DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                    dataGridView1.Rows.RemoveAt(rowIndexFromMouseDown);

                    if (rowIndexOfItemUnderMouseToDrop == -1)
                        dataGridView1.Rows.Insert(dataGridView1.RowCount, rowToMove);
                    else
                        dataGridView1.Rows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
                }

                UpdateInfo();
            }
        }
        #endregion
        #endregion

        #region checkbox events
        // Set header checkbox state without triggering checkbox events
        private void forceToggleHeader(bool check)
        {
            _checkHeader.CheckedChanged -= checkbox_CheckedChanged;
            _checkHeader.Checked = check;
            _checkHeader.CheckedChanged += checkbox_CheckedChanged;
        }

        // Handles the datagrid header checkbox changed event
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["ColCheck"];
                if (_checkHeader.Checked)
                {
                    chk.Value = chk.TrueValue;
                    row.DefaultCellStyle.BackColor = hColor;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                    row.DefaultCellStyle.BackColor = (row.Index % 2 == 0) ? Color.White : Color.Lavender;
                }
            }

            dataGridView1.CurrentCell = null;
            UpdateInfo();
        }

        // Handles the datagrid row checkbox changed event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColCheck"].Index && e.RowIndex != -1)
            {
                dataGridView1.EndEdit();
                forceToggleHeader(false);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["ColCheck"];
                    if (Convert.ToBoolean(row.Cells["ColCheck"].Value))
                    {
                        chk.Value = chk.TrueValue;
                        row.DefaultCellStyle.BackColor = hColor;
                    }
                    else
                    {
                        chk.Value = chk.FalseValue;
                        row.DefaultCellStyle.BackColor = (row.Index % 2 == 0) ? Color.White : Color.Lavender;
                    }

                    row.Selected = false;
                }

                UpdateInfo();
            }
        }
        #endregion

        #region ToolStrip functions
        // Resets the entire application
        private void LblItemCount_Click(object sender, EventArgs e)
        {
            if (!_isInit)
            {
                DialogResult dialogResult = MessageBox.Show("Your current playlist will be deleted. Continue?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
            }

            InitializeForm();
        }

        // Exit the application
        private void TSExit_Click(object sender, EventArgs e)
        {
            if (!_isInit)
            {
                DialogResult dialogResult = MessageBox.Show("Confirm exit.", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
            }
            
            System.Windows.Forms.Application.Exit();
        }
        
        // Toggles custom sorting tags (#CSN:). Also shows or hides the custom name column
        private void TSCustSort_Click(object sender, EventArgs e)
        {
            _customSort = TSCustSort.Checked;
            dataGridView1.Columns["ColCustom"].Visible = TSCustSort.Checked;
        }

        // Toggles the inclusion of extended M3U Directives (#EXTINF:) when generating playlist
        private void TSExtInf_Click(object sender, EventArgs e)
        {
            _extInf = TSExtInf.Checked;
        }

        private void TSNumber_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["ColNumber"].Visible = TSNumber.Checked;
        }

        private void TSTitle_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["ColTitle"].Visible = TSTitle.Checked;
        }

        private void TSPRoot_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["ColPlaylistRoot"].Visible = TSPRoot.Checked;
        }

        private void TSPPath_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["ColPlaylistPath"].Visible = TSPPath.Checked;
        }

        private void TSType_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["ColExtension"].Visible = TSType.Checked;
        }

        private void TSLPath_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["ColLocalPath"].Visible = TSLPath.Checked;
        }

        // Adds flag for auto finding duplicate entries
        // NOT YET IMPLEMENTED
        private void TSDup_Click(object sender, EventArgs e)
        {
            _findDup = TSDup.Checked;
            //FindDuplicates();
        }

        // Shows app info
        private void aboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InputDialog id = new InputDialog();
            About about = new About();
            about.ShowDialog(this);
        }
        #endregion

        #region right click ToolStrip functions
        // Sets the current selected row to the clicked cell and displays the right click context menu
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ignore if a column or row header is clicked and only capture right mouse click
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView1.CurrentCell = clickedCell;
                    contextMenuStrip1.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
                }
            }
        }

        // Moves the selected datagrid row 1 step up
        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow moveRow = dataGridView1.SelectedRows[0] as DataGridViewRow;
            int idx = moveRow.Index;

            if (idx > 0)
            {
                dataGridView1.Rows.RemoveAt(idx);
                dataGridView1.Rows.Insert(idx - 1, moveRow);

                dataGridView1.ClearSelection();
                dataGridView1.Rows[idx - 1].Selected = true;
            }
            UpdateInfo();
        }

        // Moves the selected datagrid row 1 step down
        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow moveRow = dataGridView1.SelectedRows[0] as DataGridViewRow;
            int idx = moveRow.Index;

            if (idx < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows.RemoveAt(idx);
                dataGridView1.Rows.Insert(idx + 1, moveRow);

                dataGridView1.ClearSelection();
                dataGridView1.Rows[idx + 1].Selected = true;
            }
            UpdateInfo();
        }

        // Displays a popup which moves a selected row to a specified position
        private void moveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow moveRow = dataGridView1.SelectedRows[0] as DataGridViewRow;

            InputDialog id = new InputDialog();
            if (id.ShowDialog(this) == DialogResult.OK)
            {
                int pos = id.retVal - 1;
                if (pos < 0)
                    pos = 0;
                else if (pos > dataGridView1.Rows.Count - 1)
                    pos = dataGridView1.Rows.Count - 1;

                dataGridView1.Rows.RemoveAt(moveRow.Index);
                dataGridView1.Rows.Insert(pos, moveRow);

                dataGridView1.ClearSelection();
                dataGridView1.Rows[pos].Selected = true;

                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;

            }
            id.Dispose();
            UpdateInfo();
        }

        // Creates a copy of the selected row and adds it to the next row
        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow copyRow = dataGridView1.SelectedRows[0] as DataGridViewRow;
            DataGridViewRow newRow = (DataGridViewRow)copyRow.Clone();
            for (Int32 index = 1; index < copyRow.Cells.Count; index++)
            {
                //Don't include checkbox value on clone
                newRow.Cells[index].Value = copyRow.Cells[index].Value;
            }
            dataGridView1.Rows.Insert(copyRow.Index + 1, newRow);

            UpdateInfo();
        }


        // Removes the selected row
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm remove.", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                UpdateInfo();
            }
        }
        #endregion

        #region side button functions
        // Converts the local path a unix file structure and sets the value as the playlist path
        private void BtnAssume_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string local = row.Cells["ColLocalPath"].Value.ToString();
                    if (local[0] != '/')
                    {
                        //Assume that playlist or file is using windows file structure
                        local = local.Replace(Path.GetPathRoot(local), "");
                        local = local.Replace("\\", "/");
                        row.Cells["ColPlaylistPath"].Value = SanitizePath(local);
                    }
                    //Playlist Path should already be mapped on unix file structures. No need to do anything.
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Cannot assume path since it could not be recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Displays a textbox that allows editing of selected rows
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditDialog ed = new EditDialog();
            if (ed.ShowDialog(this) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["ColCheck"].Value))
                    {
                        if (ed.rootVal != Storage.None)
                            row.Cells["ColPlaylistRoot"].Value = ed.rootVal;

                        if (ed.pathVal != null)
                            row.Cells["ColPlaylistPath"].Value = ed.pathVal;
                    }
                }
            }
            ed.Dispose();
        }

        // Deletes all selected rows
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm remove.", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int x = dataGridView1.Rows.Count - 1; x >= 0; x--)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[x].Cells["ColCheck"].Value))
                        dataGridView1.Rows.RemoveAt(x);
                }

                forceToggleHeader(false);
                UpdateInfo();
            }
        }

        // Displays a form and sets the selected items based on user criteria
        // NOT YET IMPLEMENTED
        private void BtnSelect_Click(object sender, EventArgs e)
        {

        }
        #endregion



        private string SanitizePath(string path)
        {
            // Remove "/" at the beginning if present
            if (path[0] == '/')
                path = path.Remove(0, 1);

            // Make sure path always has an "/" at the end
            if (path[path.Length - 1] != '/')
                path += "/";

            return path;
        }
        





        
        // Function to find duplicate entries based on title and file type
        // NOT YET IMPLEMENTED
        /*private void FindDuplicates()
        {
            if (_findDup)
            {
                dataGridView1.EndEdit();
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    DataGridViewRow compRow = dataGridView1.Rows[row];
                    string title = compRow.Cells["ColTitle"].Value.ToString();
                    string type = compRow.Cells["ColExtension"].Value.ToString();

                    for (int row2 = row + 1; row2 < dataGridView1.Rows.Count; row2++)
                    {
                        if (dataGridView1.Rows[row2].Cells["ColTitle"].Value.ToString().Equals(title)
                            && dataGridView1.Rows[row2].Cells["ColExtension"].Value.ToString().Equals(type))
                        {
                            dataGridView1.Rows[row2].Cells["IsDup"].Value = 1;
                            dataGridView1.Rows[row2].DefaultCellStyle.BackColor = dupColor;
                        }
                        else
                        {
                            dataGridView1.Rows[row2].Cells["IsDup"].Value = 0;
                        }
                    }
                }

                dataGridView1.CurrentCell = null;
                UpdateInfo();
            }
        }*/



    }
}
