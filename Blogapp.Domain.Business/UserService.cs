using AutoMapper;
using Blogapp.Domain.Entities.Entities.DTOs;
using Blogapp.Domain.IServices;
using Blogapp.Domain.Repositories.Contract.Interfaces;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;

namespace Blogapp.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository _userRepository, IMapper _mapper)
        {
            this.userRepository = _userRepository;
            this.mapper = _mapper;
        }
        public ObjectId Add(UserDTO entity)
        {
            return userRepository.Add(entity.ToEntity());
        }

        public IEnumerable<UserDTO> Browse()
        {
            var users = userRepository.All();
            return users.Select(x => mapper.Map<UserDTO>(x));
        }

        public void Change(UserDTO dto)
        {
            userRepository.Edit(dto.ToEntity());
        }

        public void Delete(UserDTO dto)
        {
            userRepository.Delete(dto.ToEntity());
        }

        public void Edit(UserDTO dto)
        {
            throw new System.NotImplementedException();
        }

        public UserDTO Read(string id)
        {
            return mapper.Map<UserDTO>(userRepository.FindByKey(id));
        }
    }
}
