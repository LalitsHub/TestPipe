using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data;
using System.Data.OleDb;

namespace AgVueAutomation.lib
{
    class generalLib
    {
        /// <summary>
        /// This method will fetch the requested config value from the config file.
        /// </summary>
        /// <param name="configEntry"></param>
        /// <returns></returns>
        public static string readconfig(string configEntry)
        {
            string strRet = "";
            string[] str;
            Boolean boolFound = false;
            string strPath = initializeTest.workspace + "\\config\\config.txt";
            //Console.WriteLine("Config Path= " + strPath);
            if (File.Exists(strPath))
            {
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(strPath))
                {
                    String s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                        str = s.Split('=');
                        if (str[0].Equals(configEntry))
                        {
                            //Console.WriteLine("Matched: " + str[1]);
                            strRet = str[1];
                            boolFound = true;
                            break;
                        }
                    }
                    if (boolFound == false)
                    {
                        Console.WriteLine("Variable not found int the test data file");
                    }
                }
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
            return strRet;
        }
        /// <summary>
        ///  This method will fetch the requested json value from the json file.
        /// </summary>
        /// <param name="jsonEntry"></param>
        /// <returns></returns>
        public static string readjson(string jsonEntry)
        {
            string strRet = "";
            string[] str;
            Boolean boolFound = false;
            string strPath = initializeTest.workspace + "\\config\\AppSettings.json";
            //Console.WriteLine("Config Path= " + path);
            if (File.Exists(strPath))
            {
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(strPath))
                {
                    String s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(s);
                        str = s.Split(':');
                        if (str[0].Trim().Equals("\"" + jsonEntry + "\""))
                        {
                            int l = s.Length;
                            int k = str[0].Length;
                            strRet = s.Substring(k + 1).Trim();
                            l = strRet.Length;
                            strRet = strRet.Substring(1, l - 3);
                            boolFound = true;
                            break;
                        }
                    }
                    if (boolFound == false)
                    {
                        Console.WriteLine("Variable not found int the test data file");
                    }
                }
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
            return strRet;
        }
        /// <summary>
        /// This method will read the test data from the excel sheet. Eacah test case can store maximum 10 test data.
        /// </summary>
        /// <param name="tcno"></param>
        /// <param name="testData"></param>
        /// <returns></returns>
        public static string readTestDataFromExcel(int tcno, int testData)
        {
            string strRet = "";
            string fileName = initializeTest.testDataPath;

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range range = xlWorkSheet.UsedRange;
            strRet = (string)(range.Cells[(tcno + 1), (testData + 1)] as Excel.Range).Value2;
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            return strRet;
        }
        public DataRow[] ImportFromExcel(string testCaseNo)
        {
            string path = initializeTest.testDataPath;
            DataRow[] row = new DataRow[1];
            string connString = "";
            string strFileType = Path.GetExtension(path).ToLower();
            //Connection String to Excel Workbook
            if (strFileType.Trim() == ".xls")
            {
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
            }
            else if (strFileType.Trim() == ".xlsx")
            {
                connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
            }
            string query = "SELECT * FROM [Sheet1$]";
            OleDbConnection conn = new OleDbConnection(connString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    row = ds.Tables[0].Select("TestCasNo='" + testCaseNo + "'");
            }
            da.Dispose();
            conn.Close();
            conn.Dispose();
            return row;
        }

        /// <summary>
        /// This method will return row count of the test suite excel file.
        /// </summary>
        /// <returns></returns>
        public static int getTestSuiteRowCount()
        {
            int intRet = 0;
            string fileName = initializeTest.testSuitePath;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range range = xlWorkSheet.UsedRange;
            intRet = xlWorkSheet.UsedRange.Rows.Count;
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            return intRet;
        }

        /// <summary>
        /// This method will accepts column and row number of testSuite excel file and returns the cell value.
        /// </summary>
        /// <param name="iRow"></param>
        /// <param name="iCol"></param>
        /// <returns></returns>
        public static string getCellValue(int iRow, int iCol)
        {
            string strRet;
            string fileName = initializeTest.testSuitePath;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range range = xlWorkSheet.UsedRange;
            strRet = (string)(range.Cells[iRow, iCol] as Excel.Range).Value2;
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            return strRet;
        }

        /// <summary>
        /// This method will read the test data from the XML file and returns the same.
        /// </summary>
        /// <param name="testDataName"></param>
        /// <returns></returns>
        public static string readTestDataFromXML(string testDataName)
        {
            string strRet = "";
            string fileName = initializeTest.testXMLPath;
           // Console.WriteLine("FilePath= " + fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode node = doc.SelectSingleNode("/Environment/Variable" + "[Name = '" + testDataName + "']/Value");
            if (node != null)
            {
                strRet = node.InnerText;
            }
            return strRet;
        }

        /// <summary>
        /// This method will read the test data from the XML file and returns the same.
        /// </summary>
        /// <param name="testDataName"></param>
        /// <param name="value"></param>
        public static void updateTestDataToXML(string testDataName, string value)
            {
                string strFileName = initializeTest.testXMLPath;
                // Console.WriteLine("FilePath= " + fileName);
                XmlDocument doc = new XmlDocument();
                doc.Load(strFileName);
                XmlNode node = doc.SelectSingleNode("/Environment/Variable" + "[Name = '" + testDataName + "']/Value");
                if (node != null)
                {
                    node.InnerText = value;
                }
                doc.Save(strFileName);
            }

        /// <summary>
        /// This method will generate Time in the format hour:minute:second AM/PM and return the same
        /// </summary>
        /// <returns></returns>
        public static string Time()
        {
            string strRet;
            strRet = DateTime.Now.ToString("hh:mm:ss tt");
            return strRet;
        }

        /// <summary>
        /// This method will generate Timestamp based on Day_Month_Year_Hour_Minute_Second format and returns the same.
        /// </summary>
        /// <returns></returns>
        public static string Timestamp()
        {
            string strRet;
            strRet = DateTime.Now.ToString("dd_MMM_yyyy_HH_mm_ss");
            return strRet;
        }

        /// <summary>
        /// This method will copy the file from source location to destination location
        /// </summary>
        /// <param name="SourceFile"></param>
        /// <param name="DestinationFile"></param>
        public static void CopyFile(string SourceFile, string DestinationFile)
        {
            if (File.Exists(SourceFile))
            {
                System.IO.File.Copy(SourceFile, DestinationFile, true);
            }
            else
            {
                Console.WriteLine("Cannot Copy the file because Source File not found");
            }
        }

        /// <summary>
        /// This method will finds the duration between start date and end date.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static string Duration(string startDate, string endDate)
        {
            DateTime startDate1 = DateTime.Parse(startDate);
            DateTime endDate1 = DateTime.Parse(endDate);
            TimeSpan diff = endDate1.Subtract(startDate1);
            string strRet = diff.ToString(@"hh\:mm\:ss");
            return strRet;
        }

        /// <summary>
        /// This method will take a snapshot of the application and saves in the Screenshot Folder inside the results Folder.
        /// </summary>
        public static void CaptureScreen()
        {
            try
            {
                //Creating a new Bitmap object
                //Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);
                Bitmap captureBitmap = new Bitmap(1364, 768, PixelFormat.Format32bppArgb);

                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                System.Drawing.Rectangle captureRectangle = System.Windows.Forms.Screen.AllScreens[0].Bounds;

                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

                initializeTest.screenShotName = "ScreenShot_" + initializeTest.screenShotCounter + ".png";

                //Saving the Image File (I am here Saving it in My E drive).
                captureBitmap.Save(initializeTest.screenShotPath + "\\" + initializeTest.screenShotName, ImageFormat.Png);

                initializeTest.screenShotCounter = initializeTest.screenShotCounter + 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// This method will accept the project, class and method name and invokes the specific method.
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <param name="namespaceName"></param>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        public static void InvokeStringMethod(string assemblyName, string namespaceName, string className,string methodName)
        {
            // Get the Type for the class
            Type calledType = Type.GetType(namespaceName + "." + className + "," + assemblyName);

            // Invoke the method itself. The string returned by the method winds up in s
            String str = (String)calledType.InvokeMember(
                            methodName,
                            BindingFlags.InvokeMethod | BindingFlags.Public |
                                BindingFlags.Static,
                            null,
                            null,
                            null);
        }

        /// <summary>
        /// Initializes the driver with the browser specified in the AsspSeetings.json file
        /// </summary>
        public static void initializeDriver()
        {
            try
            {
                if (lib.generalLib.readjson("browser").ToUpper().Equals("IE"))
                {
                    lib.initializeTest.driver = new InternetExplorerDriver();
                }
                else if (lib.generalLib.readjson("browser").ToUpper().Equals("CHROME"))
                {
                    lib.initializeTest.driver = new ChromeDriver();
                }
                else if (lib.generalLib.readjson("browser").ToUpper().Equals("FIREFOX"))
                {
                    lib.initializeTest.driver = new FirefoxDriver();
                }
                else
                {
                    lib.initializeTest.driver = new InternetExplorerDriver();
                }
                lib.initializeTest.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                lib.initializeTest.driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Catch");
                lib.resultUtil.AddResult("initializeDriver", "Should initiatilize the RemoteWebDriver", "EXCEPTION: " + e, "FAIL");
            }
        }

        /// <summary>
        /// decrypt will accept the encrypted password, decrypts and returns the password
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decrypt(string input)
        {
            string strRet = null;
            try
            {
                string strPath = initializeTest.workspace + "\\config\\Pwd_Decrypt_ver2.exe " + input + " " + initializeTest.workspace + "\\temp.txt";
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(strPath);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                //cmd.WaitForExit();
                //cmd.Kill();
                strRet = File.ReadAllText(initializeTest.workspace + "\\temp.txt");
                strRet = strRet.Replace("!", "{!}");
            }
            catch (Exception ex)
            {
                lib.resultUtil.AddResult("Decrypt", "Should decrypt the provided password", "EXCEPTION: " + ex, "FAIL");
            }
            return strRet;
        }

        /// <summary>
        /// Quits the driver
        /// </summary>
        public static void quitDriver()
        {
            lib.initializeTest.driver.Quit();
            lib.resultUtil.AddResult("Quit Driver", "Should quit the driver", "Driver Successfully quit", "PASS");
        }

        /// <summary>
        /// This method enables or disables prompt for password option in the IE browser.
        /// </summary>
        /// <param name="promptPassword"></param>
        public static void ModifyIEBrowserSetting (String promptPassword)
        {
            string strPath = "";
            try
            {

                if (promptPassword.ToUpper().Equals("ENABLE"))
                {
                    strPath = initializeTest.workspace + "\\config\\ModifyIEBrowserSetting.exe Enable";
                }
                else if (promptPassword.ToUpper().Equals("DISABLE"))
                {
                    strPath = initializeTest.workspace + "\\config\\ModifyIEBrowserSetting.exe Disable";
                }
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(strPath);
                cmd.WaitForExit(15000);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                lib.resultUtil.AddResult("Modify IE Browser settings", "Should " + promptPassword + " IE browser setting - Prompt user id and password option", "Prompt user id and password option - "+ promptPassword, "PASS");
            }
            catch (Exception e)
            {
                lib.resultUtil.AddResult("Modify IE Browser settings", "Should " + promptPassword + " IE browser setting - Prompt user id and password option", "EXCEPTION: " + e, "FAIL");
            }
        }


        /// <summary>
        /// This method accepts element's XPATH or ID and waits for the object to appear for maximum time set in initializeTest.maxWait variable.
        /// Once the element found it clicks on the element.
        /// </summary>
        /// <param name="ObjectIdentifierType"></param>
        /// <param name="ObjectTypeValue"></param>
        /// <returns></returns>
        public static Boolean waitAndClick(string ObjectIdentifierType, string ObjectTypeValue)
        {
            Boolean ret = false;
            try
            {
                Console.WriteLine("WiatAndClick -> Object Type = " + ObjectIdentifierType + " Object Type Value = " + ObjectTypeValue);
                if (ObjectIdentifierType.ToUpper().Equals("XPATH"))
                {
                    for (int i = 0; i <= initializeTest.maxWait; i++)
                    {
                        try
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(ObjectTypeValue)).Click();
                            ret = true;
                            break;
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
                else if (ObjectIdentifierType.ToUpper().Equals("ID"))
                {
                    for (int i = 0; i <= initializeTest.maxWait; i++)
                    {
                        try
                        {
                            lib.initializeTest.driver.FindElement(By.Id(ObjectTypeValue)).Click();
                            ret = true;
                            break;
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
            }
            catch
            {
            }
            return ret;
        }

        /// <summary>
        /// This method accepts element's XPATH or ID and waits for the object to appear for maximum time set in initializeTest.maxWait variable.
        /// Once the element found it enters the value to the element.
        /// </summary>
        /// <param name="ObjectIdentifierType"></param>
        /// <param name="ObjectTypeValue"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Boolean waitAndEnter(string ObjectIdentifierType, string ObjectTypeValue, string value)
        {
            Boolean ret = false;
            try
            {
                Console.WriteLine("WiatAndEnter -> Object Type = " + ObjectIdentifierType + " Object Type Value = " + ObjectTypeValue);
                if (ObjectIdentifierType.ToUpper().Equals("XPATH"))
                {
                    for (int i = 0; i <= initializeTest.maxWait; i++)
                    {
                        try
                        {
                            lib.initializeTest.driver.FindElement(By.XPath(ObjectTypeValue)).SendKeys(value);
                            ret = true;
                            break;                        
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
                else if (ObjectIdentifierType.ToUpper().Equals("ID"))
                {
                    for (int i = 0; i <= initializeTest.maxWait; i++)
                    {
                        try
                        {
                            lib.initializeTest.driver.FindElement(By.Id(ObjectTypeValue)).SendKeys(value);
                            ret = true;
                            break;
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            return ret;
        }

        /// <summary>
        /// This method will accept the element's XPATH or ID and waits for the object to appear for maximum time set in initializeTest.maxWait variable.
        /// </summary>
        /// <param name="ObjectIdentifierType"></param>
        /// <param name="ObjectTypeValue"></param>
        /// <returns></returns>
        public static Boolean waitForObject(string ObjectIdentifierType, string ObjectTypeValue)
        {
            Boolean ret = false;
            try
            {
                Console.WriteLine("WiatForObject -> Object Type = " + ObjectIdentifierType + " Object Type Value = " + ObjectTypeValue);
                if (ObjectIdentifierType.ToUpper().Equals("XPATH"))
                {
                    for (int i = 0; i <= initializeTest.maxWait; i++)
                    {
                        try
                        {
                            if (lib.initializeTest.driver.FindElement(By.XPath(ObjectTypeValue)).Displayed)
                            {
                                ret = true;
                                break;
                            }
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
                else if (ObjectIdentifierType.ToUpper().Equals("ID"))
                {
                    for (int i = 0; i <= initializeTest.maxWait; i++)
                    {
                        try
                        {
                            if (lib.initializeTest.driver.FindElement(By.Id(ObjectTypeValue)).Displayed)
                            {
                                ret = true;
                                break;
                            }
                        }
                        catch
                        {
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
            }
            catch
            {
            }
            return ret;
        }

    }
}
