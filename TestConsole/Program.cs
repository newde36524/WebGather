﻿using Newtonsoft.Json;
using System;
using WebGather.Video;
using WebGather.Video.Tension;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVideoGather();
            Console.WriteLine("==============================================");
            Console.ReadLine();
        }

        /// <summary>
        /// 测试视频链接爬虫
        /// </summary>
        public static void TestVideoGather()
        {
            IVideoGather videoGather = new TensionHtmlDocHandle();
            var result = videoGather.GetSearchResult("斗罗大陆");
            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}