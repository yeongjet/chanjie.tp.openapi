using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Ufida.T.EAP.Net;
using System.Web.Script.Serialization;

namespace Chanjet.TP.OpenAPI.Demo
{
    public partial class OtherFuncForm : Form
    {
        public OtherFuncForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num = Convert.ToInt32(this.textBox2.Text);
            #region json串
            var json = System.IO.File.ReadAllText("D:/11.txt");
            #endregion
            for (int i = 0; i < num; i++)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Ufida.T.SM.MessageTransfer.Interface.MessageStruct>(json);
                sw.Stop();
                var elapsed1 = sw.ElapsedMilliseconds;
                sw.Restart();
                json = Newtonsoft.Json.JsonConvert.SerializeObject(obj, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
                sw.Stop();
                var elapsed2 = sw.ElapsedMilliseconds;
                this.textBox1.AppendText(string.Format("反序列化：{0}ms，序列化：{1}ms\r\n", elapsed1, elapsed2));
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOthFeatures_Click(object sender, EventArgs e)
        {
            string responsedata = string.Empty;
            try
            {
                //云上获取证书
                string appKey = this.textBox3.Text;
                TRestClient restclient = new TRestClient("http://advertise.tplus.chanjet.com/");
                ITRestRequest restquest = new TRestRequest();
                restquest.Resource = "adv/tapi/v1/pubkey";
                restquest.AddParameter("Content-Type", "text/json", TParameterType.HttpHeader);
                restquest.AddParameter("appkey", appKey, TParameterType.QueryString);
                restquest.Method = TMethod.GET;
                responsedata = restclient.Execute(restquest);
                JavaScriptSerializer ser = new JavaScriptSerializer();
                //json是字典类型
                var json = ser.Deserialize<dynamic>(responsedata);
                this.textBox1.AppendText("成功："+ responsedata);
            }
            catch (Exception ex)
            {
                this.textBox1.AppendText("异常："+ex.Message);
                this.textBox1.AppendText("responsedata："+responsedata);
            }
        }

        private void btnV2LoginWithUserPwd_Click(object sender, EventArgs e)
        {
            var pubkey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCtM/qULfm3c6YHJCMKGXblkJwu
JDK2YR/4V3Oi+0V9HK/VKzg4fNJfIUbFBbioBOsMiP+/dqQ/14CBCkN0DojtLbwl
OTNXbFkzMUg6gXt+yKUHlz60/ZZlm5t/g/MeZ6XViuk6VvqG2XI7Mw5moMyfTTPN
W9JruWaHJWsFzqM6/QIDAQAB
-----END PUBLIC KEY-----";
            var prikey = @"-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQCtM/qULfm3c6YHJCMKGXblkJwuJDK2YR/4V3Oi+0V9HK/VKzg4
fNJfIUbFBbioBOsMiP+/dqQ/14CBCkN0DojtLbwlOTNXbFkzMUg6gXt+yKUHlz60
/ZZlm5t/g/MeZ6XViuk6VvqG2XI7Mw5moMyfTTPNW9JruWaHJWsFzqM6/QIDAQAB
AoGBAJ6u75WQ5adgqi0Cu6OGHvtF2QEhIuEa7Npu7L/WbByrCqFHnpOKMIb9isP5
cOtmzh5G6eD1hpgDDXWr/I64vlLkIkKLuoTJbKZ2315ckXKaNUORy3db3deaN91N
3/enKFs/xGYkoKdDO4wXPRM7Y2QSmfTsj8KgTwSVFm/vhjG1AkEA2tIGjnvrMpEt
/Gw298cCqgFu0gWWv1LtXeOSpqxZuDzGv0wI8Vc10zuuSUZLtQ3c8RcKrEZCp5WA
4/TYZg6UZwJBAMqhvxF3CSgcbolpbIvxuOysovXOi1Se/qAmhE8WjrHOdjed+CUn
7ZWlYsomM3gBu/xZ/OuRVNXUOhRW+eZmNvsCQQDMV8+5pW0pZrwr+p6GWrlZK0dj
J8bz2ixCPm/H6DFMxKzRHd9ICSoBnb0PPm8an9yQ4/Salm5Oc2XO+upOvBTHAkBg
u3JxLfhLE7eZFaDh9dUn9woceit9jCFV5s1GzCf2re81gc4SPstmovtUMYRkh79s
KrFY65oqMhQ/3X2TBby9AkBpSbP5TkLVUuFaB8W9U1LqdWoZlK6WD/p/xrNmCCUj
dVn60X/29/qNsOmxUJJE5IOm7vEHc5MwiPiZfbK2jDDr
-----END RSA PRIVATE KEY-----";

            
            string content = this.textBox4.Text;
            //System.Security.Cryptography.RSACryptoServiceProvider publicX509key = CSharp_easy_RSA_PEM.Crypto.DecodeX509PublicKey(pubkey);
            //var encrypted= CSharp_easy_RSA_PEM.Crypto.EncryptString(content, publicX509key);
            //this.textBox1.AppendText("加密后串："+encrypted+"/r/n");
            //System.Security.Cryptography.RSACryptoServiceProvider privateRSAkey = CSharp_easy_RSA_PEM.Crypto.DecodeRsaPrivateKey(prikey);
            //var dencrypted = CSharp_easy_RSA_PEM.Crypto.DecryptString(encrypted, privateRSAkey);


           
            var encrypted = Rsa(content);
            this.textBox1.AppendText("加密后串：" + encrypted + "/r/n");
            var dencrypted = UnRsa(encrypted);
            this.textBox1.AppendText("解密后串：" + dencrypted + "/r/n");
        }

        /// <summary>
        /// RSA 加密
        /// </summary>
        public string Rsa(string source)
        {
            var pubkey1 = @"<RSAKeyValue>
  <Modulus>8Yvf/LjXRhCuOREk2CuSYvbD/RadwJ4sjHREIpQVKwkTlG3BtRgpnaMcoeLAesmwvpBWnqK4hBkYLxhRj+NEKnlGrJ+LkNMnZr0/4CMuulZFAnx7iQYaSq7Eh7kBKGLofc05CjZguYpnPNxHIv4VNx+a9tIh+hnhjrmkJLUm3l0=</Modulus>
  <Exponent>AQAB</Exponent>
</RSAKeyValue>";
           
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider();
            rsa.FromXmlString(pubkey1);
            var cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(source), true);
            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        /// RSA解密
        /// </summary>
        public string UnRsa(string source)
        {
            var prikey1 = @"<RSAKeyValue>
  <Modulus>8Yvf/LjXRhCuOREk2CuSYvbD/RadwJ4sjHREIpQVKwkTlG3BtRgpnaMcoeLAesmwvpBWnqK4hBkYLxhRj+NEKnlGrJ+LkNMnZr0/4CMuulZFAnx7iQYaSq7Eh7kBKGLofc05CjZguYpnPNxHIv4VNx+a9tIh+hnhjrmkJLUm3l0=</Modulus>
  <Exponent>AQAB</Exponent>
  <P>/xAaa/4dtDxcEAk5koSZBPjuxqvKJikpwLA1nCm3xxAUMDVxSwQyr+SHFaCnBN9kqaNkQCY6kDCfJXFWPOj0Bw==</P>
  <Q>8m8PFVA4sO0oEKMVQxt+ivDTHFuk/W154UL3IgC9Y6bzlvYewXZSzZHmxZXXM1lFtwoYG/k+focXBITsiJepew==</Q>
  <DP>ONVSvdt6rO2CKgSUMoSfQA9jzRr8STKE3i2lVG2rSIzZosBVxTxjOvQ18WjBroFEgdQpg23BQN3EqGgvqhTSQw==</DP>
  <DQ>gfp7SsEM9AbioTDemHEoQlPly+FyrxE/9D8UAt4ErGX5WamxSaYntOGRqcOxcm1djEpULMNP90R0Wc7uhjlR+w==</DQ>
  <InverseQ>C0eBsp2iMOxWwKo+EzkHOP0H+YOitUVgjekGXmSt9a3TvikQNaJ5ATlqKsZaMGsnB6UIHei+kUaCusVX0HgQ2A==</InverseQ>
  <D>tPYxEfo9Nb3LeO+SJe3G1yO+w37NIwCdqYB1h15f2YUMSThNVmpKy1HnYpUp1RQDuVETw/duu3C9gJL8kAsZBjBrVZ0zC/JZsgvSNprfUK3Asc4FgFsGfQGKW1nvvgdMbvqr4ClB0R8czkki+f9Oc5ea/RMqXxlI+XjzMYDEknU=</D>
</RSAKeyValue>";
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider();
            rsa.FromXmlString(prikey1);
            var cipherbytes = rsa.Decrypt(Convert.FromBase64String(source), true);
            return Encoding.UTF8.GetString(cipherbytes);
        }
    }
}
