using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    partial class TokenList {
        /// <summary>
        /// print the token list.
        /// </summary>
        /// <param name="writer"></param>
        public void Print(System.IO.TextWriter w) {
            {
                w.WriteLine($"{this.errorDict.Count} errors:");
                int index = 0;
                var query = from item in this.errorDict
                            orderby item.Key.index
                            select item;
                foreach (var item in query) {
                    w.WriteLine($"{index++}:[{item.Key}]={item.Value}");
                }
            }
            {
                var count = this.Count;
                w.WriteLine($"{count} tokens:");
                for (int i = 0; i < count; i++) {
                    w.WriteLine($"T[{i}]={this[i]}");
                }
            }
        }
    }
}
