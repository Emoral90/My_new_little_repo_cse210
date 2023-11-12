using System;
using System.IO;

public class Journal{
    // Attributes
    string[] prompts = {
        "How did I save money today?", 
        "Where did I find happiness?", 
        "Did I talk with a cute girl?", 
        "How did I wake up today?", 
        "What was the best part of my day?"
        };

    string Entries = "Entries.txt";
    

    // Constructor
    // public Journal(){}
    Interactor interactor = new Interactor();

    // Methods
    public void display_prompt(){
        // Instantiate the Random class
        Random rand = new Random();
        int random_number = rand.Next(4);

        // Provide randomly chosen prompt and save entry
        Console.Write("Today's prompt is: ");
        Console.WriteLine(prompts[random_number]);

    }


    // Load the journal from a text file
//     public void load_journal(File file){
//         file = "Entries.txt";
//         string[] lines = System.IO.ReadAllLines(file);

//         foreach (string line in lines){
//             string[] parts = line.Split(",");
//             string answer = parts[0];
//             string date = parts[1];
//             Console.WriteLine(line);
//         }
        
//     }

    // Save the previously made journal entry to a file
    public void save_journal(string myEntry){
        var journal_lines = File.ReadLines(myEntry);

        using(StreamWriter out_file = new StreamWriter(Entries, true)){

            out_file.WriteLine(myEntry);

            foreach (string line in journal_lines)
            {
                Console.WriteLine(line);
            }
            // return out_file;
        }
    }

        public void display_whole_journal(System.IO.StreamWriter inputFile){
            

    }

}