using Homework9C;

namespace Homework_9_c_;

internal class ProDocumentProgram:DocumentProgram
{
    public void OpenDocument()
    {
        base.EditDocument();
    }
    public sealed override void EditDocument()
    {
        Console.WriteLine("Document Edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document Saved in Doc format, for pdf format buy Expert packed");
    }
}