namespace Template_Pattern
{
    class Program
    {
        static void Main()
        {
            DocumentProcessor pdf = new PdfProcessor();
            //DocumentProcessor word = new WordProcessor();
            //DocumentProcessor excel = new ExcelProcessor();

            pdf.ProcessDocument();
            //word.ProcessDocument();
            //excel.ProcessDocument();
        }
    }

}
