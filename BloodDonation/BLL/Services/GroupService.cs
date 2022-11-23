using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GroupService
    {
        public static List<GroupDTO> GetAllGroups()
        {
            var data = DataAccessFactory.GroupDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var DTOGroups = mapper.Map<List<GroupDTO>>(data);
            return DTOGroups;
        }
        public static GroupDTO GetGroup(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var DTOGroup = mapper.Map<GroupDTO>(data);
            return DTOGroup;
        }
        public static bool AddGroup(GroupDTO obj)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<GroupDTO, Group>());
            var mapper = new Mapper(config);
            var EFGroup = mapper.Map<Group>(obj);
            var result = DataAccessFactory.GroupDataAccess().Add(EFGroup);

            return result;
        }
    }
}
