using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        /// <summary>
        /// regulations that consist of grammar for this compiler.
        /// </summary>
        public static readonly Regulation[] regulations = new Regulation[] {
            // 0: <SeparatorStart> ::= "Separator" "{" <PropertyGroupList> "}" ;
            new Regulation(EType.SeparatorStart, EType.Separator, EType.LeftBrace, EType.PropertyGroupList, EType.RightBrace),
            // 1: <PropertyGroupList> ::= <PropertyGroupList> <PropertyGroup> ;
            new Regulation(EType.PropertyGroupList, EType.PropertyGroupList, EType.PropertyGroup),
            // 2: <PropertyGroupList> ::= <PropertyGroup> ;
            new Regulation(EType.PropertyGroupList, EType.PropertyGroup),
            // 3: <PropertyGroup> ::= <GroupName> "{" <PropertyList> "}" ;
            new Regulation(EType.PropertyGroup, EType.GroupName, EType.LeftBrace, EType.PropertyList, EType.RightBrace),
            // 4: <GroupName> ::= "identifier" ;
            new Regulation(EType.GroupName, EType.identifier),
            // 5: <PropertyList> ::= <PropertyList> <Property> ;
            new Regulation(EType.PropertyList, EType.PropertyList, EType.Property),
            // 6: <PropertyList> ::= <Property> ;
            new Regulation(EType.PropertyList, EType.Property),
            // 7: <Property> ::= "identifier" "identifier" ;
            new Regulation(EType.Property, EType.identifier, EType.identifier),
            // 8: <Property> ::= "ambientColor" "[" "Float" "Float" "Float" "]" ;
            new Regulation(EType.Property, EType.ambientColor, EType.LeftBracket, EType.Float, EType.Float, EType.Float, EType.RightBracket),
            // 9: <Property> ::= "diffuseColor" "[" "Float" "Float" "Float" "]" ;
            new Regulation(EType.Property, EType.diffuseColor, EType.LeftBracket, EType.Float, EType.Float, EType.Float, EType.RightBracket),
            // 10: <Property> ::= "emissiveColor" "[" "Float" "Float" "Float" "]" ;
            new Regulation(EType.Property, EType.emissiveColor, EType.LeftBracket, EType.Float, EType.Float, EType.Float, EType.RightBracket),
            // 11: <Property> ::= "specularColor" "[" "Float" "Float" "Float" "]" ;
            new Regulation(EType.Property, EType.specularColor, EType.LeftBracket, EType.Float, EType.Float, EType.Float, EType.RightBracket),
            // 12: <Property> ::= "shininess" "[" "Float" "]" ;
            new Regulation(EType.Property, EType.shininess, EType.LeftBracket, EType.Float, EType.RightBracket),
            // 13: <Property> ::= "transparency" "[" "Float" "]" ;
            new Regulation(EType.Property, EType.transparency, EType.LeftBracket, EType.Float, EType.RightBracket),
            // 14: <Property> ::= "point" "[" <PointList> "]" ;
            new Regulation(EType.Property, EType.point, EType.LeftBracket, EType.PointList, EType.RightBracket),
            // 15: <Property> ::= "coordIndex" "[" <CoordIndexList> "]" ;
            new Regulation(EType.Property, EType.coordIndex, EType.LeftBracket, EType.CoordIndexList, EType.RightBracket),
            // 16: <PointList> ::= <PointList> "," <Point> ;
            new Regulation(EType.PointList, EType.PointList, EType.Comma, EType.Point),
            // 17: <PointList> ::= <Point> ;
            new Regulation(EType.PointList, EType.Point),
            // 18: <Point> ::= "Float" "Float" "Float" ;
            new Regulation(EType.Point, EType.Float, EType.Float, EType.Float),
            // 19: <CoordIndexList> ::= <CoordIndexList> "," <CoordIndex> ;
            new Regulation(EType.CoordIndexList, EType.CoordIndexList, EType.Comma, EType.CoordIndex),
            // 20: <CoordIndexList> ::= <CoordIndex> ;
            new Regulation(EType.CoordIndexList, EType.CoordIndex),
            // 21: <CoordIndex> ::= "Integer" ;
            new Regulation(EType.CoordIndex, EType.Integer),
        };
    }
}
