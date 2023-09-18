namespace Homework_9_c_;

internal class ExpertDocument:ProDocumentProgram
{
    public void OpenDocument()
    {
        base.OpenDocument();
    }

    public void EditDocument()
    {
        base.EditDocument();
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in pdf format");
    }
}