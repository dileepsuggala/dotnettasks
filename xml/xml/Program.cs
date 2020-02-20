using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //  xmlread();
            //  xmlfileaccess();
            //createxmldoc();
            //  createxmlwithlinq();
             readlinq();
          //  gettinghashandtype();

        }

        private static void gettinghashandtype()
        {
            Assembly inf = typeof(int).Assembly;
            Console.WriteLine(inf);
            int x = 10;
            Type t = x.GetType();
            Console.WriteLine(t);
            Console.WriteLine(x.GetTypeCode());
            Console.WriteLine(x.GetHashCode());
            StringBuilder std = new StringBuilder("hello");
            Console.WriteLine(std.GetType());
        }

        private static void readlinq()
        {
            StringBuilder result = new StringBuilder();
            XDocument xdoc = XDocument.Load(@"D:\DS\c#\xml\xml\XMLFile1.xml");
            var bks = from bk1 in xdoc.Descendants("book")
                      select new
                      {
                         Header = bk1.Attribute("Id").Value,
                        children = bk1.Descendants("Id"),
                          child1 = bk1.Descendants("Title"),
                          child2 = bk1.Descendants("Price")

                      };

            foreach (var bk in bks)
            {
                result.Append(bk.children);
               result.Append(bk.child1);
                result.Append(bk.child2);
            }
            Console.WriteLine(result);
        }

        private static void createxmlwithlinq()
        {
            XDocument doc = new XDocument(new XElement("Items", new XElement("Item", new XElement("ItemName", "cake"), new XElement("price", "250")),
                                                                new XElement("Item", new XElement("ItemName", "pastry"), new XElement("price", "200"))));

            doc.Save(Directory.GetCurrentDirectory() + "//xmlItem.xml");
            Console.WriteLine(doc);
        }

        private static void createxmldoc()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmldeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmldeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, "products", string.Empty);
            doc.AppendChild(element1);
            XmlElement element2 = doc.CreateElement(string.Empty, "product", string.Empty);
            XmlElement element3 = doc.CreateElement(string.Empty, "product", string.Empty);

            XmlText text1 = doc.CreateTextNode("laptop");
            element1.AppendChild(element2);
            element2.AppendChild(element3);
            element3.AppendChild(text1);

            XmlElement element4 = doc.CreateElement(string.Empty, "price", string.Empty);
            XmlText text2 = doc.CreateTextNode("45000");
            element4.AppendChild(text2);
            element2.AppendChild(element4);

            doc.Save(Directory.GetCurrentDirectory() + "//Product.xml");
        }

        private static void xmlfileaccess()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream(@"D:\DS\c#\xml\xml\XMLFile1.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("book");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + " " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + " " +
                      xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                Console.WriteLine(str);
            }
        }

        private static void xmlread()
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load(@"D:\DS\c#\xml\xml\XMLFile1.xml");
            XmlNode currentnode = xmld.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.OuterXml);
            XmlNode nextnode = currentnode.NextSibling;
            Console.WriteLine(nextnode.OuterXml);
            XmlNode node3 = nextnode.NextSibling;
            Console.WriteLine(node3.OuterXml);
        }
    }
}
