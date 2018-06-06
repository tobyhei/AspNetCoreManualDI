namespace ManualDi
{
    public class ValueService
    {
        private readonly IValueRepository valueRepository;

        public ValueService(IValueRepository valueRepository)
            => this.valueRepository = valueRepository;

        public ValueRecord[] Get() => valueRepository.Get();
        public ValueRecord Get(int id) => valueRepository.Get(id);
        public void Update(int id, ValueRecord value) => valueRepository.Update(id, value);
        public void Delete(int id) => valueRepository.Delete(id);
    }
}
