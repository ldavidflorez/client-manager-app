namespace MyWebApi.Repository
{
    public interface ICommonRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity> GetById(int id);
        public Task<TEntity> GetByName(string name);
        public Task Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public Task Save();
    }
}