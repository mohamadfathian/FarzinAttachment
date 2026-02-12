using farzinAttachment.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Configuration;
using ICAN.FarzinSDK.WebServices.Proxy;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace farzinAttachment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(txtSource.Text);
            DataAccess db = new DataAccess();
            DataTable fileDependencyDt = db.getDataFromDataBase("select DependencyID,etc,ec,FileName from File_Dependency where ETC=" + entityTypeCode.Text);
            string dependencyId = "";
            string etc = "";
            string ec = "";
            string fileName = "";
            string fileNameWithoutExtentioninDataBase = "";
            string fileNameWithoutExtentioninDataBasewithBraket = "";
            int count = 1;

            MessageBox.Show("asdf");


            //foreach (var file in files)
            //{
            //    FileInfo fileInfo = new FileInfo(file);
            //    String fileNameWithoutExtention = Path.GetFileNameWithoutExtension(fileInfo.FullName);

            //MessageBox.Show("file in explorer" + fileNameWithoutExtention);

            foreach (DataRow fileDependencyRec in fileDependencyDt.Rows)
            {
                Boolean isExistFile = false;
                dependencyId = fileDependencyRec[0].ToString();
                etc = fileDependencyRec[1].ToString();
                ec = fileDependencyRec[2].ToString();
                fileName = fileDependencyRec[3].ToString();
                
                FileInfo fileInfoInExplorer = new FileInfo(fileName);
                fileNameWithoutExtentioninDataBasewithBraket = Path.GetFileName(fileInfoInExplorer.FullName);
                
                int lastBeaketscoreIndex = fileNameWithoutExtentioninDataBasewithBraket.LastIndexOf("[");
                if (lastBeaketscoreIndex < 0)
                {
                    //MessageBox.Show("originFiledbbefor: " + fileName);
                    //MessageBox.Show("fileNameWithoutExtentioninDataBasewithBraket: " + fileNameWithoutExtentioninDataBasewithBraket);
                    //MessageBox.Show(lastBeaketscoreIndex.ToString());
                    fileNameWithoutExtentioninDataBase = fileNameWithoutExtentioninDataBasewithBraket;
                }
                else {
                    fileNameWithoutExtentioninDataBase = fileNameWithoutExtentioninDataBasewithBraket.Substring(0, lastBeaketscoreIndex);
                }

                //MessageBox.Show("justFileNamedb: " + fileNameWithoutExtentioninDataBase);
                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    String fileNameWithoutExtentionandUnderLine = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                    int lastUnderscoreIndex = fileNameWithoutExtentionandUnderLine.LastIndexOf('_');
                    String fileNameWithoutExtention = fileNameWithoutExtentionandUnderLine.Substring(0, lastUnderscoreIndex);

                    if (fileNameWithoutExtentioninDataBase.Equals(fileNameWithoutExtention, StringComparison.OrdinalIgnoreCase))
                    {
                        //MessageBox.Show("exist" + fileNameWithoutExtentioninDataBase);
                        listBox1.Items.Add("exist" + fileNameWithoutExtentioninDataBase +"fileNameExplorer: "+fileNameWithoutExtention+ "count"+count);
                        count++;
                        isExistFile = true;
                        break;
                    }
                }
                if (!isExistFile)
                {
                    //  MessageBox.Show("file not exists: " + fileNameWithoutExtentioninDataBase);
                    string q = "insert into tbl_notExistFile (DependencyID,etc,ec,FileName) values (" + dependencyId + "," + etc + ", " + ec + ", " + fileName + ")";
                    //MessageBox.Show(q);
                    db.execQuery("insert into tbl_notExistFile (DependencyID,etc,ec,FileName) values ('" + dependencyId + "','" + etc + "','" + ec + "','" + fileName + "')");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSource.Text = @"F:\transmital_Apex";
            entityTypeCode.Text = "992";
        }

        Authentication.Authentication fla = new Authentication.Authentication();
        eFormManagment.eFormManagment fef = new eFormManagment.eFormManagment();
        private void BtnConverter_Click(object sender, EventArgs e)
        {
            DataAccess dataBase=new DataAccess();
            

            CookieContainer cookieContainer = new CookieContainer();

            //UserData userData = DataAccess.getUserData(userName);
            //List<TransmitalForm> transmitalForms = GetTransmitallEntityCode("select entitycode,entityNumber from " + formName +
            //                                                                      " where entitycode not in (select entitycode from log_fetch_file where entitytypecode=" + entityTypeCode + ")" +
            //                                                                      " and EntityCode in (select ec from File_Dependency where ETC = " + entityTypeCode + ")");

             List<TransmitalForm> transmitalForms = GetTransmitallEntityCode(txtQuery.Text);
            //List<TransmitalForm> transmitalForms = new List<TransmitalForm>
            //{
            //    new TransmitalForm
            //    {
            //        entityCode=362,
            //        entityNumber="2333"
            //    }
            //};



            ((HttpWebClientProtocol)fla).CookieContainer = cookieContainer;
            string errorMsg = "";
            byte[] farzinFileByte = new byte[0];
            //byte[] fileBytes = new byte[0];
            //string extension = "";
            //string fileName = "";

            if (CheckingPass())
                ((HttpWebClientProtocol)fef).CookieContainer = cookieContainer;
            else
                MessageBox.Show("Authentication failed.");


            int chunkSize = 50;

            for (int i = 0; i < transmitalForms.Count; i += chunkSize)
            {
                var chunk = transmitalForms.Skip(i).Take(chunkSize).ToList();

                foreach (var transmitalNewForm in chunk)
                {
                    try
                    {
                        int retry = 0;
                        string serviceError = "";
                        object result = null;
                        while (true)
                        {
                            try
                            {
                                //HelperClass.LogToFile("entityCode: " + transmitalNewForm.entityCode + "entityNumber: " + transmitalNewForm.entityNumber + "entityTypeCode: " + entityTypeCode);
                                result = fef.GetFileDependency(Int32.Parse(txtEntityTypeCode.Text), transmitalNewForm.entityCode, out serviceError);
                                if (!string.IsNullOrEmpty(serviceError))
                                {
                                    //HelperClass.LogToFile("ERRORRRRRR: " + serviceError);
                                    Thread.Sleep(3000);
                                    break;

                                }
                                Thread.Sleep(300);
                                break; // موفق شدیم → حلقه را ترک می‌کنیم
                            }
                            catch (WebException ex)
                            {
                                if (ex.Message.Contains("429") && retry < 5)
                                {
                                    Thread.Sleep(3000); // ۳ ثانیه صبر قبل از Retry
                                    retry++;
                                    continue;
                                    //HelperClass.LogToFile("fetch data" + retry);
                                }

                                throw;
                            }
                        }

                        if (!string.IsNullOrEmpty(serviceError))
                        {
                            //return new FileInformation { error = serviceError };
                            continue;
                        }

                        var props = result.GetType().GetProperties();

                        foreach (var p in props)
                        {
                            var value = p.GetValue(result, null);

                            object[] arrs = value as object[];

                            if (arrs != null)
                            {
                                foreach (var arr in arrs)
                                {
                                    //HelperClass.LogToFile("5555");
                                    byte[] fileBytes = arr.GetType().GetProperty("FileBinary").GetValue(arr, null) as byte[];
                                    string extension = arr.GetType().GetProperty("FileExtension").GetValue(arr, null)?.ToString();
                                    string fileName = arr.GetType().GetProperty("FileName").GetValue(arr, null)?.ToString();
                                    string dependencyId = arr.GetType().GetProperty("FileID").GetValue(arr, null)?.ToString();

                                    //HelperClass.LogToFile($@"F:\{filePath}\{fileName}_{transmitalNewForm.entityNumber}{extension}+{dependencyId}++{transmitalNewForm.entityCode}");

                                    string path2 = $@"F:\{txtFilePath.Text}\{fileName}_{dependencyId}_{transmitalNewForm.entityNumber}{extension}";

                                    File.WriteAllBytes(path2, fileBytes);
                                    if (chkInsertINDB.Checked)
                                    {
                                        dataBase.execQuery("insert into log_fetch_file2 (entityTypeCode,entitycode,dependencyID) values (" + txtEntityTypeCode.Text + "," + transmitalNewForm.entityCode + "," + dependencyId + ")");
                                    }

                                    // آزادسازی حافظه2
                                    fileBytes = null;
                                }
                            }

                            value = null;
                            arrs = null;
                        }

                        result = null;

                        // آزادسازی حافظه
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // بین هر chunk کمی صبر کن
                Thread.Sleep(1000);
            }

            MessageBox.Show("all file Compeletly Done!");
        }
        private List<TransmitalForm> GetTransmitallEntityCode(string query)
        {
            DataAccess db = new DataAccess();
            DataTable dt = db.getDataFromDataBase(query);

            List<TransmitalForm> resultList = new List<TransmitalForm>();

            if (dt == null || dt.Rows.Count == 0)
                return resultList;


            foreach (DataRow row in dt.Rows)
            {
                TransmitalForm transmitalNewForm = new TransmitalForm();
                transmitalNewForm.entityCode = Convert.ToInt32(row[0]);
                transmitalNewForm.entityNumber = Convert.ToString(row[1]);
                resultList.Add(transmitalNewForm);
            }

            return resultList;
        }

        public bool CheckingPass()
        {
            string userName = Properties.Settings.Default.userName;
            string passwored = Properties.Settings.Default.Password;
            string strErrorMsg = "";
            CSHA1 val = new CSHA1();
            string password = val.hex_sha1(passwored);
            if (fla.Login(userName, password, out strErrorMsg))
            {
                return true;
            }
            throw new Exception(strErrorMsg);
        }
    }
}
