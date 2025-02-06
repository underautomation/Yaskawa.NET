using System;
using System.IO;
using System.Windows.Forms;
using UnderAutomation.Yaskawa;

public partial class FileControlPopup : Form
{
    private string _file;

    private YaskawaRobot _robot;

    public FileControlPopup(string file, string content, YaskawaRobot yaskawa, bool showSaveDialog)
    {
        _robot = yaskawa;

        InitializeComponent();

        txtContent.Text = content;

        _file = file;
        this.Text = file;

        tmr.Enabled = showSaveDialog;
    }

    private void txtContent_TextChanged(object sender, EventArgs e)
    {
        this.Text = $"* {_file}";
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        _robot.HighSpeedEServer.LoadFile(_file, txtContent.Text);
        this.Text = _file;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Save();
    }

    public void Save()
    {
        dlgSave.FileName = _file;

        if (dlgSave.ShowDialog() != DialogResult.OK) return;

        File.WriteAllText(dlgSave.FileName, txtContent.Text);

        Explorer.RevealFile(dlgSave.FileName);
    }

    private void tmr_Tick(object sender, EventArgs e)
    {
        tmr.Enabled = false;
        Save();
    }

}
