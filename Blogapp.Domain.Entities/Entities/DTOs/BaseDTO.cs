namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public abstract class BaseDTO<T> where T : BaseEntity
    {
        public string Id { get; set; }

        protected BaseDTO(T entity) { }
        protected BaseDTO() { }

        public abstract T ToEntity();
    }


}
