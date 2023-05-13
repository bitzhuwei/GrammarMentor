using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {

    partial class StateSign {
        public static StateSign Parse(eNFAStateDraft state, eNFAInfo info) {
            bool isBegin = false, isEnd = false, isCheck = false, isAccept = false;
            foreach (var edge in state.toEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: /*isEnd = true;*/ break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: /*isAccept = true;*/ break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            foreach (var edge in state.fromEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: /*isBegin = true;*/ break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: /*isCheck = true;*/ break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            {
                if (info.stateTokenScriptDict.TryGetValue(state, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: isAccept = true; break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }

            return new StateSign(isBegin, isEnd, isCheck, isAccept);
        }


        public static StateSign Parse(NFAStateDraft state, NFAInfo info) {
            bool isBegin = false, isEnd = false, isCheck = false, isAccept = false;
            foreach (var edge in state.toEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: /*isEnd = true;*/ break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: /*isAccept = true;*/ break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            foreach (var edge in state.fromEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: /*isBegin = true;*/ break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: /*isCheck = true;*/ break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            {
                if (info.stateTokenScriptDict.TryGetValue(state, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: isAccept = true; break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }

            return new StateSign(isBegin, isEnd, isCheck, isAccept);
        }

        public static StateSign Parse(DFAStateDraft state, DFAInfo info) {
            bool isBegin = false, isEnd = false, isCheck = false, isAccept = false;
            foreach (var edge in state.toEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: /*isEnd = true;*/ break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: /*isAccept = true;*/ break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            foreach (var edge in state.fromEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: /*isBegin = true;*/ break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: /*isCheck = true;*/ break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            {
                if (info.stateTokenScriptDict.TryGetValue(state, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: isAccept = true; break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }

            return new StateSign(isBegin, isEnd, isCheck, isAccept);
        }

        public static StateSign Parse(MiniDFAStateDraft state, MiniDFAInfo info) {
            bool isBegin = false, isEnd = false, isCheck = false, isAccept = false;
            foreach (var edge in state.toEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: /*isEnd = true;*/ break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: /*isAccept = true;*/ break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            foreach (var edge in state.fromEdges) {
                if (info.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: /*isAccept = true;*/ break;
                        case ETokenScriptType.BeginToken: /*isBegin = true;*/ break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: /*isCheck = true;*/ break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }
            {
                if (info.stateTokenScriptDict.TryGetValue(state, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious: isAccept = true; break;
                        case ETokenScriptType.BeginToken: isBegin = true; break;
                        case ETokenScriptType.ExtendToken: isEnd = true; break;
                        case ETokenScriptType.CheckToken: isCheck = true; break;
                        case ETokenScriptType.AcceptToken: isAccept = true; break;
                        default: throw new NotImplementedException();
                        //break;
                        }
                    }
                }
            }

            return new StateSign(isBegin, isEnd, isCheck, isAccept);
        }
    }
}