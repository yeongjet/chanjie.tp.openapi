using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using Ufida.T.EAP.Net;

namespace Chanjet.TP.OpenAPI.Demo
{
    

    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        Chanjet.TP.OpenAPI.OpenAPI TPlusAPI = null;

		Args demoArgs = new Args();

		string curResource_Method { get; set; }



		private void CreateDoc()
		{
			OpenAPI api = new OpenAPI("http://127.0.0.1/TPlus/api/v1/", new Credentials()
			{
				AppKey = "myAppKey",
				AppSecret = "myAppSecret",
				UserName = "demo",
				Password = "",
				AccountNumber = "1",
				LoginDate = DateTime.Now.ToString("yyyy-MM-dd")
			});                                            //创建OpenAPI的调用对象(传入服务地址，及认证信息)

			api.GetToken();                        //申请访问授权

			api.Call("doc/Create",                    //调用凭证的创建服务
			@"{  
        dto: {
            ExternalCode:""002"",
            DocType: { Code: ""记"" }, 
            VoucherDate: """ + DateTime.Now.ToString("yyyy-MM-dd") + @""",
            Entrys: [
                { 
                    Account: { ""Code"": ""1001"" },
                    Currency: { ""Code"": ""RMB"" },
                    Summary: ""提现"", AmountCr: ""100""
                }
                , { 
                    Account: { ""Code"": ""1002"" },
                    Currency: { ""Code"": ""RMB"" },
                    Summary: ""提现"", AmountDr: ""100""
                }]
        }
    }");

			api.Call("inventory/Query", "{param:{Code:\"001\"}}");
			api.Call("", "");

		}








		private void btnConnectTest_Click(object sender, EventArgs e)
		{
            /*
			Credentials credentials = new Credentials()
			{
				AppKey = txtAppKey.Text,
				AppSecret = txtAppSecret.Text
			};

			string host = "127.0.0.1", uri = "TPlus/api/v1/rest/Connect";
			string ApiUrl = string.Format("http://{0}/{1}", host, uri);
			WebClient wc = new WebClient();
			wc.Headers["Authorization"] = credentials.Signature(ApiUrl, string.Format("{0:R}", DateTime.Now));
			string returnValue = wc.DownloadString(ApiUrl);

			txtLog.AppendText("\r\n Call:ConnectTest \r\n result:" + returnValue);

			return;
			 */

            string testConnStr = cmServerURL.Text;
            if (testConnStr.Contains("api/v2"))
            {
                testConnStr = testConnStr.Replace("api/v2","api/v1");
            }

            OpenAPI api = new OpenAPI(testConnStr, new Credentials()
			{
				AppKey = txtAppKey.Text,
				AppSecret = txtAppSecret.Text
			});

			try
			{
				dynamic r = api.ConnectTest();

				txtLog.AppendText("\r\n Call:Connection \r\n result:" + r.status + "\r\n" + r.ToString());
			}
			catch (RestException ex)
			{
                if (ex==null || ex.Response==null)
                {
                    txtLog.AppendText("请求地址错误！"  );
                }
                else
                {
                    txtLog.AppendText("\r\n Call:Connection \r\n error:" + ex.Response.StatusCode + "  " + ex.Message + "\r\n" + ex.ResponseBody);
                }				
			}
		}


		private void btnReLogin_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic r = this.TPlusAPI.ReLogin();

				txtLog.AppendText("\r\n Call:ReLogin \r\n result:" + r.access_token + "\r\n" + r.ToString());
			}
			catch (RestException ex)
			{
				txtLog.AppendText("\r\n Call:GetToken \r\n error:" + ex.Response.StatusCode + "  " + ex.Message + "\r\n" + ex.ResponseBody);
			}

		}


		private void btnGetToken_Click(object sender, EventArgs e)
		{
            string strServerUrl = cmServerURL.Text;
            if (cmServerURL.Text.Contains("api/v2"))
            {
                strServerUrl = strServerUrl.Replace("api/v2","api/v1");
                cmServerURL.Text = strServerUrl;
            }

            this.TPlusAPI = new OpenAPI(strServerUrl, new Credentials()
			{
				AppKey = txtAppKey.Text,
				AppSecret = txtAppSecret.Text,
				UserName = txtUserName.Text,
				Password = txtPassWord.Text,
				LoginDate = txtLoginDate.Text,
				AccountNumber = txtAccountNum.Text
			});

			try
			{
				dynamic r = r = TPlusAPI.GetToken();
				Console.Write((string)r.access_token);
				txtLog.AppendText("\r\n Call:GetToken \r\n result:" + r.access_token + "\r\n" + r.ToString());
			}
			catch (RestException ex)
			{
				txtLog.AppendText("\r\n Call:GetToken \r\n error:" + ex.Response.StatusCode + "  " + ex.Code + "  " + ex.Data + "  " + ex.Message + "\r\n" + ex.ResponseBody);
				if (ex.Code == "EXSM0004")
				{
					if (MessageBox.Show(ex.Message, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					{
						this.btnReLogin_Click(sender, e);
					}
				}
			}

		}


		private void btnLogout_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic r = TPlusAPI.Logout();
				txtLog.AppendText("\r\n Call:Logout \r\n result:" + r);
			}
			catch (RestException ex)
			{
				txtLog.AppendText("\r\n Call:Logout \r\n error:" + ex.Message + "\r\n" + ex.ResponseBody);
			}
		}

		bool isLogined()
		{
			if (TPlusAPI != null && !string.IsNullOrEmpty(TPlusAPI.Credentials.Access_Token))
				return true;
			return false;
		}


		#region UIController
		private void cbEncoder_CheckedChanged(object sender, EventArgs e)
		{
			string apiValue = txtArgs.Text;

			if (cbEncoder.Checked)
			{
				if (apiValue.StartsWith("{"))
				{
					apiValue = HttpUtility.UrlEncode(apiValue, Encoding.UTF8);
				}
			}
			else
			{
				if (!apiValue.StartsWith("{"))
				{
					apiValue = HttpUtility.UrlDecode(apiValue, Encoding.UTF8);
				}

			}

			txtArgs.Text = apiValue;

		}


		private void Form1_Load(object sender, EventArgs e)
		{
			txtLoginDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            InitParam();
        }

        private void InitParam()
        {
            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
            if (!File.Exists(currentFolder + "Chanjet.TP.OpenAPI.Demo.xml")) return;
            XmlDocument toolConfig = new XmlDocument();
            toolConfig.Load("Chanjet.TP.OpenAPI.Demo.xml");
            XmlElement root = toolConfig.DocumentElement;
            EnvironmentEric.appkey =root.GetElementsByTagName("appkey")[0].InnerText;
            EnvironmentEric.appsecret = root.GetElementsByTagName("appsecret")[0].InnerText;
            EnvironmentEric.serverUrl = root.GetElementsByTagName("serverUrl")[0].InnerText;
            EnvironmentEric.userName = root.GetElementsByTagName("userName")[0].InnerText;
            EnvironmentEric.userPwd = root.GetElementsByTagName("userPwd")[0].InnerText;
            EnvironmentEric.accNum = root.GetElementsByTagName("accNum")[0].InnerText;
            EnvironmentEric.privateKeyPath = root.GetElementsByTagName("privateKeyPath")[0].InnerText;
            EnvironmentEric.orgId = root.GetElementsByTagName("orgId")[0].InnerText;

            txtAppKey.Text = EnvironmentEric.appkey;
            txtAppSecret.Text = EnvironmentEric.appsecret;
            cmServerURL.Text = EnvironmentEric.serverUrl;
            txtUserName.Text = EnvironmentEric.userName;
            txtPassWord.Text = EnvironmentEric.userPwd;
            txtAccountNum.Text = EnvironmentEric.accNum;
            txtPriKeyPath.Text = EnvironmentEric.privateKeyPath;
            textBoxOrgId.Text = EnvironmentEric.orgId;
        }
        #endregion


        string[] restResourceMethod = new string[] { 
        ""
        ,"inventory/Query"
        ,"brand/Query"
        ,"freeItemType/Query"
        ,"freeItem/Query"
        ,"warehouse/Query"
        ,"barCode/Query"
        ,"voucherDraft/Query"
        ,""
        ,""
        ,"saleDelivery/Create"
        ,"saleDelivery/CreateBatch"
        ,""
        ,"otherDispatch/Create"
        ,"otherDispatch/CreateBatch"
        ,"currentStock/Query"
        ,""
        ,""
        ,"doc/Create"
        ,"doc/CreateBatch"
        };

		private void lstRestResourceMethod_SelectedIndexChanged(object sender, EventArgs e)
		{ 
			curResource_Method = restResourceMethod[lstRestResourceMethod.SelectedIndex];
			txtResourceName.Text = curResource_Method;
			if (curResource_Method == "")
			{
				txtArgs.Text = string.Empty;
				return;
			}
			string argFieldName = curResource_Method.Replace("/", "_");
			txtArgs.Text = typeof(Args).GetField(argFieldName).GetValue(demoArgs).ToString();
			txtArgs.Text = txtArgs.Text.Replace("2014-09-30", DateTime.Now.ToString("yyyy-MM-dd"));

		}

		private void btnPOST_Click(object sender, EventArgs e)
		{
            //查看是v1 还是v2
            if (this.cmServerURL.Text.ToLowerInvariant().Contains("v1"))
            {
                if (!isLogined())
                {
                    if (MessageBox.Show("未登录，是否登录？", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.btnGetToken_Click(sender, e);
                    }
                    else
                    {
                        return;
                    }
                }


                try
                {
                    string result = this.TPlusAPI.Call<string>(txtResourceName.Text, txtArgs.Text);

                    //dynamic result = this.TPlusAPI.Call(txtResourceName.Text, txtArgs.Text);

                    txtLog.AppendText("\r\n\r\n call:" + txtResourceName.Text);
                    txtLog.AppendText("\r\n result:" + result);
                }
                catch (RestException ex)
                {
                    txtLog.AppendText("\r\n\r\n call:" + txtResourceName.Text);
                    txtLog.AppendText("\r\n error:" + ex.Message + "\r\n" + ex.ResponseBody);
                }
            }
            else
            {
                //v2
                try {
                    string appkey = this.txtAppKey.Text.Trim();
                    string appsecret = this.txtAppSecret.Text.Trim();
                    string orgid = this.textBoxOrgId.Text.Trim();
                    //业务请求的Authorization
                    var customParas = new Dictionary<string, object>
                {
                    {"access_token", token_v2},

                };
                    //默认规则是当前参数+appsecret，组成签名的原值
                    var bizheader = new Dictionary<string, object>
                {
                    {"appkey", appkey},
                    {"orgid",fromOrgId?orgid:string.Empty},
                    {"appsecret", appsecret}
                };
                    string privateKeyPath = this.txtPriKeyPath.Text.Trim();
                    if (string.IsNullOrEmpty(privateKeyPath) || !File.Exists(privateKeyPath))
                    {
                        MessageBox.Show("请指定私钥路径！");
                    }

                    RestSharp.Serializers.JsonSerializer jsonSerializer = new RestSharp.Serializers.JsonSerializer();
                    string bizdatas = jsonSerializer.Serialize(bizheader);
                    Ufida.T.EAP.Net.security.TokenManage tokenManage = new Ufida.T.EAP.Net.security.TokenManage();
                    string bizAuthorization = tokenManage.CreateSignedToken(bizdatas, privateKeyPath, customParas);
                    ITRestRequest restquest1 = new TRestRequest();
                    restquest1.Method = TMethod.POST;
                    string serverUrl = this.cmServerURL.Text.Trim();
                    string host = serverUrl.Substring(0, serverUrl.IndexOf('/', serverUrl.IndexOf("//") + 2) + 1);
                    restquest1.Resource = serverUrl.Replace(host, "") + txtResourceName.Text;
                    string authStr1 = @"{""appKey"":""" + appkey + @""",""authInfo"":""" + bizAuthorization + @""",""orgId"":" + (fromOrgId ? orgid : @"""""") + @"}";
                    string encode1 = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(authStr1));
                    restquest1.AddParameter("Authorization", encode1, TParameterType.HttpHeader);
                    string args = txtArgs.Text;
                    restquest1.AddParameter("_args", args);
                    TRestClient restclient = new TRestClient(host);
                    string responsedata1 = restclient.Execute(restquest1);
                    txtLog.AppendText("\r\n\r\n call:" + txtResourceName.Text);
                    txtLog.AppendText("\r\n result:" + responsedata1);
                }
                catch (Exception ex)
                {
                    txtLog.AppendText("\r\n\r\n call:" + txtResourceName.Text);
                    txtLog.AppendText("\r\n error:" + ex.Message);
                }
            }
        }


		private void btnGET_Click(object sender, EventArgs e)
		{
			if (!isLogined())
			{
				MessageBox.Show("请先登录！");
				return;
			}

		}

		private void lstRestResourceMethod_DoubleClick(object sender, EventArgs e)
		{
			if (txtResourceName.Text != "")
			{
				this.btnPOST_Click(sender, e);
			}
		}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
        private string token_v2 = "";
        private bool fromOrgId = false; 
        private void button1_Click(object sender, EventArgs e)
        {

            // v2 获取token
            string appkey = this.txtAppKey.Text.Trim();
            string appsecret = this.txtAppSecret.Text.Trim();
            string orgid = this.textBoxOrgId.Text.Trim();
            var header = new Dictionary<string, object>
            {
                {"appkey", appkey},
                {"orgid",orgid},//90009444367
                {"appsecret", appsecret}
            };
            RestSharp.Serializers.JsonSerializer jsonSerializer = new RestSharp.Serializers.JsonSerializer();
            string datas = jsonSerializer.Serialize(header);
            Ufida.T.EAP.Net.security.TokenManage tokenManage = new Ufida.T.EAP.Net.security.TokenManage();
            string signvalue = tokenManage.CreateSignedToken(datas, @"D:\cjet_pri.pem");
            string authStr = @"{""appKey"":""" + appkey + @""",""authInfo"":""" + signvalue + @""",""orgId"":" + orgid + @"}";
            string encode = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(authStr));
            string serverUrl = this.cmServerURL.Text.Trim();
            string host = serverUrl.Substring(0, serverUrl.IndexOf('/', serverUrl.IndexOf("//") + 2)+1);
            TRestClient restclient = new TRestClient(host);
            ITRestRequest restquest = new TRestRequest();
            restquest.Resource = serverUrl.Replace(host,"")+ "collaborationapp/GetAnonymousTPlusToken?IsFree=1";
            restquest.AddParameter("Authorization", encode, TParameterType.HttpHeader);
            restquest.Method = TMethod.POST;
            string responsedata = restclient.Execute(restquest);
            Newtonsoft.Json.Linq.JObject token = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(responsedata);
            token_v2 = token["access_token"].ToString();
            txtLog.AppendText("\r\n Call:GetTokenV2 \r\n result:" + token_v2 );
            fromOrgId = true;
        }

        private void btnOthFeatures_Click(object sender, EventArgs e)
        {
            OtherFuncForm form = new OtherFuncForm();
            form.Show();
        }

        private void txtArgs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnV2LoginWithUserPwd_Click(object sender, EventArgs e)
        {
            // v2 获取token 用户名 密码
            string appkey = this.txtAppKey.Text.Trim();
            string appsecret = this.txtAppSecret.Text.Trim();
            string userName = this.txtUserName.Text.Trim();
            string pass = this.txtPassWord.Text.Trim();
            string caccNum = this.txtAccountNum.Text.Trim();
            string privateKeyPath = this.txtPriKeyPath.Text.Trim();
            if (string.IsNullOrEmpty(privateKeyPath) || !File.Exists(privateKeyPath))
            {
                MessageBox.Show("请指定私钥路径！");
            }
            var header = new Dictionary<string, object>
            {
                {"appkey", appkey},
                {"orgid",string.Empty},//90009444367
                {"appsecret", appsecret}
            };
            RestSharp.Serializers.JsonSerializer jsonSerializer = new RestSharp.Serializers.JsonSerializer();
            string datas = jsonSerializer.Serialize(header);
            Ufida.T.EAP.Net.security.TokenManage tokenManage = new Ufida.T.EAP.Net.security.TokenManage();
            
            string signvalue = tokenManage.CreateSignedToken(datas, privateKeyPath);
            string authStr = @"{""appKey"":""" + appkey + @""",""authInfo"":""" + signvalue + @""",""orgId"":""""}";
            string encode = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(authStr));
            string serverUrl = this.cmServerURL.Text.Trim();
            if (serverUrl.Contains("api/v1"))
            {
                serverUrl = serverUrl.Replace("api/v1", "api/v2");
                cmServerURL.Text = serverUrl;
            }
            string host = serverUrl.Substring(0, serverUrl.IndexOf('/', serverUrl.IndexOf("//") + 2) + 1);
            TRestClient restclient = new TRestClient(host);
            ITRestRequest restquest = new TRestRequest();
            restquest.Resource = serverUrl.Replace(host, "") + "collaborationapp/GetRealNameTPlusToken?IsFree=1";
            restquest.AddParameter("Authorization", encode, TParameterType.HttpHeader);
            pass=this.EncodeMD5(pass);
            string args = string.Format("{{userName:\"{0}\",password:\"{1}\",accNum:\"{2}\"}}", userName, pass,caccNum);
            restquest.AddParameter("_args", args);
            restquest.Method = TMethod.POST;
            string responsedata = restclient.Execute(restquest);
            Newtonsoft.Json.Linq.JObject token = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(responsedata);
            if (token["access_token"] != null) { 
                token_v2 = token["access_token"].ToString();
                txtLog.AppendText("\r\n Call:GetTokenV2 \r\n result:" + token_v2);
                txtLog.AppendText("\r\n Call:Signed Authorization \r\n result:" + encode);
                fromOrgId = false;
            }
            else
            {
                txtLog.AppendText("\r\n Call:GetTokenV2 \r\n result:" + responsedata);
            }
        }
        /// <summary>
        /// 对密码进行加密
        /// </summary>
        /// <param name="password"></param>
        public void EncryptPass(ref string password)
        {
            UTF8Encoding encode = new UTF8Encoding();
            Byte[] hashByte = new byte[] { };

            //if (password.Length == 32)//支持前端md5的密码。
            //{
            //    hashByte = Ufida.T.EAP.Aop.Util.SpereTool.ConvertHexToBytes(password.ToUpper());
            //}
            //else
            {
                System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

                hashByte = md5.ComputeHash(encode.GetBytes(password));
            }

            password = Convert.ToBase64String(hashByte);
        }

        public string EncodeMD5(string str)
        {
            UTF8Encoding encode = new UTF8Encoding();
            Byte[] hashByte = new byte[] { };

            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            hashByte = md5.ComputeHash(encode.GetBytes(str));

            return Ufida.T.EAP.Aop.Util.SpereTool.ConvertBytesToHex(hashByte, false);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && e.Modifiers == Keys.Control)
            {
                this.btnOthFeatures.Visible = true;
            }
        }
    }
}
