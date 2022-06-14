using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using System.Threading;
using MCommon;
using System.Text.RegularExpressions;
using System.IO;
using OtpNet;

namespace check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        ChromeDriver drv; Thread Th;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Acc.Text != "" )
            {
                Run.ForeColor = Color.Linen;
                Run.Cursor = Cursors.Hand;
            }

            else
            {
                Run.ForeColor = Color.Red;
                Run.Cursor = Cursors.No;
            }

        }
        Chrome chrome;
        private string[] path;
        private object contents; 

        private void Run_Click(object sender, EventArgs e)
        {
            
                Th = new Thread(Result); Th.Start();
                
            
        }




        public void Result()
        {
            Run.ForeColor = Color.Gold;
            Run.UseWaitCursor = true;
            Run.Text = "running...";
            //OpenSelenium();
            string app = "data:,";
            chrome = new Chrome()
            {
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36",
                //ProfilePath = @"C:\TestFb\TestFb\bin\Debug\profiles\100080077767502",
                Size = new Point(500, 700),
                Position = new Point(0, 0),
                TimeWaitForSearchingElement = 3,
                TimeWaitForLoadingPage = 120,
                //Proxy = proxy,
                //TypeProxy = typeProxy,
                DisableSound = true,
                //App = app,
            };
            chrome.Open();
            chrome.GotoURL("https://m.facebook.com/login/");
            chrome.DelayTime(1);

            Login(chrome, Account.Text, IDpost.Text);

            //CloseSelenium();
            Run.ForeColor = Color.Linen;
            Run.UseWaitCursor = false;
            Run.Text = "Chạy";
        }

        private void Login(Chrome chrome, string Acc, string IDpost)
        {
            try
            {
                bool isAccount = true;
                {


                    if (isAccount)
                    {


                        if (chrome.CheckExistElement("#m_login_email", 10) == 1)
                        {

                            
                            //uid|pass|2fa
                            string uid = Acc.Split('|')[0];    
                          
                            chrome.SendKeys(1, "m_login_email", uid);
                            chrome.DelayTime(1);
                            string pass = Acc.Split('|')[1];
                            chrome.SendKeys(4, "[type=\"password\"]", pass);
                            chrome.DelayTime(1);
                            chrome.Click(2, "login");
                            chrome.DelayTime(1);
                            string fa2 = Acc.Split('|')[2];
                            if (chrome.CheckExistElement("#approvals_code", 5) == 1)
                            {
                                string otp = GetTotp(fa2);
                                chrome.SendKeys(1, "approvals_code", otp);
                                chrome.DelayTime(1);
                            }
                        }
                        chrome.Click(4, "[data-sigil=\"touchable\"]", 1);
                        chrome.DelayTime(1);



                    }
                    else
                        MessageBox.Show("Account  Faill");


                }
                


                try
                {
                    string IDBaiVet;
                    List<string> lstIdBaiViet = txtIdBaiViet.Lines.ToList();

                    for (int i = 0; i < lstIdBaiViet.Count; i++)
                    {
                        chrome.GotoURL("https://m.facebook.com/" + lstIdBaiViet[i]);
                        chrome.DelayTime(1);

                        if (chrome.CheckExistElement("[data-sigil=\"ufi-inline-actions\"] a") == 1)
                        {
                            chrome.DelayTime(1);




                            

                            string link = chrome.ExecuteScript("return document.querySelector('[name =\"apple-itunes-app\"]').getAttribute('content')").ToString();
                            string id = Regex.Match(link, @"\?id=([0-9]{1,})").Groups[1].Value;


                            File.AppendAllText(Text, lstIdBaiViet[i] + "|1|" + id + Environment.NewLine);
                            Ketqua.Text +=  id + Environment.NewLine;
                        }
                        else
                        {
                            Ketqua.Text +=( Text, lstIdBaiViet + "|0|"  +  Environment.NewLine);
                            // textbox += hiển thị : nhập phần check vào form
                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
                    }
                    //string readText = File.ReadAllText("checkid.txt");
                    //Console.WriteLine(readText);

                }
                catch 
                {

                }

            }
            catch
            {

            }

        }


    
        string GetTotp(string input)
        {
            try
            {
                byte[] array = Base32Encoding.ToBytes(input.Trim().Replace(" ", ""));
                Totp totp = new Totp(array, 30, 0, 6, null);
                string otp = totp.ComputeTotp(DateTime.UtcNow);
                return otp;
            }
            catch (Exception ex)
            {
            }

            return "";
        }
        //string GetTotp(string input)
        //{
        //    try
        //    {
        //        byte[] array = Base32Encoding.ToBytes(input.Trim().Replace(" ", ""));
        //        Totp totp = new Totp(array, 30, 0, 6, null);
        //        string otp = totp.ComputeTotp(DateTime.UtcNow);
        //        return otp;
        //    }
        //    catch (Exception ex)
        //    {
        //    }

        //    return "";
        //}


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void OpenSelenium()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            drv = new ChromeDriver(service);
            chrome.GotoURL("https://m.facebook.com/login/");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseSelenium();
        }
        public void CloseSelenium()
        {
            chrome.Close();
        }

        private void txtIdBaiViet_TextChanged(object sender, EventArgs e)
        {

        }
        public static void ShowForm(Form f)
        {
            f.ShowInTaskbar = false;
            f.ShowDialog();
        }

        

        private void Comment_Click(object sender, EventArgs e)
        {
            ShowForm(new Form2());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
