namespace ManualDi
{
    public interface IValueRepository
    {
        ValueRecord[] Get();
        ValueRecord Get(int id);
        void Update(int id, ValueRecord value);
        void Delete(int id);
    }
}
