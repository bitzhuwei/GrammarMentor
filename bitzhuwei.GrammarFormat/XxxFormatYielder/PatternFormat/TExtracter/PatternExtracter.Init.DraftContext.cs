using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;
using System.Configuration;

namespace bitzhuwei.PatternFormat {
    public partial class CompilerPattern {
        class DraftContext {
            /// <summary>
            /// N in lexicalStateN
            /// </summary>
            private int idCounter;

            public int NextId() {
                var id = this.idCounter++;
                return id;
            }

            public override string ToString() {
                return $"next id: {this.idCounter}";
            }

        }
    }
}