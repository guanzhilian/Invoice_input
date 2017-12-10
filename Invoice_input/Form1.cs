using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace Invoice_input
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser browser = null;
        List<string[]> fileLines = new List<string[]>();
        int CurrIdx = 1;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        public void InitBrowser()
        {
            var setting = new CefSettings();
            setting.Locale = "zh-CN";
            setting.CachePath = "cache";
            Cef.Initialize();

            browser = new ChromiumWebBrowser(@"https://inv-veri.chinatax.gov.cn/");
            this.panel1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var yzm = txtVCode.Text.Trim().Replace(" ", "");
            yzm = yzm.Substring(yzm.Length - 6, 6);
            browser.ExecuteScriptAsync(@"$('#fpdm').val('" + txtCode.Text.Trim() + "')");
            browser.ExecuteScriptAsync(@"$('#fphm').val('" + txtNum.Text.Trim() + "')");
            browser.ExecuteScriptAsync(@"$('#kprq').val('" + txtDate.Text.Trim().Replace("-", string.Empty) + "')");
            browser.ExecuteScriptAsync(@"$('#kjje').val('" + yzm + "')");
            browser.ExecuteScriptAsync(@"$('#yzm_img').trigger('click')");
            browser.ExecuteScriptAsync(@"$('#yzm').on('click', ()=>$('#kjje').val('" + yzm + "'))");
            txtTaxMoney.Text = "";
            lblzuofei.Hide();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var info = txtQRCode.Text.Split(',');
            txtCode.Text = info[2];
            txtNum.Text = info[3];
            txtDate.Text = info[5];
            txtMoney.Text = info[4];
            txtVCode.Text = info[6];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var script = @"$('#icon_zf', $('#dialog-body')[0].contentDocument).is(':visible')";
            ExecJsResult(script, x =>
            {
                if (x == "True")
                {
                    lblzuofei.Show();
                    timer1.Stop();
                }
            });

            if (lblzuofei.Visible == false)
            {
                ExecJsResult(@"$('#dialog-body')[0].contentDocument.getElementById('jshjxx_dzfp').innerText", x =>
                {
                    txtTaxMoney.Text = x;
                });
            }
        }

        void ExecJsResult(string script, Action<string> act)
        {
            var task = browser.EvaluateScriptAsync(script, timeout: null);

            task.ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    var EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
                    if (act != null)
                        act.Invoke(EvaluateJavaScriptResult + "");
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button3.PerformClick();
            var regx = Regex.Match(txtTaxMoney.Text, @"￥(\d+\.\d+)");
            if (regx.Success)
            {
                timer1.Stop();
                txtTaxM2.Text = regx.Groups[1].Value;
                if (chkAutoNext.Checked)
                {
                    var data = fileLines[CurrIdx];
                    data[6] = txtTaxM2.Text;

                    float m1 = 1, m2 = -1;
                    float.TryParse(data[4], out m1);
                    float.TryParse(data[6], out m2);
                    if (m1 == m2)
                    {
                        data[7] = "金额一致";
                    }
                    else
                    {
                        data[7] = "不一致";
                    }
                    writeData2File();
                    CurrIdx++;
                    browser.ExecuteScriptAsync(@"$('#dialog-body')[0].contentDocument.getElementById('closebt').click();");
                    timerRun.Start();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var f = new System.IO.StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while ((line = f.ReadLine()) != null)
                    {
                        fileLines.Add(line.Split('\t'));
                    }
                    f.Close();
                    //if (fileLines.Count > 1)
                    //    fileLines.RemoveAt(0);//去掉标题行
                }
            }
        }


        private void writeData2File()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(openFileDialog1.FileName))
            {
                foreach (var line in fileLines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    var s = string.Join("\t", line);
                    file.WriteLine(s);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CurrIdx < fileLines.Count)
            {
                var data = fileLines[CurrIdx];
                txtCode.Text = data[1];
                txtNum.Text = data[2];
                txtDate.Text = data[3];
                txtMoney.Text = data[4];
                txtVCode.Text = data[5];
                btnTest.PerformClick();
                lblNo.Text = "#" + CurrIdx;
            }
        }

        private void timerRun_Tick(object sender, EventArgs e)
        {
            if (CurrIdx < fileLines.Count)
            {
                var data = fileLines[CurrIdx];
                txtCode.Text = data[1];
                txtNum.Text = data[2];
                txtDate.Text = data[3];
                txtMoney.Text = data[4];
                txtVCode.Text = data[5];
                btnTest.PerformClick();
                lblNo.Text = "#" + CurrIdx;
            }
            timerRun.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data = fileLines[CurrIdx];
            data[7] = "手工跳过";
            writeData2File();
            CurrIdx++;
            button5.PerformClick();
        }

        string readFromFile(string fn)
        {
            using (var sr = new StreamReader(fn))
            {
                var str = sr.ReadToEnd();
                sr.Close();
                return str;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var script = readFromFile(@".\script.txt");
            browser.ExecuteScriptAsync(script);
        }
    }
}
