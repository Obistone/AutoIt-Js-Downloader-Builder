using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class MainForm : Form
    {

        public static string ScriptLocation = "script.au3";
        public static string CompilerLocation = "compiler.exe";
        public static string UpxLocation = "upx.exe";

        public MainForm()
        {
            InitializeComponent();
            CheckFiles();
        }

        public async void CheckFiles()
        {
            try
            {
                if (!File.Exists(ScriptLocation))
                {
                    await Task.Run(() => {
                        using (FileStream stream = new FileStream(ScriptLocation, FileMode.CreateNew))
                        {
                            stream.Write(Properties.Resources.script, 0, Properties.Resources.script.Length);
                            stream.Close();
                        }
                    });
                }

                if (!File.Exists(CompilerLocation))
                {
                    await Task.Run(() => {
                        using (FileStream stream = new FileStream(CompilerLocation, FileMode.CreateNew))
                        {
                            stream.Write(Properties.Resources.compiler, 0, Properties.Resources.compiler.Length);
                            stream.Close();
                        }
                    });
                }
                if (!File.Exists(UpxLocation))
                {
                    await Task.Run(() => {
                        using (FileStream stream = new FileStream(UpxLocation, FileMode.CreateNew))
                        {
                            stream.Write(Properties.Resources.upx, 0, Properties.Resources.upx.Length);
                            stream.Close();
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Writing Script to File System!\r\rError Details:\r" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CompileButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] script = File.ReadAllBytes(ScriptLocation);
                byte[] newScript = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(script).Replace(">LINK<", DirectLinkTextBox.Text).Replace(">FOLDERNAME<", FoldernameTextBox.Text));
                await Task.Run(() => {
                    using (FileStream stream = new FileStream("new_script.au3", FileMode.CreateNew))
                    {
                        stream.Write(newScript, 0, newScript.Length);
                        stream.Close();
                    }
                });
                Process p = new Process();
                ProcessStartInfo info = new ProcessStartInfo
                {
                    FileName = CompilerLocation,
                    Arguments = $"/in new_script.au3 /out Compiled.exe /comp 4 /x86"
                };
                p.StartInfo = info;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Compiling Your Script!\r\rError Details:\r" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Done!\r\rFile Path: " + Path.GetFullPath("Compiled.exe"), "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (File.Exists("Compiled.exe"))
                {
                    //File.Delete("new_script.au3");
                }
            }
        }
    }
}
