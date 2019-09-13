using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class TalkProfile : Profile
    {
        public TalkProfile()
        {
            CreateMap<Talk, TalkModel>();
        }
    }
}
