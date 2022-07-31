using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;

namespace TudorPortal.Business.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Event, EventModel>().ReverseMap();
            CreateMap<Topics, TopicsModel>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();
            CreateMap<EventLike, EventLikeModel>().ReverseMap();
            CreateMap<TopicLike, TopicLikeModel>().ReverseMap();
            CreateMap<Comment, AddCommentModel>().ReverseMap();
            CreateMap<Event, AddEventModel>().ReverseMap();
            CreateMap<Topics, AddTopicsModel>().ReverseMap();
            CreateMap<EventLike, AddEventLikeModel>().ReverseMap();
            CreateMap<TopicLike, AddTopicLikeModel>().ReverseMap();
        }
    }
}
