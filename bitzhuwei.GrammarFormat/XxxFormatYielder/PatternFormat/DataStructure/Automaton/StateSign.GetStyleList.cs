using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {

    partial class StateSign {

        private List<string> GetStyleList() {
            var list = new List<string>(4);
            if (isBegin) { list.Add("stroke:#333,stroke-width:4px"); }
            if (isEnd) { list.Add("fill:#BB66EE"); } // birthday of my son
            if (isCheck) { list.Add("stroke-dasharray: 10 10"); }
            if (isAccept) { list.Add("color:#FF0000"); }

            return list;
        }
    }
}