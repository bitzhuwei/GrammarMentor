using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.PatternFormat {
    public partial class CompilerPattern {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{TokenDraft}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<TokenDraft>>> someTokenExtracterDict = new Dictionary<string, Action<Node, TContext<TokenDraft>>>();

        private static readonly Action<Node, TContext<TokenDraft>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeSomeTokenExtracterDict() {
            var extracterDict = someTokenExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, context) => {
            // nothing to do.
            //});
            //extracterDict.Add(EType.MultipleLineComment,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, context) => {
            // not needed.
            //});
            extracterDict.Add(EType.refVt, VtHandler);
            //extracterDict.Add(EType.Slash, VtHandler);
            //extracterDict.Add(EType.Pipe, VtHandler);
            extracterDict.Add(EType.char_, VtHandler);
            extracterDict.Add(EType.Dot, VtHandler);
            extracterDict.Add(EType.scope, VtHandler);
            //extracterDict.Add(EType.LeftParenthesis, VtHandler);
            //extracterDict.Add(EType.RightParenthesis, VtHandler);
            //extracterDict.Add(EType.Question, VtHandler);
            //extracterDict.Add(EType.Plus, VtHandler);
            //extracterDict.Add(EType.Asterisk, VtHandler);
            //extracterDict.Add(EType.LeftBrace, VtHandler);
            extracterDict.Add(EType.min, VtHandler);
            //extracterDict.Add(EType.RightBrace, VtHandler);
            //extracterDict.Add(EType.Comma, VtHandler);
            extracterDict.Add(EType.max, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: SomeToken> : Pattern ;
                var pattern = context.objStack.Pop() as Pattern;
                var regexInfo = new eNFAInfo(pattern.regex.start, pattern.regex.end);
                var postInfo = new eNFAInfo(pattern.postRegex.start, pattern.postRegex.end);
                var tokenDraft = new TokenDraft(pattern.preVt, regexInfo, postInfo);
                postInfo.end.isEnd = true;
                context.result = tokenDraft; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Pattern,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[0]) {
                    // 0: Pattern : PreRegex Regex PostRegex ;
                    var postRegex = context.objStack.Pop() as eNFAFragment;
                    var regex = context.objStack.Pop() as eNFAFragment;
                    var preVt = context.objStack.Pop() as string;
                    var pattern = new Pattern(preVt, regex, postRegex);
                    context.objStack.Push(pattern);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PreRegex,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[1]) {
                    // 1: PreRegex : 'refVt' ;
                    // no diff if no bug.
                    var refVt0 = context.objStack.Pop() as string;
                    var preVt = refVt0.Substring(1, refVt0.Length - "<>".Length);
                    context.objStack.Push(preVt);
                }
                else if (node.regulation == CompilerPattern.regulations[2]) {
                    // 2: PreRegex : ;
                    context.objStack.Push(CompilerPattern.defaultPreVt);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PostRegex,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[3]) {
                    // 3: PostRegex : '/' Regex ;
                    var regex = context.objStack.Pop() as eNFAFragment;
                    context.objStack.Push(regex);
                }
                else if (node.regulation == CompilerPattern.regulations[4]) {
                    // 4: PostRegex : ;
                    if (!context.tagDict.TryGetValue(nameof(eNFAStateDraft), out var value)) {
                        value = new DraftContext();
                        context.tagDict.Add(nameof(eNFAStateDraft), value);
                    }
                    var draftContext = value as DraftContext;

                    var start = new eNFAStateDraft(draftContext.NextId(), "post-regex start");
                    var end = new eNFAStateDraft(draftContext.NextId(), "post-regex end");
                    var edge = eNFAEdgeDraft.Connect(start, end);
                    var regex = new eNFAFragment(start, end);
                    context.objStack.Push(regex);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Regex,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[5]) {
                    // 5: Regex : Regex '|' Bunch ;
                    var bunch = context.objStack.Pop() as eNFAFragment;
                    var regex = context.objStack.Pop() as eNFAFragment;
                    var edge1 = eNFAEdgeDraft.Connect(regex.start, bunch.start);
                    var edge2 = eNFAEdgeDraft.Connect(bunch.end, regex.end);
                    context.objStack.Push(regex);
                }
                else if (node.regulation == CompilerPattern.regulations[6]) {
                    // 6: Regex : Bunch ;
                    if (!context.tagDict.TryGetValue(nameof(eNFAStateDraft), out var value)) {
                        value = new DraftContext();
                        context.tagDict.Add(nameof(eNFAStateDraft), value);
                    }
                    var draftContext = value as DraftContext;
                    var bunch = context.objStack.Pop() as eNFAFragment;
                    var start = new eNFAStateDraft(draftContext.NextId(), "regex start");
                    var end = new eNFAStateDraft(draftContext.NextId(), "regex end");
                    var edge1 = eNFAEdgeDraft.Connect(start, bunch.start);
                    var edge2 = eNFAEdgeDraft.Connect(bunch.end, end);
                    var regex = new eNFAFragment(start, end);
                    context.objStack.Push(regex);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Bunch,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[7]) {
                    // 7: Bunch : Bunch Unit ;
                    var unit = context.objStack.Pop() as eNFAFragment;
                    var bunch = context.objStack.Pop() as eNFAFragment;
                    var edge = eNFAEdgeDraft.Connect(bunch.end, unit.start);// connect bunch & unit
                    var bunch2 = new eNFAFragment(bunch.start, unit.end);
                    context.objStack.Push(bunch2);
                }
                else if (node.regulation == CompilerPattern.regulations[8]) {
                    // 8: Bunch : Unit ;
                    var unit = context.objStack.Pop() as eNFAFragment;
                    var bunch = unit;
                    context.objStack.Push(bunch);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Unit,
            (node, context) => {
                if (!context.tagDict.TryGetValue(nameof(eNFAStateDraft), out var value)) {
                    value = new DraftContext();
                    context.tagDict.Add(nameof(eNFAStateDraft), value);
                }
                var draftContext = value as DraftContext;
                // when this function is done,
                // Unit's end state is at top of context.objStack,
                // and Unit's start state is next to it.
                if (node.regulation == CompilerPattern.regulations[9]) {
                    // 9: Unit : 'char' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var char_1 = context.objStack.Pop() as string;
                    var char0 = char_1[0];// somewhere I used char.ToString(), so here comes string[0]
                    var condition = char_1;
                    var count = repeat0.max + 1;
                    if (count <= 0) { count = repeat0.min + 1; }
                    var stateList = new eNFAStateDraft[count];
                    { stateList[0] = new eNFAStateDraft(draftContext.NextId(), $"char{repeat0.ToBound()}"); }
                    for (int i = 1; i < count; i++) {
                        stateList[i] = new eNFAStateDraft(draftContext.NextId(), $"char[{i}]");
                        var edge = eNFAEdgeDraft.Connect(stateList[i - 1], stateList[i], condition);
                    }
                    for (int i = repeat0.min; i < count - 1; i++) {
                        var edge = eNFAEdgeDraft.Connect(stateList[i], stateList[count - 1]);
                    }
                    if (repeat0.max < 0) {
                        var edge = eNFAEdgeDraft.Connect(stateList[count - 1], stateList[count - 1], condition);
                    }
                    var unit = new eNFAFragment(start: stateList[0], end: stateList[count - 1]);
                    context.objStack.Push(unit);
                }
                else if (node.regulation == CompilerPattern.regulations[10]) {
                    // 10: Unit : '.' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var dot1 = context.objStack.Pop() as string;
                    var condition = @"[\t\r -~]"; // anything except \n
                    var count = repeat0.max + 1;
                    if (count <= 0) { count = repeat0.min + 1; }
                    var stateList = new eNFAStateDraft[count];
                    { stateList[0] = new eNFAStateDraft(draftContext.NextId(), $"char{repeat0.ToBound()}"); }
                    for (int i = 1; i < count; i++) {
                        stateList[i] = new eNFAStateDraft(draftContext.NextId(), $"char[{i}]");
                        var edge = eNFAEdgeDraft.Connect(stateList[i - 1], stateList[i], condition);
                    }
                    for (int i = repeat0.min; i < count - 1; i++) {
                        var edge = eNFAEdgeDraft.Connect(stateList[i], stateList[count - 1]);
                    }
                    if (repeat0.max < 0) {
                        var edge = eNFAEdgeDraft.Connect(stateList[count - 1], stateList[count - 1], condition);
                    }
                    var unit = new eNFAFragment(start: stateList[0], end: stateList[count - 1]);
                    context.objStack.Push(unit);
                }
                else if (node.regulation == CompilerPattern.regulations[11]) {
                    // 11: Unit : 'scope' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var scope1 = context.objStack.Pop() as string;
                    var condition = scope1;
                    var count = repeat0.max + 1;
                    if (count <= 0) { count = repeat0.min + 1; }
                    var stateList = new eNFAStateDraft[count];
                    { stateList[0] = new eNFAStateDraft(draftContext.NextId(), $"scope{repeat0.ToBound()}"); }
                    for (int i = 1; i < count; i++) {
                        stateList[i] = new eNFAStateDraft(draftContext.NextId(), $"scope[{i}]");
                        var edge = eNFAEdgeDraft.Connect(stateList[i - 1], stateList[i], condition);
                    }
                    for (int i = repeat0.min; i < count - 1; i++) {
                        var edge = eNFAEdgeDraft.Connect(stateList[i], stateList[count - 1]);
                    }
                    if (repeat0.max < 0) {
                        var edge = eNFAEdgeDraft.Connect(stateList[count - 1], stateList[count - 1], condition);
                    }
                    var unit = new eNFAFragment(start: stateList[0], end: stateList[count - 1]);
                    context.objStack.Push(unit);
                }
                else if (node.regulation == CompilerPattern.regulations[12]) {
                    // 12: Unit : '(' Regex ')' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var regex = context.objStack.Pop() as eNFAFragment;
                    var count = repeat0.max + 1;
                    if (count <= 0) { count = repeat0.min + 1; }
                    var subRegexDrafts = new eNFAFragment[count];
                    var firstSub = regex;// new SubRegexDraft(regexStart, regexEnd);
                    subRegexDrafts[0] = firstSub;
                    for (int i = 1; i < count; i++) {
                        subRegexDrafts[i] = firstSub.Copy();
                        var edge = eNFAEdgeDraft.Connect(subRegexDrafts[i - 1].end, subRegexDrafts[i].start);
                    }
                    for (int i = repeat0.min; i < count; i++) {
                        var edge = eNFAEdgeDraft.Connect(subRegexDrafts[i].start, subRegexDrafts[count - 1].end);
                    }
                    if (repeat0.max < 0) {
                        var edge = eNFAEdgeDraft.Connect(subRegexDrafts[count - 1].end, subRegexDrafts[count - 1].start);
                    }
                    var unit = new eNFAFragment(start: subRegexDrafts[0].start, end: subRegexDrafts[count - 1].end);
                    context.objStack.Push(unit);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Repeat,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[13]) {
                    // 13: Repeat : '?' ;
                    var repeat = new Repeat(ERepeat.ZeroOne);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[14]) {
                    // 14: Repeat : '+' ;
                    var repeat = new Repeat(ERepeat.OneMore);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[15]) {
                    // 15: Repeat : '*' ;
                    var repeat = new Repeat(ERepeat.ZeroMore);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[16]) {
                    // 16: Repeat : '{' 'min' UpperBound '}' ;
                    var upperBound = context.objStack.Pop() as string;
                    var lowerBound = context.objStack.Pop() as string;
                    var min = int.Parse(lowerBound);
                    int max;
                    if (upperBound == Repeat.infiniteString) { max = Repeat.infinite; }
                    else if (upperBound == Repeat.omissiveString) { max = min; }
                    else { max = int.Parse(upperBound); }
                    var repeat = new Repeat(min, max);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[17]) {
                    // 17: Repeat : ;
                    var repeat = new Repeat(ERepeat.One);
                    context.objStack.Push(repeat);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.UpperBound,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[18]) {
                    // 18: UpperBound : ',' 'max' ;
                    var max0 = context.objStack.Pop() as string;
                    context.objStack.Push(max0);
                }
                else if (node.regulation == CompilerPattern.regulations[19]) {
                    // 19: UpperBound : ',' ;
                    var max = Repeat.infiniteString;
                    context.objStack.Push(max);
                }
                else if (node.regulation == CompilerPattern.regulations[20]) {
                    // 20: UpperBound : ;
                    var max = Repeat.omissiveString;
                    context.objStack.Push(max);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}