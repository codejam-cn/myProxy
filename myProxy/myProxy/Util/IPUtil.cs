using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace myProxy.Util
{
    public class IpUtil
    {
        public static string[] GetIpList()
        {

            // 获取主机名
            var strHostName = Dns.GetHostName();
            // 根据主机名进行查找
            var iphostentry = Dns.GetHostEntry(strHostName);
            var retval = new string[iphostentry.AddressList.Length];
            var i = 0;
            foreach (var ipaddress in iphostentry.AddressList)
            {
                retval[i] = ipaddress.ToString();
                i++;
            }
            return retval;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipString"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentNaming
        public static bool isIPV4(string ipString)
        {
            Regex regex = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            return regex.IsMatch(ipString);
        }

    }
}