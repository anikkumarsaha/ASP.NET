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
    public class DonorService
    {
        public static List<DonorDTO> GetAllDonors()
        {
            var data = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var DTODonors = mapper.Map<List<DonorDTO>>(data);
            return DTODonors;
        }
        public static DonorDTO GetDonor(int id)
        {
            var data = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var DTODonor = mapper.Map<DonorDTO>(data);
            return DTODonor;
        }
        public static DonorDTO AddDonor(DonorDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DonorDTO, Donor>();
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var EFDonor = mapper.Map<Donor>(obj);
            var result = DataAccessFactory.DonorDataAccess().Add(EFDonor);

            return mapper.Map<DonorDTO>(result);
        }
        public static bool EditDonor(DonorDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DonorDTO, Donor>();
                cfg.CreateMap<Donor, DonorDTO>();
            });
            var mapper = new Mapper(config);
            var EFDonor = mapper.Map<Donor>(obj);
            var result = DataAccessFactory.DonorDataAccess().Edit(EFDonor);

            return result;
        }
        public static bool DeleteDonor(int id)
        {
            var result = DataAccessFactory.DonorDataAccess().Delete(id);
            return result;
        }
    }
}
