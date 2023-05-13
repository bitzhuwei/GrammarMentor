using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {

    partial class StateSign {
        public bool isBegin;
        public bool isEnd;
        public bool isCheck;
        public bool isAccept;

        private StateSign(bool isBegin, bool isEnd, bool isCheck, bool isAccept) {
            this.isBegin = isBegin;
            this.isEnd = isEnd;
            this.isCheck = isCheck;
            this.isAccept = isAccept;
        }

        public override string ToString() {
            return $"{isBegin}, {isEnd}, {isCheck}, {isAccept}";
            //return $"{isBegin}, {isEnd}, {isAccept}";
        }

        private static Dictionary<StateSign, string> sign2NameDict = new Dictionary<StateSign, string>();
        static StateSign() {
            //sign2NameDict.Add(new StateSign(false, false, false, false), "c0000");
            sign2NameDict.Add(new StateSign(false, false, false, true), "c0001");
            sign2NameDict.Add(new StateSign(false, false, true, false), "c0010");
            sign2NameDict.Add(new StateSign(false, false, true, true), "c0011");
            sign2NameDict.Add(new StateSign(false, true, false, false), "c0100");
            sign2NameDict.Add(new StateSign(false, true, false, true), "c0101");
            sign2NameDict.Add(new StateSign(false, true, true, false), "c0110");
            sign2NameDict.Add(new StateSign(false, true, true, true), "c0111");
            sign2NameDict.Add(new StateSign(true, false, false, false), "c1000");
            sign2NameDict.Add(new StateSign(true, false, false, true), "c1001");
            sign2NameDict.Add(new StateSign(true, false, true, false), "c1010");
            sign2NameDict.Add(new StateSign(true, false, true, true), "c1011");
            sign2NameDict.Add(new StateSign(true, true, false, false), "c1100");
            sign2NameDict.Add(new StateSign(true, true, false, true), "c1101");
            sign2NameDict.Add(new StateSign(true, true, true, false), "c1110");
            sign2NameDict.Add(new StateSign(true, true, true, true), "c1111");
        }

        public void Print(TextWriter w, eNFAStateDraft state, EStateSignPrint printType) {
            switch (printType) {
            case EStateSignPrint.Class: PrintClass(w, state); break;
            case EStateSignPrint.Style: PrintStyle(w, state); break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }

        public void Print(TextWriter w, NFAStateDraft state, EStateSignPrint printType) {
            switch (printType) {
            case EStateSignPrint.Class: PrintClass(w, state); break;
            case EStateSignPrint.Style: PrintStyle(w, state); break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }

        public void Print(TextWriter w, NFAStateDraft state, string id, EStateSignPrint printType) {
            switch (printType) {
            case EStateSignPrint.Class: PrintClass(w, state, id); break;
            case EStateSignPrint.Style: PrintStyle(w, state); break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }

        public void Print(TextWriter w, DFAStateDraft state, EStateSignPrint printType) {
            switch (printType) {
            case EStateSignPrint.Class: PrintClass(w, state); break;
            case EStateSignPrint.Style: PrintStyle(w, state); break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }

        public void Print(TextWriter w, DFAStateDraft state, string id, EStateSignPrint printType) {
            switch (printType) {
            case EStateSignPrint.Class: PrintClass(w, state, id); break;
            case EStateSignPrint.Style: PrintStyle(w, state); break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }

        public void Print(TextWriter w, MiniDFAStateDraft state, EStateSignPrint printType) {
            switch (printType) {
            case EStateSignPrint.Class: PrintClass(w, state); break;
            case EStateSignPrint.Style: PrintStyle(w, state); break;
            default:
            throw new NotImplementedException();
            //break;
            }
        }
    }

    public enum EStateSignPrint {
        Class,
        Style,
    }
}