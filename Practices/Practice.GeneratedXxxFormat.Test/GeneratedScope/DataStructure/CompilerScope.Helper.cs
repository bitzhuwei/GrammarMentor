using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.ScopeFormat {
    public partial class CompilerScope {
        /// <summary>
        /// appearance to content in [xxx] or [^xxx]
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static char ToContent(string item) {
            char c;
            if (item.Length == 6) { // \uNNNN
                //int id = int.Parse(item.Substring(2), System.Globalization.NumberStyles.HexNumber);
                int id = Convert.ToInt32(item.Substring(2), 16);
                c = (char)id;
            }
            else if (item.Length == 2 && item[0] == '\\') { // \x
                switch (item[1]) {
                case '[': c = '['; break;
                case '\\': c = '\\'; break;
                case ']': c = ']'; break;
                case '^': c = '^'; break;
                case 'a': c = '\a'; break;
                case 'b': c = '\b'; break;
                //case 'c': c = '\c'; break;
                //case 'e': c = '\e'; break;
                case 'f': c = '\f'; break;
                case 'n': c = '\n'; break;
                case 'r': c = '\r'; break;
                case 't': c = '\t'; break;
                case 'v': c = '\v'; break;
                //case 'z': c = '\z'; break;
                default:
                throw new NotImplementedException();
                //break;
                }
            }
            else if (item.Length == 1) {
                c = item[0];
            }
            else {
                throw new NotImplementedException();
            }

            return c;
        }

        /// <summary>
        /// content to appearance in [xxx] or [^xxx]
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string ToAppearance(char c) {
            string result;
            switch (c) {
            case '[': result = @"\["; break;
            case '\\': result = @"\\"; break;
            case ']': result = @"\]"; break;
            case '^': result = @"\^"; break;
            case '\a': result = @"\a"; break;
            case '\b': result = @"\b"; break;
            //case '\c': result = @"\c"; break;
            //case '\e': result = @"\e"; break;
            case '\f': result = @"\f"; break;
            case '\n': result = @"\n"; break;
            case '\r': result = @"\r"; break;
            case '\t': result = @"\t"; break;
            case '\v': result = @"\v"; break;
            //case '\z': result = @"\z"; break;
            default:
            if (' ' <= c && c <= '~') { result = c.ToString(); }
            else { result = string.Format(@"\u{0:X4}", (int)c); }
            break;
            }
            return result;
        }
    }
}