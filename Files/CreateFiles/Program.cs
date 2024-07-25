// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Files

const string filename = "TestFile.txt";
//1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
File.WriteAllText(filename, "this is a text file. ");    
}  
// 3: appendAllText adds text to an existing file
File.AppendAllText(filename, "This text gets append to the file. ");
// 4: A FileStream can be opened and written to until closed 
using (StreamWriter sw = File.AppendText(filename)) {
sw.WriteLine("Line 1"); 
sw.WriteLine("Line 2");    
sw.WriteLine("Line 3");       
} 
// 2: readAllText reads all the content from a file
string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);



