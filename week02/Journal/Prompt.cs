public class Prompt
{
    // List of prompts for the journal
    private List<string> _prompts = new List<string>
    {
        "How was your day today?",
        "Tell me something, I want to know more about you.",
        "How u doing?",
        "What did you do today?",
        "Hi again, how are you feeling today?",
        "What is your favorite part of the day?",
        "What did I miss today?",
        "Gossip is my second name",
        "Spit it out, I want to know everything."
    };

    // Pick a random prompt from the list of prompts
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];  // Returns the selected prompt
    }
}