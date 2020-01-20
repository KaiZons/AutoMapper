using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace MapperConfigure
{
    public class AutoMapperInit
    {
        public static void Start()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<SourceProfile>();
            });
        }
    }
}
