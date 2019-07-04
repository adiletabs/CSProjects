using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MiniFAR
{
    enum FarMode
    {
        Explorer,
        FileReader, 
        Rename
    }

    class FAR
    {
        Stack<Layer> layerHistory = new Stack<Layer>();
        Layer activeLayer;
        FarMode mode = FarMode.Explorer;

        public FAR(string path)
        {
            this.activeLayer = new Layer(path, 0);
        }

        public void Draw()
        {
            switch (mode)
            {
                case FarMode.Explorer:
                    DrawExplorer();
                    DrawStatusBar();
                    break;
                case FarMode.FileReader:
                    DrawFileReader();
                    DrawStatusBar();
                    break;
                case FarMode.Rename:
                    NewName();
                    break;
                default:
                    break;
            }
        }

        private void DrawStatusBar()
        {
            Console.SetCursorPosition(0, activeLayer.items.Count);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 38; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('|');
            Console.Write("Status Bar");
            for (int i = 0; i < 28; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine('|');
            for (int i = 0; i < 38; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('|');
            Console.Write("Mode: " + mode);
            if (mode == FarMode.Explorer)
            {
                for (int i = 0; i < 24; i++)
                {
                    Console.Write(' ');
                }
            }
            else
            {
                for (int i = 0; i < 22; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine('|');
            Console.Write("Number of Items: " + activeLayer.items.Count);
            if (activeLayer.items.Count < 10)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(' ');
                }
            }
            else
            {
                for (int i = 0; i < 19; i++)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine('|');
            for (int i = 0; i < 38; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine('|');
        }

        private void DrawFileReader()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(activeLayer.GetSelectedItemInfo(), FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());

            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open file!");

            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void DrawExplorer()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            for (int i = 0; i < activeLayer.items.Count; ++i)
            {
                if (i == activeLayer.index)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }

                if (activeLayer.items[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write(activeLayer.items[i].Name);
                for (int j = 1; j <= 38 - activeLayer.items[i].Name.Length; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine('|');
            }
        }

        public void NewName()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Write new name and press Enter: ");
            string newname = Console.ReadLine();
            //DirectoryInfo r = new DirectoryInfo();
            //r.MoveTo(Path +  newname);
        }

        public void Process(ConsoleKeyInfo pressedKey)
        {
            switch (pressedKey.Key)
            {
                case ConsoleKey.UpArrow:
                    activeLayer.Process(-1);
                    break;
                case ConsoleKey.DownArrow:
                    activeLayer.Process(1);
                    break;
                case ConsoleKey.Enter:
                    try
                    {
                        Console.Clear();
                        if (activeLayer.items[activeLayer.index].GetType() == typeof(DirectoryInfo))
                        {
                            mode = FarMode.Explorer;
                            layerHistory.Push(activeLayer);
                            activeLayer = new Layer(activeLayer.GetSelectedItemInfo(), 0);
                        }
                        else if (activeLayer.items[activeLayer.index].GetType() == typeof(FileInfo))
                        {
                            mode = FarMode.FileReader;
                        }
                        else if (mode == FarMode.Rename)
                        {
                            activeLayer = layerHistory.Pop();
                        }
                    }
                    catch (Exception e)
                    {
                        activeLayer = layerHistory.Pop();
                    }
                    break;
                case ConsoleKey.Backspace:
                    if (mode == FarMode.Explorer)
                    {
                        activeLayer = layerHistory.Pop();
                    }
                    else if (mode == FarMode.FileReader)
                    {
                        mode = FarMode.Explorer;
                    }
                    break;
                 case ConsoleKey.R:
                    activeLayer.items[activeLayer.index].Delete();
                    layerHistory.Push(activeLayer);
                    mode = FarMode.Rename;
                    break;
                default:
                    break;
            }

        }
    }
}
