public class ExcelDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new ExcelDocument();
    }
}
