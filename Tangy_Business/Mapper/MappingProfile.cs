﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tangy_Models;
using Tany_DataAccess;

namespace Tangy_Business.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
           CreateMap <Category,CategoryDTO>().ReverseMap();
        }
    }
}
