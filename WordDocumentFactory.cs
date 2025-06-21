public class WordDocumentFactory : DocumentFactory
{
    public override Document CreateDocument()
    {
        return new WordDocument();
    }
}
