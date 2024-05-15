namespace MyWebApi.Services
{
    public interface ICommonService<T, TI, TU>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> GetByName(string name);
        public Task<T> Add(TI obj);
        public Task<T> Update(int id, TU obj);
        public Task<T> Delete(int id);
    }
}