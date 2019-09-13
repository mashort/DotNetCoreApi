using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class SpeakerProfile : Profile
    {
        public SpeakerProfile()
        {
            CreateMap<Speaker, SpeakerModel>();
        }
    }
}
