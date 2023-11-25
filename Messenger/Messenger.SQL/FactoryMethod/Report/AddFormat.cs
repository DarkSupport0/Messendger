using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Report
{
    public abstract class AddFormat : ReportWriter
    {
        protected override string FileType { get; } = "txt";
    }
}
