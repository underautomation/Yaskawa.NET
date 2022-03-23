using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;

public partial class FileControl : UserControl, IUserControl
{
    YaskawaRobot _robot;

    public FileControl(YaskawaRobot Yaskawa)
    {
        _robot = Yaskawa;
        InitializeComponent();
    }

    #region IUserControl
    public bool FeatureEnabled => _robot.HighSpeedEServer.Connected;

    public string Title => "Files";

    public void OnClose() { }

    public void OnOpen()
    {
        UpdateList();
    }

    private void UpdateList(string selected = null)
    {
        try
        {

            Cursor = Cursors.WaitCursor;

            lstFolder.Items.Clear();

            if (!_robot.HighSpeedEServer.Connected) return;

            var files = _robot.HighSpeedEServer.GetFileList(cbPattern.Text);

            ListViewItem selectedItem = null;

            foreach (var file in files.Files)
            {
                var itm = lstFolder.Items.Add(file);
                itm.ImageKey = "file";

                if (string.Equals(selected, file))
                {
                    itm.Selected = true;
                    selectedItem = itm;
                }
            }

            selectedItem?.EnsureVisible();
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }

    public void PeriodicUpdate()
    {

    }
    #endregion

    private void btnUpload_Click(object sender, EventArgs e)
    {
        if (dlgOpen.ShowDialog() != DialogResult.OK) return;

        var content = File.ReadAllText(dlgOpen.FileName);

        var fileName = Path.GetFileName(dlgOpen.FileName);

        try
        {
            Cursor = Cursors.WaitCursor;

            _robot.HighSpeedEServer.LoadFile(fileName, content, (progress) =>
            {
                lblProgress.Visible = true;
                lblProgress.Text = $"Sending {progress.FileName} ...\r\nSent bytes : {progress.LoadedBytes} out of {progress.TotalBytes}";
                Application.DoEvents();
            });

            UpdateList(fileName);
        }
        finally
        {
            lblProgress.Visible = false;
            Cursor = Cursors.Default;
        }
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
        OpenFile(true);
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var file = GetSelectedFile();
        if (file is null) return;

        if (MessageBox.Show($"Do you really want to delete {file} ?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        {
            return;
        }

        _robot.HighSpeedEServer.DeleteFile(file);

        UpdateList();
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        OpenFile(false);
    }

    private string GetSelectedFile()
    {
        return lstFolder.SelectedItems.OfType<ListViewItem>().FirstOrDefault()?.Text;
    }

    private void OpenFile(bool showSaveDialog)
    {
        var file = GetSelectedFile();
        if (file is null) return;

        try
        {
            Cursor = Cursors.WaitCursor;


            var content = _robot.HighSpeedEServer.GetFile(file, (progress) =>
            {
                lblProgress.Visible = true;
                lblProgress.Text = $"Downloading {progress.FileName} ...\r\nReceived bytes : {progress.DownloadedBytes}";
                Application.DoEvents();
            });

            var frm = new FileControlPopup(content.FileName, content.Content, _robot, showSaveDialog);
            frm.ShowDialog();
        }
        finally
        {
            lblProgress.Visible = false;
            Cursor = Cursors.Default;
        }
    }

    private void lstFolder_ItemActivate(object sender, EventArgs e)
    {
        OpenFile(false);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        UpdateList();
    }

    private void btnOpenPath_Click(object sender, EventArgs e)
    {
        UpdateList();
    }
}
