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
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName))
                .ReverseMap();

            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                // These 2 Ignores are to ensure that the Camp & Speaker are not sheared off
                // if they have not been provided in the TalkModel when doing a PUT
                .ForMember(t => t.Camp, opt => opt.Ignore())
                .ForMember(t => t.Speaker, opt => opt.Ignore());

            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
        }
    }
}
