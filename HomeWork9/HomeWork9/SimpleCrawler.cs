using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork9
{
    class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public StringBuilder message = new StringBuilder();

        public void Crawl()
        {
            message.Append("开始爬行了.... \n");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                message.Append("爬行" + current + "页面!\n");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(current, html);//解析,并加入新的链接
                message.Append("爬行结束\n");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                message.Append(ex.Message+"\n");
                return "";
            }
        }

        private void Parse(string current, string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(html|aspx|jsp)[""']";//解析超链接中的东西
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                            .Trim('"', '\"', '#', '>');
                strRef = toAbsolutePath(current, strRef);
                if (!strRef.StartsWith("https://www.cnblogs.com"))
                {
                    strRef = "";
                }
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        private string toAbsolutePath(string current,string strRef)
        {
            //不完整地址转完整地址
            if(strRef.StartsWith("//"))
            {
                int i = current.IndexOf("/");
                string protocal = current.Substring(0, i);
                return protocal + strRef;
            }else if(strRef.StartsWith("/"))
            {
                var domain = current.Split('/');
                string protocal = domain[0];
                string host = domain[2];
                return protocal + "//" + host + strRef;
            }else if(strRef.StartsWith("../"))//相对路径转换为绝对路径
            {
                int i = current.LastIndexOf("/");
                string str = current.Substring(0, i);
                return str + strRef.Substring(2);
            }else if(strRef.StartsWith("http"))
            {
                return strRef;
            }else
            {
                return current + "/" + strRef;
            }
        }
    }
}
