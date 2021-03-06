/*
This file is part of the iText (R) project.
Copyright (c) 1998-2020 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using iText.Html2pdf;
using iText.Test.Attributes;

namespace iText.Html2pdf.Css {
    public class TextDecorationTest : ExtendedHtmlConversionITextTest {
        public static readonly String sourceFolder = iText.Test.TestUtil.GetParentProjectDirectory(NUnit.Framework.TestContext
            .CurrentContext.TestDirectory) + "/resources/itext/html2pdf/css/TextDecorationTest/";

        public static readonly String destinationFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/html2pdf/css/TextDecorationTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            CreateDestinationFolder(destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecoration01Test() {
            ConvertToPdfAndCompare("textDecorationTest01", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecoration02Test() {
            ConvertToPdfAndCompare("textDecorationTest02", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecoration03Test() {
            ConvertToPdfAndCompare("textDecorationTest03", sourceFolder, destinationFolder);
        }

        //Text decoration property is in defaults.css for a[href], should be replaced by css.
        [NUnit.Framework.Test]
        public virtual void TextDecoration04Test() {
            ConvertToPdfAndCompare("textDecorationTest04", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecoration05Test() {
            // TODO DEVSIX-2532
            ConvertToPdfAndCompare("textDecorationTest05", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationShorthandAllValuesTest() {
            // TODO DEVSIX-3933
            ConvertToPdfAndCompare("textDecorationShorthandAllValues", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationShorthandOneValueTest() {
            // TODO DEVSIX-3933
            ConvertToPdfAndCompare("textDecorationShorthandOneValue", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationShorthandTwoValuesTest() {
            // TODO DEVSIX-3933
            ConvertToPdfAndCompare("textDecorationShorthandTwoValues", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationWithChildElementTest() {
            ConvertToPdfAndCompare("textDecorationWithChildElement", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        //TODO: DEVSIX-3933
        [LogMessage(iText.Html2pdf.LogMessageConstant.HSL_COLOR_NOT_SUPPORTED)]
        public virtual void TextDecorationColorTest() {
            ConvertToPdfAndCompare("textDecorationColor", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationColorWithTransparencyTest() {
            ConvertToPdfAndCompare("textDecorationColorWithTransparency", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationLineTest() {
            //TODO: DEVSIX-3933
            ConvertToPdfAndCompare("textDecorationLine", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationLineNoneAndUnderlineTogetherTest() {
            ConvertToPdfAndCompare("textDecorationLineNoneAndUnderlineTogether", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void TextDecorationStyleTest() {
            //TODO: DEVSIX-3933
            ConvertToPdfAndCompare("textDecorationStyle", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void ShorthandAndSpecificTextDecorPropsTest() {
            //TODO: DEVSIX-3933
            ConvertToPdfAndCompare("shorthandAndSpecificTextDecorProps", sourceFolder, destinationFolder);
        }

        [NUnit.Framework.Test]
        public virtual void CombinationOfLinesInTextDecorationTest() {
            //TODO: DEVSIX-3933
            ConvertToPdfAndCompare("combinationOfLinesInTextDecoration", sourceFolder, destinationFolder);
        }
    }
}
