using Homework_9_c_;
using Homework9C;

while (true)
{
    Console.Write("Enter keyword: ");
    string keyword = Console.ReadLine();

    if (keyword == "basic")
    {
        DocumentProgram docProgram = new DocumentProgram();
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }

    else if (keyword == "pro")
    {
        DocumentProgram docProgram = new ProDocumentProgram();
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }

    else if (keyword == "expert")
    {
        DocumentProgram docProgram = new ExpertDocument();
        docProgram.OpenDocument();
        docProgram.EditDocument();
        docProgram.SaveDocument();
    }

    else
    {
        Console.WriteLine("DUZ YAZ DEEEEEEEEEEEE");
    }
}