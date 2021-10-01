namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading data...");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data...");
        }
    }
}
