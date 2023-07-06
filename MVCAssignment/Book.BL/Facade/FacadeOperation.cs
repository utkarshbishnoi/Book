using Book.BL;
using Book.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book.BL.EventRepo;
using AutoMapper;

namespace Book.BL.EventRepo
{
    public class EventFacade : IEventFacade
    {
        private readonly DAL.Repository.IOperationRepo _DAL;
        private readonly IMapper _mapper;

        public EventFacade(DAL.Repository.IOperationRepo dal)
        {
            _DAL = dal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EventEntity, ReadingEvent>().ReverseMap();
                cfg.CreateMap<CommentEntity, CommentModel>().ReverseMap();
            });
            _mapper = config.CreateMapper();
        }

        public List<ReadingEvent> GetAllEvents()
        {
            List<EventEntity> eventEntities = _DAL.GetAllEvents();
            List<ReadingEvent> readingEvents = _mapper.Map<List<EventEntity>, List<ReadingEvent>>(eventEntities);
            return readingEvents;
        }

        public ReadingEvent GetEventById(int? id)
        {
            if (id == null)
            {
                throw new NotImplementedException();
            }

            var eventEntity = _DAL.GetEventById(id);


            if (eventEntity == null)
            {
                throw new NotImplementedException();
            }

            ReadingEvent readingEvent = _mapper.Map<EventEntity, ReadingEvent>(eventEntity);
            return readingEvent;
        }

       public List<ReadingEvent> GetUserEventById(string id)
        {
            if (id == null)
            {
                throw new NotImplementedException();
            }

            //var eventEntity = _DAL.GetUserEventById(id);
            List<EventEntity> eventEntities = _DAL.GetUserEventById(id);
            List<ReadingEvent> readingEvents = _mapper.Map<List<EventEntity>, List<ReadingEvent>>(eventEntities);

            if (eventEntities == null)
            {
                throw new NotImplementedException();
            }
            //ReadingEvent readingEvent = _mapper.Map<EventEntity, ReadingEvent>(eventEntity);
            return readingEvents;
        }


        public void CreateEvent(ReadingEvent readingEvent)
        {
            EventEntity eventEntity = _mapper.Map<ReadingEvent, EventEntity>(readingEvent);
            _DAL.PostEvent(eventEntity);
        }

        public void Edit(int id, ReadingEvent updateReadingEvent)
        {
            if (id != updateReadingEvent.Id)
            {
                throw new NotImplementedException();
            }

            EventEntity eventEntity = _mapper.Map<ReadingEvent, EventEntity>(updateReadingEvent);

            try
            {
                _DAL.UpdateEvent(eventEntity);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_DAL.ReadingEventExists(id))
                {
                    throw new NotImplementedException();
                }
                else
                {
                    throw;
                }
            }
        }

        public void DeleteConfirmed(int id)
        {
            _DAL.DeleteEvent(id);
        }

        public List<ReadingEvent> InvitedTo(string InvitedEmail)
        {
            List<ReadingEvent> Invited = new List<ReadingEvent>();
            List<EventEntity> eventEntities = _DAL.GetAllEvents();
            List<ReadingEvent> readingEvents = _mapper.Map<List<EventEntity>, List<ReadingEvent>>(eventEntities);

            foreach (var item in readingEvents)
            {
                string[] emails = item.Invites.Split(',');

                foreach (var email in emails)
                {
                    if (email.Equals(InvitedEmail))
                    {
                        Invited.Add(item);
                    }
                }
            }

            return Invited;
        }

        public void AddComment(CommentModel comments)
        {
            CommentEntity commentEntity = _mapper.Map<CommentModel, CommentEntity>(comments);
            _DAL.PostComment(commentEntity);
        }

        public List<CommentModel> Comments(int? id)
        {
            var commentEntities = _DAL.GetCommentsById(id);
            List<CommentModel> commentModels = _mapper.Map<List<CommentEntity>, List<CommentModel>>(commentEntities);
            return commentModels;
        }
    }
}
