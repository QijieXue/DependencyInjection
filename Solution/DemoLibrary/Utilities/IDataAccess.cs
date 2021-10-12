namespace DemoLibrary.Utilities
{
    public interface IDataAccess
    {
        string LoadData();
        void SaveData(string data);
    }
}