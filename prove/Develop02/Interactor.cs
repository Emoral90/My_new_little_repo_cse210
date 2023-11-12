public class Interactor{
    // Attributes
    public string prompt_answer;
    public string date;

    // Constructor
    // public Interactor(){}

    // Methods
    // Trust the user to enter an appropriate response
    public string get_prompt_answer(){
        Console.WriteLine("Enter prompt response below");
        prompt_answer = Console.ReadLine();
        return prompt_answer;
    }

    // Trust the user to enter the correct date
    public string get_date(){
        Console.WriteLine("Enter the date as: MM/DD/YYYY");
        date = Console.ReadLine();
        return date;
    }

    // Display the previously made journal entry
    public void display_entry(){
        Console.WriteLine($"Your entry: {prompt_answer}");
        Console.WriteLine($"Date enterd: {date}");
    }
}