using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Users.UsersModel;
using WebAppSupportSystem.Models.ViewModels;

namespace WebAppSupportSystem.Mappers
{
    public class CommonMapper : IMapper
    {
        static CommonMapper()
        {
            Mapper.CreateMap<tbl_1_User, UserView>()
                    .ForMember(dest => dest.BirthdateDay, opt => opt.MapFrom(src => src.Birthdate.Day))
                    .ForMember(dest => dest.BirthdateMonth, opt => opt.MapFrom(src => src.Birthdate.Month))
                    .ForMember(dest => dest.BirthdateYear, opt => opt.MapFrom(src => src.Birthdate.Year));
            Mapper.CreateMap<UserView, tbl_1_User>()
                    .ForMember(dest => dest.Birthdate, opt => opt.MapFrom(src => new DateTime(src.BirthdateYear, src.BirthdateMonth, src.BirthdateDay)));
        }
        public object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}