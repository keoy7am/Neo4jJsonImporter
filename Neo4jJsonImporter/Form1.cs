using Neo4jClient;
using Newtonsoft.Json;
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

namespace Neo4jJsonImporter
{
    public partial class FormMain : Form
    {
        private static GraphClient graphClient;
        public FormMain()
        {
            InitializeComponent();
        }
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            try
            {
                var jsonFiles = Directory.GetFiles(tb_JsonDir.Text.Trim());
                graphClient = new GraphClient(new Uri(tb_Addr.Text.Trim()), tb_User.Text.Trim(), tb_Password.Text.Trim());
                if (!graphClient.IsConnected)
                {
                    graphClient.Connect();
                }
                #region 進度條
                progressBar.Maximum = jsonFiles.Count();
                progressBar.Value = 0;
                progressBar.Step = 1;
                #endregion

                foreach (var jsonPath in jsonFiles)
                {
                    progressBar.PerformStep();
                    var json = File.ReadAllText(jsonPath);
                    var jdg = ConvertToDTO(json);
                    if (jdg == null)
                        continue;
                    graphClient.Create<JDG>(jdg);
                    Application.DoEvents();
                    this.Invoke(new Action(() => { lb_Count.Text = $"{progressBar.Value} / {progressBar.Maximum}"; }));
                }
                MessageBox.Show("Finished");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"發生錯誤: {ex.Message}");
            }
            finally
            {
                progressBar.Maximum = 0;
                progressBar.Value = 0;
                btn_Start.Enabled = true;
            }
        }
        private JDG ConvertToDTO(string jsonText)
        {
            try
            {
                return JsonConvert.DeserializeObject<JDG>(jsonText);
            }catch(Exception ex)
            {
                Console.WriteLine($"轉換失敗:{ex.Message}");
                return null;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
