using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Snake
{
    public abstract class GameObject
    {
        public List<Point> body { get; set; }
        public char sign { get; set; }
        public ConsoleColor color { get; set; }

        public GameObject()
        {
        }

        public GameObject(Point firstPoint, ConsoleColor color, char sign)
        {
            body = new List<Point>();
            if (firstPoint != null)
            {
                body.Add(firstPoint);
            }
            this.color = color;
            this.sign = sign;
        }

        public void Save()
        {
            Type t = GetType();
            string fname = t.Name + ".xml";
            StreamWriter sw = new StreamWriter(fname, false);
            using (sw)
            {
                XmlSerializer xs = new XmlSerializer(t);
                xs.Serialize(sw, this);
            }
            sw.Close();
        }

        public GameObject Load()
        {
            GameObject res;
            Type t = GetType();
            string fname = t.Name + ".xml";
            using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(t);
                res = xs.Deserialize(fs) as GameObject;
            }
            return res;
        }
    }
}
