using System;
using System.Collections.Generic;
using System.IO;


public class Program{
    static void Main(){
        // GLOBAL VARIABLES
        string myChoice = "";
        string myEntry;
        string specDate;
        // System.IO.StreamWriter outputFile;

        // Constructors
        Journal journal = new Journal();
        Interactor interactor = new Interactor();



        journal.display_prompt();
        myEntry = interactor.get_prompt_answer();
        // specDate = interactor.get_date();

        journal.save_journal("Entries.txt");

        // journal.display_whole_journal(outputFile);

            
            
            
            // Main logic loop
            while (myChoice != "6"){
                Console.WriteLine();
                Console.WriteLine(" - - - - - - - Main Menu - - - - - - - -");
                Console.WriteLine("========================================");
                Console.WriteLine("1) Write a new entry");
                Console.WriteLine("2) Display Journal");
                Console.WriteLine("3) Load Journal from file");
                Console.WriteLine("4) Save Journal to file");
                Console.WriteLine("5) Display Journal");
                Console.WriteLine("6) Quit");
                Console.WriteLine();
                
                myChoice = Console.ReadLine();

                if (myChoice == "1"){
                    journal.display_prompt();
                    myEntry = interactor.get_prompt_answer();
                    specDate = interactor.get_date();
                }

                else if (myChoice == "2"){
                    journal.display_whole_journal(outputFile);
                }

            
            else if (myChoice == "3"){
                journal.load_journal("Entries.txt");
            }

            else if (myChoice == "4"){
                outputFile = journal.save_journal();
            }

        }

    }
}