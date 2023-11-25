using Messenger.SQL.Dtos;
using Messenger.SQL.FactoryMethod.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Messenger.SQL.FactoryMethod.Report
{
    public abstract class ReportWriter
    {
        protected readonly List<IFileParts> Parts = new();
        protected virtual string FileType { get; } = "";

        public void SaveToFile()
        {
            string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.{FileType}";
            Console.WriteLine(fileName);
            StreamWriter writer = new(fileName);
            foreach (var part in Parts)
            {
                writer.WriteLine(part.ConvertToString());
            }
            writer.Close();
        }

        public abstract void RenderFile(IData entity);
    }
}
