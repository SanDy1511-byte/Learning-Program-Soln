public class PdfDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new PdfDocument();
    }
}
