using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
  public string _prompt = " ";
  public List<string> _prompts = new List<string>
  {
    "What was the highlight of your day?",
    "Describe a challenge you faced today.",
    "What is something new you learned today?",
    "How did you feel today and why?",
    "Write about something that made you smile."
  };

  public string GetRandomPrompt()
  {
    Random random = new Random();
    return _prompts[random.Next(_prompts.Count)];
  }
}