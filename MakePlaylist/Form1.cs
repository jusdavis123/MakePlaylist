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
        public Form1()
        {
            InitializeComponent();
            panel1.BringToFront();
        }

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
            if (Path.GetExtension(files[0]) == ".m3u")
            {
                TBFilename.Text = Path.GetFileName(@Path.GetFullPath(files[0]));
                files = File.ReadAllLines(@Path.GetFullPath(files[0]));
            }
            
            PopulateGrid(files);
        }

        private void PopulateGrid(string[] files)
        {
            for (int x = 0; x < files.Length; x++)
            {
                //ignore line if it is an extended M3U directive
                if (files[x][0] == '#')
                    continue;

                string file = files[x];
                int rowId = dataGridView1.Rows.Add();

                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells["ColTitle"].Value = Path.GetFileNameWithoutExtension(file);
                row.Cells["ColLocalPath"].Value = Path.GetDirectoryName(file);
                row.Cells["ColPlaylistPath"].Value = "/mnt/internal_sd/Music/Japanese/";
                row.Cells["ColExtension"].Value = Path.GetExtension(file);
            }

            UpdateInfo();
        }

        private void UpdateInfo()
        {
            int checkCount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["ColNumber"].Value = (row.Index + 1).ToString("N0");

                if (Convert.ToBoolean(row.Cells["ColCheck"].Value))
                    checkCount++;
            }
            dataGridView1.EndEdit();

            LblItemCount.Text = String.Format("{0:n0} Items found", dataGridView1.RowCount);
            LblItemSelected.Text = String.Format("{0:n0} Items selected", checkCount);
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            UpdateInfo();
            /*
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColCheck"].Value))
                {
                    dataGridView1.Rows[row.Index].Selected = true;
                }
            }
            */

            //Random ran = new Random();
            //dataGridView1.Rows[ran.Next(0, dataGridView1.RowCount - 1)].Selected = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColCheck"].Index && e.RowIndex != -1)
            {
                // Handle checkbox state change here
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["ColCheck"].Value))
                    dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }



        #region datagrid drop logic
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




        private void button4_Click(object sender, EventArgs e)
        {
            if (TBFilename.Text == String.Empty)
                MessageBox.Show("Enter playlist name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string path = @TBFilename.Text;
                if (Path.GetExtension(path) == String.Empty || Path.GetExtension(path) != ".m3u")
                    path = Path.GetFileNameWithoutExtension(path) + ".m3u";

                try
                {
                    if (File.Exists(path))
                        File.Delete(path);

                    using (StreamWriter file = new StreamWriter(path, true, Encoding.Unicode))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            file.WriteLine(row.Cells["ColPlaylistPath"].Value.ToString() + row.Cells["ColTitle"].Value.ToString() + row.Cells["ColExtension"].Value.ToString());
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
    }
}
