using System;
using iText.IO.Font.Woff2.W3c;

namespace iText.IO.Font.Woff2.W3c.Format {
    public class TabledataDecompressedLength001Test : W3CWoff2DecodeTest {
        protected internal override String GetFontName() {
            return "tabledata-decompressed-length-001";
        }

        protected internal override String GetTestInfo() {
            return "The original length of the first table in the directory is increased by 1, making the decompressed length of the table data less than the sum of original table lengths.";
        }

        protected internal override bool IsFontValid() {
            return false;
        }
    }
}