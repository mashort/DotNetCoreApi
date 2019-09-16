using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                // Just showing how you can have more control over the mapping
                // of object properties e.g. in this case we want to have the property
                // name of "Venue" in CampModel, but still have it auto mapped
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName)).ReverseMap();
        }
    }
}
