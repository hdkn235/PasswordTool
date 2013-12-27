using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;
using System.IO;

namespace DAL
{
    public class XMLOperation : Operation
    {
        protected XmlDocument doc = new XmlDocument();

        public override void Insert()
        {
            try
            {
                doc.Load(path);
                XmlElement parentInfo = doc.DocumentElement;
                XmlElement info = doc.CreateElement("info");
                info.InnerXml = string.Format("<id>{0}</id><key>{1}</key><name>{2}</name><pw>{3}</pw><type>{4}</type>", userInfo.ID, userInfo.Key, userInfo.Name, userInfo.Pw, userInfo.Type);
                parentInfo.AppendChild(info);
                doc.Save("DataFile.xml");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override void Update()
        {
            try
            {
                doc.Load(path);

                XmlNodeList nodeList = doc.SelectSingleNode("UserInfos").ChildNodes;
                foreach (XmlNode node in nodeList)
                {
                    bool flag = false;
                    XmlElement xe = (XmlElement)node;
                    XmlNodeList nls = xe.ChildNodes;
                    foreach (XmlNode nd in nls)
                    {
                        XmlElement xx = (XmlElement)nd;
                        if (xx.Name == "id")
                        {
                            if (xx.InnerXml == userInfo.ID.ToString())
                            {
                                flag = true;
                                foreach (XmlNode n in nls)
                                {
                                    XmlElement x = (XmlElement)n;
                                    if (x.Name == "id") x.InnerXml = userInfo.ID.ToString();
                                    if (x.Name == "key") x.InnerXml = userInfo.Key;
                                    if (x.Name == "name") x.InnerXml = userInfo.Name;
                                    if (x.Name == "pw") x.InnerXml = userInfo.Pw;
                                    if (x.Name == "type") x.InnerXml = userInfo.Type;
                                }
                            }
                        }


                    }
                    if (flag) break;

                }
                doc.Save(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override void Search()
        {
            throw new NotImplementedException();
        }

        public override void Del()
        {
            try
            {
                doc.Load(path);
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodeList = doc.SelectSingleNode("UserInfos").ChildNodes;
                foreach (XmlNode node in nodeList)
                {
                    XmlElement xe = (XmlElement)node;
                    XmlNodeList nls = xe.ChildNodes;
                    foreach (XmlNode nd in nls)
                    {
                        XmlElement xx = (XmlElement)nd;
                        if (xx.Name == "id")
                        {
                            if (xx.InnerXml == userInfo.ID.ToString())
                            {
                                //移除子节点
                                root.RemoveChild(node);
                            }
                        }


                    }
                }
                doc.Save(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// 设置xml文档
        /// <summary>
        /// 设置xml文档
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="section"></param>
        /// <param name="keyName"></param>
        /// <param name="keyValue"></param>
        public static void ConfigueSet(string FileName, string section, string keyName, string keyValue)
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + FileName;
            XmlDocument doc = new XmlDocument();
            if (File.Exists(filename))
            {
                doc.Load(filename);
            }
            else
            {
                doc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?><root/>");
            }

            XmlNode sectionNode = doc.DocumentElement.SelectSingleNode(section);
            if (sectionNode == null)
            {
                sectionNode = doc.CreateNode(XmlNodeType.Element, section, "");
                doc.DocumentElement.AppendChild(sectionNode);
            }
            XmlNode keyNode = sectionNode.SelectSingleNode(keyName);
            if (keyNode == null)
            {
                keyNode = doc.CreateNode(XmlNodeType.Element, keyName, "");
                sectionNode.AppendChild(keyNode);
            }
            keyNode.InnerXml = keyValue;

            doc.Save(filename);
        }

        /// 读取xml文档
        /// <summary>
        /// 读取xml文档
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="section"></param>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string ConfigueGet(string FileName, string section, string keyName)
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + FileName;
            if (File.Exists(filename))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);
                XmlNode sectionNode = doc.DocumentElement.SelectSingleNode(section);
                if (sectionNode != null)
                {
                    XmlNode keyNode = sectionNode.SelectSingleNode(keyName);
                    if (keyNode != null)
                        return keyNode.InnerXml;
                    else
                        return "";
                }
                else
                    return "";
            }
            else
            {
                return "";
            }
        }

        /// 重载方法 获取xml文档 可设置属性名称
        /// <summary>
        /// 重载方法 获取xml文档 可设置属性名称
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="section"></param>
        /// <param name="keyName"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public static string ConfigueGet(string FileName, string section, string keyName, string attributeName)
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + FileName;
            if (File.Exists(filename))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);
                XmlNode sectionNode = doc.DocumentElement.SelectSingleNode(section);
                if (sectionNode != null)
                {
                    XmlNode keyNode = sectionNode.SelectSingleNode(keyName);
                    if ((keyNode != null) && (keyNode.Attributes[attributeName] != null))
                        return keyNode.Attributes[attributeName].Value;
                    else
                        return "";
                }
                else
                    return "";
            }
            else
            {
                return "";
            }
        }

        /// 重载方法 获取xml文档 可设置属性名称、值
        /// <summary>
        /// 重载方法 获取xml文档 可设置属性名称、值
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="section"></param>
        /// <param name="keyName"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        public static void ConfigueSet(string FileName, string section, string keyName, string attributeName, string attributeValue)
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + FileName;
            XmlDocument doc = new XmlDocument();
            if (File.Exists(filename))
            {
                doc.Load(filename);
            }
            else
            {
                doc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?><root/>");
            }

            XmlNode sectionNode = doc.DocumentElement.SelectSingleNode(section);
            if (sectionNode == null)
            {
                sectionNode = doc.CreateNode(XmlNodeType.Element, section, "");
                doc.DocumentElement.AppendChild(sectionNode);
            }
            XmlNode keyNode = sectionNode.SelectSingleNode(keyName);
            if (keyNode == null)
            {
                keyNode = doc.CreateNode(XmlNodeType.Element, keyName, "");
                sectionNode.AppendChild(keyNode);
            }
            if (keyNode.Attributes[attributeName] == null)
            {
                XmlAttribute attribute = doc.CreateAttribute(attributeName);
                keyNode.Attributes.Append(attribute);
            }
            keyNode.Attributes[attributeName].Value = attributeValue;

            doc.Save(filename);
        }

        /// 将dataset写成xml文件
        /// <summary>
        /// 将dataset写成xml文件
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static bool WriteDataSetToXml(string FileName, DataSet ds)
        {
            if (ds != null)
            {
                ds.WriteXml(FileName);
                return true;
            }
            else return false;
        }

        /// 将xml转化成dataset
        /// <summary>
        /// 将xml转化成dataset
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static bool ReadXmltoDataSet(string FileName, ref DataSet ds)
        {
            ds = new DataSet();
            ds.ReadXml(FileName);
            if (ds != null) return true;
            else return false;
        }

        /// 获取xml中所有信息，并返回dataset
        /// <summary>
        /// 获取xml中所有信息，并返回dataset
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllInfo(string path)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds;
        }

        public XMLOperation()
        {
            XmlDocument doc = new XmlDocument();
            if (!File.Exists(path))
            {
                this.CreateXml();
            }
        }

        protected bool CreateXml()
        {
            try
            {
                XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(xmlDec);
                XmlElement parent = doc.CreateElement("UserInfos");
                doc.AppendChild(parent);
                doc.Save(path);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
