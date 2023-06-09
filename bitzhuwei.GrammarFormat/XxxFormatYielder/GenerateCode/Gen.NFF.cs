﻿using bitzhuwei.Compiler;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateFIRSTFOLLOW(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            var nullable = GetNullableList(context.nff.nullableDict);
            var firstList = GetFIRSTList(context.nff.firstDict);
            var followList = GetFOLLOWList(context.nff.followDict);
            {
                string template = File.ReadAllText(templateNFF);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strnullable, nullable);
                template = template.Replace(strFirstList, firstList);
                template = template.Replace(strFollowList, followList);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"Nullable-FIRST-FOLLOW.gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
        }
    }
}