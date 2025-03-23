using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        public class Journal
        {
            public string _entry = " ";
            public List<Entry> _entries = new List<Entry>();

            public void AddEntry(Entry newEntry)
            {
                _entries.Add(newEntry);
            }
            public void DisplayAll()
            {
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                }
            }

            public void SaveToFile(string file)
            {
                StreamWriter writer = new StreamWriter(file);
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.GetSaveFormat());
                }
                writer.Close();
                Console.WriteLine("Journal saved.");
            }

            public void LoadFromFile(string file)
            {
                _entries.Clear();
                try
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 3)
                            {
                                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                            }
                        }
                    }
                    Console.WriteLine("Journal loaded.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error loading journal: " + e.Message);
                }
            }   

        }

    }
}