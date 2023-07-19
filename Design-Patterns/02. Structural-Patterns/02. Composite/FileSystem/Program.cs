namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Folder("File system");

            // create new disk
            Component diskC = new Folder("Disc C");

            // create new files
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");

            // add files to disk С
            diskC.Add(pngFile);
            diskC.Add(docxFile);

            // add disk С to the file system
            fileSystem.Add(diskC);

            // get all data
            fileSystem.Print();
            Console.WriteLine();

            // remove file from disk C
            diskC.Remove(pngFile);

            // create new folder
            Component docsFolder = new Folder("My Documents");

            // create new files
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");

            // add files to the new folder
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            // get all data
            fileSystem.Print();

            Console.Read();
        }
    }
}