using Book.DAL;
using Book.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book.DAL.Repository
{
    public class OperationRepo : IOperationRepo,IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        //private readonly IUnitOfWork _unitOfWork;
        public OperationRepo(ApplicationDbContext context)
        {
            _context = context;
            //_unitOfWork = unitOfWork;
        }

        public List<EventEntity> GetAllEvents()
        {

            return _context.ReadingEvent.ToList();
        }
       
        public EventEntity GetEventById(int? id)
        {

            EventEntity p = new EventEntity();

            p = _context.ReadingEvent.FirstOrDefault(x => x.Id == id);

            return p;
        }

        public List<EventEntity> GetUserEventById(string id)
        {
             return _context.ReadingEvent.Where(x => x.CreatedBy == id).ToList();
        }


        public void PostEvent(EventEntity events)
        {

            _context.ReadingEvent.Add(events);
            _context.SaveChanges();
        }

        public void UpdateEvent(EventEntity events)
        {        
                _context.ReadingEvent.Update(events);
                _context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var registerEventModel = _context.ReadingEvent.Find(id);
            _context.ReadingEvent.Remove(registerEventModel);
            _context.SaveChanges();
        }

        public void PostComment(CommentEntity comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public List<CommentEntity> GetCommentsById(int? id)
        {

            List<CommentEntity> comment = new List<CommentEntity>();

            comment = _context.Comments.Where(x => x.EventId == id).ToList();

            return comment;
        }

        public bool EventModelExists(int id)
        {
            return _context.ReadingEvent.Any(e => e.Id == id);
        }

        public bool ReadingEventExists(int id)
        {
            throw new NotImplementedException();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
