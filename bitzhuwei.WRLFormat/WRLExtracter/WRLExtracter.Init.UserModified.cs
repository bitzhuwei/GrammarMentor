using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        class nothingTodo { }
        class ambientColor { public readonly string[] value = new string[3]; public ambientColor(string x, string y, string z) { this.value[0] = x; this.value[1] = y; this.value[2] = z; } }
        class diffuseColor { public readonly string[] value = new string[3]; public diffuseColor(string x, string y, string z) { this.value[0] = x; this.value[1] = y; this.value[2] = z; } }
        class emissiveColor { public readonly string[] value = new string[3]; public emissiveColor(string x, string y, string z) { this.value[0] = x; this.value[1] = y; this.value[2] = z; } }
        class specularColor { public readonly string[] value = new string[3]; public specularColor(string x, string y, string z) { this.value[0] = x; this.value[1] = y; this.value[2] = z; } }
        class shininess { public readonly string value; public shininess(string value) { this.value = value; } }
        class transparency { public readonly string value; public transparency(string value) { this.value = value; } }
        class point { public readonly List<string[]> value; public point(List<string[]> pointList) { this.value = pointList; } }
        class coordIndex { public readonly List<string> value; public coordIndex(List<string> coordIndexList) { this.value = coordIndexList; } }

        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, StepContext}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<WRLFile>>> wrlExtracterDict = new Dictionary<string, Action<Node, TContext<WRLFile>>>();

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeWRLFileExtracterDict()
        {
            var extracterDict = wrlExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, context) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, context) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.Separator,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.LeftBrace,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.RightBrace,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.LeftBracket,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.RightBracket,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.Comma,
            //(node, context) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.identifier,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.ambientColor,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.diffuseColor,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.emissiveColor,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.specularColor,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.shininess,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.transparency,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.point,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            //extracterDict.Add(EType.coordIndex,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            extracterDict.Add(EType.Integer,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Float,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) =>
            {
                var ambientColor = new float[3];
                var diffuseColor = new float[3];
                var emissiveColor = new float[3];
                var specularColor = new float[3];
                float shininess = 0;
                float transparency = 0;
                float[] points = new float[0];
                int[] coordIndexes = new int[0];
                object obj;
                obj = context.objStack.Pop(); var propertyGroupList = obj as List<List<object>>;
                foreach (var propertyGroup in propertyGroupList)
                {
                    foreach (var property in propertyGroup)
                    {
                        if (property is nothingTodo)
                        {
                            // nothing to do.
                        }
                        else if (property is ambientColor)
                        {
                            var p = property as ambientColor;
                            for (int i = 0; i < p.value.Length; i++)
                            {
                                ambientColor[i] = float.Parse(p.value[i]);
                            }
                        }
                        else if (property is diffuseColor)
                        {
                            var p = property as diffuseColor;
                            for (int i = 0; i < p.value.Length; i++)
                            {
                                diffuseColor[i] = float.Parse(p.value[i]);
                            }
                        }
                        else if (property is emissiveColor)
                        {
                            var p = property as emissiveColor;
                            for (int i = 0; i < p.value.Length; i++)
                            {
                                emissiveColor[i] = float.Parse(p.value[i]);
                            }
                        }
                        else if (property is specularColor)
                        {
                            var p = property as specularColor;
                            for (int i = 0; i < p.value.Length; i++)
                            {
                                specularColor[i] = float.Parse(p.value[i]);
                            }
                        }
                        else if (property is shininess)
                        {
                            var p = property as shininess;
                            shininess = float.Parse(p.value);
                        }
                        else if (property is transparency)
                        {
                            var p = property as transparency;
                            transparency = float.Parse(p.value);
                        }
                        else if (property is point)
                        {
                            var p = property as point;
                            var list = new List<float>();
                            foreach (var item in p.value)
                            {
                                foreach (var item2 in item)
                                {
                                    list.Add(float.Parse(item2));
                                }
                            }
                            points = list.ToArray();
                        }
                        else if (property is coordIndex)
                        {
                            var p = property as coordIndex;
                            var list = new List<int>();
                            foreach (var item in p.value)
                            {
                                list.Add(int.Parse(item));
                            }
                            coordIndexes = list.ToArray();
                        }
                        else { throw new NotImplementedException(); }
                    }
                }

                context.result = new WRLFile(ambientColor, diffuseColor, emissiveColor, specularColor,
                    shininess, transparency, points, coordIndexes);
            });
            extracterDict.Add(EType.Coding,
            (node, context) =>
            {
                throw new NotImplementedException();
            });
            extracterDict.Add(EType.SeparatorStart,
            (node, context) =>
            {
                if (node.regulation == regulations[0])
                {
                    // 0: <SeparatorStart> ::= "Separator" "{" <PropertyGroupList> "}" ;
                    // omissible pop/push.
                    //object obj;
                    //obj = context.objStack.Pop(); var propertyGroupList = obj as List<List<object>>;
                    //context.objStack.Push(propertyGroupList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PropertyGroupList,
            (node, context) =>
            {
                if (node.regulation == regulations[1])
                {
                    // 1: <PropertyGroupList> ::= <PropertyGroupList> <PropertyGroup> ;
                    object obj;
                    obj = context.objStack.Pop(); var propertyGroup = obj as List<object>;
                    obj = context.objStack.Pop(); var propertyGroupList = obj as List<List<object>>;
                    propertyGroupList.Add(propertyGroup);
                    context.objStack.Push(propertyGroupList);
                }
                else if (node.regulation == regulations[2])
                {
                    // 2: <PropertyGroupList> ::= <PropertyGroup> ; 
                    object obj;
                    obj = context.objStack.Pop(); var propertyGroup = obj as List<object>;
                    var propertyGroupList = new List<List<object>>(); propertyGroupList.Add(propertyGroup);
                    context.objStack.Push(propertyGroupList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PropertyGroup,
            (node, context) =>
            {
                if (node.regulation == regulations[3])
                {
                    // 3: <PropertyGroup> ::= <GroupName> "{" <PropertyList> "}" ;
                    // omissible pop/push.
                    //object obj;
                    //obj = context.objStack.Pop(); var propertyList = obj as List<object>;
                    //context.objStack.Push(propertyList);
                }
                else { throw new NotImplementedException(); }
            });
            //extracterDict.Add(EType.GroupName,
            //(node, context) =>
            //{
            //    // nothing to do.
            //});
            extracterDict.Add(EType.PropertyList,
            (node, context) =>
            {
                if (node.regulation == regulations[5])
                {
                    // 5: <PropertyList> ::= <PropertyList> <Property> ;
                    object obj;
                    obj = context.objStack.Pop(); var property = obj as object;
                    obj = context.objStack.Pop(); var propertyList = obj as List<object>;
                    propertyList.Add(property);
                    context.objStack.Push(propertyList);
                }
                else if (node.regulation == regulations[6])
                {
                    // 6: <PropertyList> ::= <Property> ;
                    object obj;
                    obj = context.objStack.Pop(); var property = obj as object;
                    var propertyList = new List<object>(); propertyList.Add(property);
                    context.objStack.Push(propertyList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Property,
            (node, context) =>
            {
                if (node.regulation == regulations[7])
                {
                    // 7: <Property> ::= "identifier" "identifier" ;
                    context.objStack.Push(new nothingTodo()); // keep the stack filled.
                }
                else if (node.regulation == regulations[8])
                {
                    // 8: <Property> ::= "ambientColor" "[" "Float" "Float" "Float" "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var z = obj as string;
                    obj = context.objStack.Pop(); var y = obj as string;
                    obj = context.objStack.Pop(); var x = obj as string;
                    var property = new ambientColor(x, y, z);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[9])
                {
                    // 9: <Property> ::= "diffuseColor" "[" "Float" "Float" "Float" "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var z = obj as string;
                    obj = context.objStack.Pop(); var y = obj as string;
                    obj = context.objStack.Pop(); var x = obj as string;
                    var property = new diffuseColor(x, y, z);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[10])
                {
                    // 10: <Property> ::= "emissiveColor" "[" "Float" "Float" "Float" "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var z = obj as string;
                    obj = context.objStack.Pop(); var y = obj as string;
                    obj = context.objStack.Pop(); var x = obj as string;
                    var property = new emissiveColor(x, y, z);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[11])
                {
                    // 11: <Property> ::= "specularColor" "[" "Float" "Float" "Float" "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var z = obj as string;
                    obj = context.objStack.Pop(); var y = obj as string;
                    obj = context.objStack.Pop(); var x = obj as string;
                    var property = new specularColor(x, y, z);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[12])
                {
                    // 12: <Property> ::= "shininess" "[" "Float" "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var v = obj as string;
                    var property = new shininess(v);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[13])
                {
                    // 13: <Property> ::= "transparency" "[" "Float" "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var v = obj as string;
                    var property = new transparency(v);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[14])
                {
                    // 14: <Property> ::= "point" "[" <PointList> "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var pointList = obj as List<string[]>;
                    var property = new point(pointList);
                    context.objStack.Push(property);
                }
                else if (node.regulation == regulations[15])
                {
                    // 15: <Property> ::= "coordIndex" "[" <CoordIndexList> "]" ;
                    object obj;
                    obj = context.objStack.Pop(); var coordIndexList = obj as List<string>;
                    var property = new coordIndex(coordIndexList);
                    context.objStack.Push(property);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PointList,
            (node, context) =>
            {
                if (node.regulation == regulations[16])
                {
                    // 16: <PointList> ::= <PointList> "," <Point> ;
                    object obj;
                    obj = context.objStack.Pop(); var point = obj as string[];
                    obj = context.objStack.Pop(); var pointList = obj as List<string[]>;
                    pointList.Add(point);
                    context.objStack.Push(pointList);
                }
                else if (node.regulation == regulations[17])
                {
                    // 17: <PointList> ::= <Point> ;
                    object obj;
                    obj = context.objStack.Pop(); var point = obj as string[];
                    var pointList = new List<string[]>();
                    pointList.Add(point);
                    context.objStack.Push(pointList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Point,
            (node, context) =>
            {
                if (node.regulation == regulations[18])
                {
                    // 18: <Point> ::= "Float" "Float" "Float" ;
                    object obj;
                    obj = context.objStack.Pop(); var z = obj as string;
                    obj = context.objStack.Pop(); var y = obj as string;
                    obj = context.objStack.Pop(); var x = obj as string;
                    var point = new string[] { x, y, z };
                    context.objStack.Push(point);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.CoordIndexList,
            (node, context) =>
            {
                if (node.regulation == regulations[19])
                {
                    // 19: <CoordIndexList> ::= <CoordIndexList> "," <CoordIndex> ;
                    object obj;
                    obj = context.objStack.Pop(); var coordIndex = obj as string;
                    obj = context.objStack.Pop(); var coordIndexList = obj as List<string>;
                    coordIndexList.Add(coordIndex);
                    context.objStack.Push(coordIndexList);
                }
                else if (node.regulation == regulations[20])
                {
                    // 20: <CoordIndexList> ::= <CoordIndex> ;
                    object obj;
                    obj = context.objStack.Pop(); var coordIndex = obj as string;
                    var coordIndexList = new List<string>();
                    coordIndexList.Add(coordIndex);
                    context.objStack.Push(coordIndexList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.CoordIndex,
            (node, context) =>
            {
                if (node.regulation == regulations[21])
                {
                    // 21: <CoordIndex> ::= "Integer" ;
                    // omissible pop/push.
                    //object obj;
                    //obj = context.objStack.Pop(); var integer = obj as string;
                    //context.objStack.Push(obj);
                }
                else { throw new NotImplementedException(); }
            });
        }
    }

}