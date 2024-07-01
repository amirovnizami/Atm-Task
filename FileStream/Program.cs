using System.Text;
using System.Xml;


//using FileStream fs = new FileStream("new.txt", FileMode.Create);
//Console.WriteLine(Directory.GetCurrentDirectory());

//Directory.CreateDirectory("C:\\Users\\amiro\\Desktop\\Folder1");
//Directory.Delete("C:\\Users\\amiro\\Desktop\\Folder1");

DirectoryInfo directoryInfo = new("C:\\Users\\amiro\\Desktop");

//foreach (FileInfo file in directoryInfo.GetFiles())
//{
//    //Console.WriteLine(file.Name);
//    if (file.Name == "NewTxt.txt")
//    {
//        Console.WriteLine("True");
//        file.Delete();
//    }
//    else { Console.WriteLine("False"); }
//}


//}

//string sourceFile = "C:\\Users\\amiro\\Desktop\\Folder1\\new.txt";
//string desinatioFile = "C:\\Users\\amiro\\Desktop\\Folder2\\new.txt";

//try
//{
//    File.Move(sourceFile, desinatioFile);
//    Console.WriteLine("File ugurla koculdu.");
//}
//catch (Exception ex)
//{

//Console.WriteLine(ex.Message); } 