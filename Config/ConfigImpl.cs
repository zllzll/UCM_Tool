using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace UCM_Tools.Config
{
    /// <summary>
    /// 读取config.xml配置文件类
    /// </summary>
    public class ConfigImpl
    {
        //配置文件的名称
        private static string configFilePathAndName = "config.xml";
        //存储属性的MAP
        private static Dictionary<string, string> properties = new Dictionary<string, string>(0);
        //构造函数
        private ConfigImpl()
        {
        }
        //静态加载配置文件内容并赋值到属性MAP
        public static void loadConfig()
        {
            try
            {
                properties.Clear();
                //首先判断是否配置是否已经加载,如果没有加载，则完成加载动作
                if (properties != null)
                {
                    //创建XML文档对象
                    XmlDocument doc = new XmlDocument();
                    //获得配置文件的全路径字符串
                    string strFileName = AppDomain.CurrentDomain.BaseDirectory + "Config\\" + configFilePathAndName;
                    //加载配置文件内容
                    doc.Load(strFileName);
                    //找出名称为“argue”的所有元素
                    XmlNodeList nodes = doc.GetElementsByTagName("argue");
                    //循环把这些KEY和VALUE插入到MAP中
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        //获得当前元素的key属性和value属性
                        XmlAttribute key = nodes[i].Attributes["key"];
                        XmlAttribute value = nodes[i].Attributes["value"];
                        //插入到MAP中
                        properties.Add(key.InnerText, value.InnerText);
                    }
                }
            }
            catch (Exception _ex)
            {
                throw new Exception(_ex.Message);
            }
        }
        //获取对应名字属性的值
        public static string getConfigProperties(string propertiesName)
        {
            try
            {
                //直接返回
                return properties[propertiesName];
            }
            catch {
                return string.Empty;
            }
        }
        public static bool setConfigPropterties(string key, string value)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "Config\\" + configFilePathAndName);
                XmlNodeList nodeList = xmlDoc.GetElementsByTagName("argue");//获取所有子节点
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
                    if (xe.GetAttribute("key") == key)//如果key属性值为“key”
                    {
                        xe.SetAttribute("key", key);//则修改该属性为“newkey”
                        xe.SetAttribute("value", value);
                        properties.Remove(key);
                        properties.Add(key, value);
                        break;
                    }
                }
                xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + "Config\\" + configFilePathAndName);//保存。
                return true;
            }
            catch (Exception _ex)
            {
                throw new Exception(_ex.StackTrace);
            }
        }
    }
}
