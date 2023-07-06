using AutoMapper;
using Book.BL;
using Book.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book.BL.EventRepo;

namespace Book.BL.EventRepo
{
    public class EventOperation : IEventOperation
    {
        private DAL.Repository.IOperationRepo _DAL = null;
        private Mapper _MapperEvent;
        private Mapper _MapperComment;

        public EventOperation(DAL.Repository.IOperationRepo dal)
        {
            _DAL = dal;
            var _configEvent = new MapperConfiguration(cfg => cfg.CreateMap<EventEntity, ReadingEvent>().ReverseMap());
            var _configcomment = new MapperConfiguration(cfg => cfg.CreateMap<CommentEntity, CommentModel>().ReverseMap());

            _MapperEvent = new Mapper(_configEvent);
            _MapperComment = new Mapper(_configcomment);
        }

        public List<ReadingEvent> GetAllEvents()
        {
            List<EventEntity> EventFromDB = _DAL.GetAllEvents();
            List<ReadingEvent> ReadingEvent = _MapperEvent.Map<List<EventEntity>, List<ReadingEvent>>(EventFromDB);

            return ReadingEvent;
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

            ReadingEvent ReadingEvent = _MapperEvent.Map<EventEntity, ReadingEvent>(eventEntity);

            return ReadingEvent;
        }


        public void CreateEvent(ReadingEvent ReadingEvent)
        {
            EventEntity eventEntity = _MapperEvent.Map<ReadingEvent, EventEntity>(ReadingEvent);
            _DAL.PostEvent(eventEntity);
        }

        public void Edit(int id, ReadingEvent updateReadingEvent)
        {
            if (id != updateReadingEvent.Id)
            {
                throw new NotImplementedException();
            }

            EventEntity eventEntity = _MapperEvent.Map<ReadingEvent, EventEntity>(updateReadingEvent);

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
            List<EventEntity> EventFromDB = _DAL.GetAllEvents();
            List<ReadingEvent> ReadingEvent = _MapperEvent.Map<List<EventEntity>, List<ReadingEvent>>(EventFromDB);


            foreach (var item in ReadingEvent)
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
            CommentEntity commentEntity = _MapperComment.Map<CommentModel, CommentEntity>(comments);
            _DAL.PostComment(commentEntity);

        }

        public List<CommentModel> Comments(int? id)
        {
            var CommentList = _DAL.GetCommentsById(id);
            List<CommentModel> commentList = _MapperComment.Map<List<CommentEntity>, List<CommentModel>>(CommentList);
            return commentList;
        }

    }
}
