using System;
using System.IO;
using System.Collections.Generic;

namespace todolist
{
    class Program
    {
        static int Main(string[] args)
        {
            List<string> todoList= new List<string>();
            string fileName = "todo.csv";
            string filePath = ".//"  + fileName;

            try{
            string[] todofile = File.ReadAllLines(@filePath);
            
            foreach(string line in todofile){
                todoList.Add(line);
            }
            } catch(IOException e){
                Console.WriteLine("Error Acesso.");
                Console.WriteLine(e.Message);
                return -1;
            }

            int count = 1;
            {
            foreach (string item in todoList);
            Console.WriteLine($"count: {count,3}:, {item}");
            count++;
        
        }
        return 0;

    }
}
