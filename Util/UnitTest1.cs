using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Util
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ParseItems()
        {
            var d = new DirectoryInfo(@"D:\DbItems");//Assuming Test is your Folder
            var files = d.GetFiles(); //Getting Text files

            var types = new List<string>();

            foreach (var file in files)
            {
                var doc = new XmlDocument();
                doc.Load(file.FullName);

                var items = doc.GetElementsByTagName("list")[0];
                foreach (XmlNode item in items.ChildNodes)
                {
                    if (item.Attributes?["type"] != null)
                    {
                        types.Add(item.Attributes["type"].Value);
                    }
                }
            }

            Console.WriteLine($"Total items: {types.Count}");
            foreach (var itemType in types.Distinct())
            {
                Console.WriteLine(itemType);
            }
        }

        [TestMethod]
        public void ParseCreeps()
        {
            var d = new DirectoryInfo(@"D:\MonsterDb");//Assuming Test is your Folder
            var files = d.GetFiles(); //Getting Text files

            var npcList = new List<Npc>();

            foreach (var file in files)
            {
                var doc = new XmlDocument();
                doc.Load(file.FullName);
      
                var npcs = doc.GetElementsByTagName("list")[0];
                foreach (XmlNode npc in npcs.ChildNodes)
                {
                    if (npc.Attributes?["level"] != null && npc.Attributes["name"] != null &&
                        npc.Attributes["type"] != null && npc.Attributes["type"].Value == "L2Monster")
                    {
                        var level = npc.Attributes["level"].Value;
                        var name = npc.Attributes["name"].Value;
                
                        npcList.Add(new Npc{Level = int.Parse(level), Name = name});

                        //.WriteLine($"lvl: {level} name: {name}");
                    }
                }
            }

            var orderedList = npcList.OrderBy(n => n.Level).ToList();
            Console.WriteLine($"Total npcs: {orderedList.Count}");
            foreach (var npc in orderedList)
            {
                Console.WriteLine($"lvl: {npc.Level} name: {npc.Name}");
            }
        }

        private class Npc
        {
            internal int Level { get; set; }
            internal string Name { get; set; }
        }
    }
}
