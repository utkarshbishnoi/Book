using Book.DAL.Entities;
using System.Collections.Generic;

namespace Book.DAL.Repository
{
    public interface IOperationRepo
    {
        void DeleteEvent(int id);
        bool EventModelExists(int id);
        List<EventEntity> GetAllEvents();
        List<CommentEntity> GetCommentsById(int? id);
        EventEntity GetEventById(int? id);
        List<EventEntity> GetUserEventById(string id);

        void PostComment(CommentEntity comment);
        void PostEvent(EventEntity events);
        void UpdateEvent(EventEntity events);
        bool ReadingEventExists(int id);
    }
}