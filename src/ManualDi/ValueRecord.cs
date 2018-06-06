namespace ManualDi
{
    public readonly struct ValueRecord
    {
        public ValueRecord(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; }
        public string Value { get; }
    }
}
