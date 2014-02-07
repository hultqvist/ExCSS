using NUnit.Framework;
using System;
using System.IO;

namespace ExCSS.Tests
{
    [TestFixture]
    public class ArgumentFixture
    {
        [Test]
        public void Test_Whitespace_Sep_Arguments ()
        {
            string css = @"html{margin: 0 auto;}";
            Parser p = new Parser ();
            p.Parse (css);
        }

        [Test]
        public void Test_Hex_Arguments ()
        {
            string css = @"html{border: 1px solid #3D362D !important;}";
            Parser p = new Parser ();
            p.Parse (css);
        }

        [Test]
        public void Test_Nested_Functions ()
        {
            string css = @"html{background: -webkit-gradient(linear, left top, left bottom, color-stop(0.05, #7d5d3b), color-stop(1, #634b30));}";
            Parser p = new Parser ();
            p.Parse (css);
        }

        [Test]
        public void TestLocalCSS ()
        {
            string css = @"html{background:-moz-linear-gradient(top, #7d5d3b 5%, #634b30 100%);}";
            Parser p = new Parser ();
            p.Parse (css);
        }
    }
}

