using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Main
{

    public partial class Main : Skin_Mac
    {
        public Main()
        {
            InitializeComponent();
        }

        private static List<string> ok_url = new List<string>();
        /// <summary>
        /// 鼠标点击隐藏默认数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Token_text_MouseClick(object sender, EventArgs e)
        {
            Token_text.Text = "";
        }
        /// <summary>
        /// 鼠标点击隐藏默认数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Site_text_MouseClick(object sender, MouseEventArgs e)
        {
            Site_text.Text = "";
        }

        private void LinkSubmit_Click(object sender, EventArgs e)
        {
            if (ok_url.Count == 0)
            {
                MessageBox.Show("请先验证数据！"); return;
            }
            if (string.IsNullOrWhiteSpace(Site_text.Text))
            {
                MessageBox.Show("请输入搜索资源平台验证的站点(必须带http或者https)！"); return;
            }
            if (string.IsNullOrWhiteSpace(Token_text.Text))
            {
                MessageBox.Show("请输入在搜索资源平台申请的推送用的准入密钥！"); return;
            }
            var str = Linksubmit(Site_text.Text, Token_text.Text, ok_url);
            try
            {
                Result_Sucess res = JsonConvert.DeserializeObject<Result_Sucess>(str);
                skinLabel4.Text = "提交结果：" + res.success + "条成功，当天剩余的可推送" + res.remain + "条！";
            }
            catch (Exception ex)
            {
                Result_Error res = JsonConvert.DeserializeObject<Result_Error>(str);
                skinLabel4.Text = "提交结果：" + res.error + "错误，错误原因:" + res.message;
            }

        }
        private string Linksubmit(string site, string token, List<string> url)
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = "http://data.zz.baidu.com/urls?site=" + site + "&token=" + token,//URL     必需项  
                Method = "Post",//URL     可选项 默认为Get  
                Timeout = 100000,//连接超时时间     可选项默认为100000  
                ReadWriteTimeout = 30000,//写入Post数据超时时间     可选项默认为30000  
                //IsToLower = false,//得到的HTML代码是否转成小写     可选项默认转小写  
                Cookie = "",//字符串Cookie     可选项  
                UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",//用户的浏览器类型，版本，操作系统     可选项有默认值  
                Accept = "text/html, application/xhtml+xml, */*",//    可选项有默认值  
                ContentType = "text/plain",//返回类型    可选项有默认值  
                Referer = site,//来源URL     可选项 
                Postdata = rtfRichTextBox1.Text,//Post数据     可选项GET时不需要写
                ResultType = ResultType.String,//返回数据类型，是Byte还是String  
                //CURLOPT_HTTPHEADER => array('Content-Type: text/plain'),
            };
            HttpResult result = http.GetHtml(item);
            string html = result.Html;
            string cookie = result.Cookie;
            return html;
        }
        //封装的方法
        static bool ExactMatch(string input, string match)
        {
            //bool contains = Regex.IsMatch("Hello1 Hello2", "Hello"); // 输出 false
            return Regex.IsMatch(input, match);
            //return Regex.IsMatch(input, string.Format(@"b{0}b", Regex.Escape(match)));
        }
        /// <summary>
        /// 验证数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Verification_Button_Click(object sender, EventArgs e)
        {
            string _site_text = Site_text.Text;
            if (string.IsNullOrWhiteSpace(_site_text))
                return;
            string url_txt = rtfRichTextBox1.Text;
            string[] url_list_string = url_txt.Split('\n');//截取每行数据
            int num = url_list_string.Count();
            if (num == 0)
                return;
            int z = 0, y = 0;
            for (int i = 0; i < num; i++)
            {
                if (ExactMatch(url_list_string[i], _site_text))
                {
                    ok_url.Add(url_list_string[i]);
                    z++;
                }
                else
                    y++;
            }
            skinLabel4.Text = "验证数据：" + z + "条正常，" + y + "条失败！";
        }


    }
    /// <summary>
    /// 返回成功时候
    /// </summary>
    public class Result_Sucess
    {
        /// <summary>
        /// 成功推送的url条数
        /// </summary>
        public int success { get; set; }
        /// <summary>
        /// 当天剩余的可推送url条数
        /// </summary>
        public int remain { get; set; }
    }
    /// <summary>
    /// 返回错误时候
    /// </summary>
    public class Result_Error
    {
        /// <summary>
        /// 错误码，与状态码相同
        /// </summary>
        public int error { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string message { get; set; }
    }
}
