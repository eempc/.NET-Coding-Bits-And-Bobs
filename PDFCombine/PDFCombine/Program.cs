using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFCombine {
    class Program {
        static void Main(string[] args) {
            string file1 = @"D:\pdf1.pdf";
            string file2 = @"D:\pdf2.pdf";
            string savePath = @"D:\savefile.pdf";

            using (PdfDocument one = PdfReader.Open(file1, PdfDocumentOpenMode.Import))
            using (PdfDocument two = PdfReader.Open(file2, PdfDocumentOpenMode.Import))
            using (PdfDocument outPdf = new PdfDocument()) {
                CopyPages(one, outPdf);
                CopyPages(two, outPdf);
                outPdf.Save(savePath);
            }
        }

        public static void CopyPages(PdfDocument from, PdfDocument to) {
            for (int i = 0; i < from.PageCount; i++) {
                to.AddPage(from.Pages[i]);
            }
        }
    }
}
