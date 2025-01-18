public class Resume
{
  public string _givingName = " ";
  public List<Job> _jobs = new List<Job>();

  public void DisplayResume()
  {
    Console.WriteLine($"Name: {_givingName}");
    Console.WriteLine("Jobs:");
    foreach (var job in _jobs)
      {
          job.DisplayJobDetails();
      }
  }

}