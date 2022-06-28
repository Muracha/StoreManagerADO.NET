namespace StoreManager.App.Interfaces
{
    public interface IDetailsForm<T>
    {
        void LoadData(int id);
        T SaveData();
    }
}
