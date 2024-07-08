using System.Buffers;

class Program
{
    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened!");
        }
        virtual public void editDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        virtual public void saveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    class ProDocumentProgram : DocumentProgram
    {
        public void openDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public override sealed void editDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void saveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
    class ExpertDocument : ProDocumentProgram
    {
        public void openDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public override void saveDocument()
        {
            Console.WriteLine("Document Saved");
        }

        public void editDocument()
        {
            Console.WriteLine("Document edited");
        }
    }


    static void Main(string[] args)
    {
        //Action action;
        List<Action> actions = new List<Action>();
        Console.Write("Secim : ");
        var choice = Console.ReadLine();
        DocumentProgram program = choice switch
        {
            "basic" => new DocumentProgram(),
            "pro" => new ProDocumentProgram(),
            "expert" => new ExpertDocument()


        };
        if (program != null)
        {
            actions.Add(program.OpenDocument);
            actions.Add(program.saveDocument);
            actions.Add(program.editDocument);
        }
        else
        {
            Console.WriteLine("Duzgun secim girin.");
        }

        foreach (Action action in actions)
        {
            action.Invoke();    
        }
    }
}

