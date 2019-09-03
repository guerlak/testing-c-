using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ByteBank.Tools
{

    public class FileReaderSimuator : IDisposable
    {
            public string File { get; }

            public FileReaderSimuator(string file)
            {
                File = file;
                Console.WriteLine("Openning file: " + file);
            }

            public string ReadNextLine()
            {
        
                for(int i = 0;i < 4; i++)
                {
                    Console.WriteLine("Reading line...");
                }
                //throw new IOException();
                return "file line";
            }

            public void Close()
            {
                Console.WriteLine("Closing file.");
            }

            public void Dispose()
            {
                Close();
            }
    }
    
}
