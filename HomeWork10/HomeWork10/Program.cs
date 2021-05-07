using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Program
    {
        public ConcurrentQueue<string> pending = new ConcurrentQueue<string>();
        public ConcurrentDictionary<string,bool> urls = new ConcurrentDictionary<string,bool>();
        public int count = 0;
        public StringBuilder message = new StringBuilder();

        static void Main(string[] args)
        {
            Program p = new Program();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            p.urls.TryAdd(startUrl, false);//加入初始页面
            Stopwatch st = new Stopwatch();
            st.Start();
            /*Thread th = new Thread(p.Crawl);
            th.Start();
            Console.WriteLine(p.message.ToString());
            th.Join();*/
            /*Parallel.Invoke(p.Crawl);*/
            p.Crawl();
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds);
            Console.WriteLine(p.count);
        }
        
        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... \n");
            List<Task> tasks = new List<Task>();
            int index = 0;
            string html = "";
            while (tasks.Count<10)
            {
               /* Console.WriteLine("debug");*/
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    this.pending.Enqueue(url);
                }
               
                if (pending.TryDequeue(out current))
                {
                    /*Console.WriteLine("debug");*/
                    index++;
                    var task = new Task(() =>
                    {
                        Console.WriteLine("爬行" + current + "页面!\n");
                        html = DownLoad(index,current); // 下载
                        urls[current] = true;
                        count++;
                        Parse(current, html);//解析,并加入新的链接
                        Console.WriteLine("爬行结束\n");
                    });
                   

                    tasks.Add(task);
                }else
                {
                    break;
                }
            }
          
            count = tasks.Count;
            foreach(Task t in tasks)
            {
                t.Start();
            }
            Task.WaitAll(tasks.ToArray());
           /* Console.WriteLine("debug");*/

        }

        public string DownLoad(int index,string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = index.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
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
                urls.TryAdd(strRef, false);
              
                /*if (urls[strRef] == null) urls[strRef] = false;*/
            }
        }

        private string toAbsolutePath(string current, string strRef)
        {
            //不完整地址转完整地址
            if (strRef.StartsWith("//"))
            {
                int i = current.IndexOf("/");
                string protocal = current.Substring(0, i);
                return protocal + strRef;
            }
            else if (strRef.StartsWith("/"))
            {
                var domain = current.Split('/');
                string protocal = domain[0];
                string host = domain[2];
                return protocal + "//" + host + strRef;
            }
            else if (strRef.StartsWith("../"))//相对路径转换为绝对路径
            {
                int i = current.LastIndexOf("/");
                string str = current.Substring(0, i);
                return str + strRef.Substring(2);
            }
            else if (strRef.StartsWith("http"))
            {
                return strRef;
            }
            else
            {
                return current + "/" + strRef;
            }
        }
        
    }
}
