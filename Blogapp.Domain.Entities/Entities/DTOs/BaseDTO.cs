using Blogapp.Domain.Entities.Entities;
using System.ComponentModel.DataAnnotations;

namespace Blogapp.Domain.Entities.Entiti.DTOs
{
    public abstract class BaseDTO<T> where T : BaseEntity
    {
        [StringLength(maximumLength: 24, MinimumLength = 24,ErrorMessage = "O id deve ser um dígito hexadecimal de 24 dígitos.")]
        public string Id { get; set; }

        protected BaseDTO(T entity) { }
        protected BaseDTO() { }

        public abstract T ToEntity();
    }


}
