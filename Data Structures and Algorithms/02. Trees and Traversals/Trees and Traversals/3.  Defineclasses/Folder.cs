using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defineclasses
{
    class Folder
    {
        string name;
        public List<File> Files = new List<File>();
        public List<Folder> Folders = new List<Folder>();

        public Folder(string name)
        {
            this.name = name;
        }

        public long GetSize()
        {
            long size = 0;

            for (int i = 0; i < Files.Count; i++)
            {
                size += Files[i].Size;
            }

            for (int i = 0; i < Folders.Count; i++)
            {
               size += Folders[i].GetSize();
            }

            return size;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Files.Count; i++)
            {
                result.AppendLine(this.Files[i].Name);
            }

            for (int i = 0; i < this.Folders.Count; i++)
            {
                result.AppendLine(this.Folders[i].ToString());
            }

            return result.ToString();
        }
    }
}
