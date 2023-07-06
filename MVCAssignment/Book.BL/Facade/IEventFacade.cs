using Book.BL;
using System.Collections.Generic;

namespace Book.BL.EventRepo
{
    public interface IEventFacade
    {
        List<ReadingEvent> GetAllEvents();
        ReadingEvent GetEventById(int? id);
        List<ReadingEvent> GetUserEventById(string id);
        void CreateEvent(ReadingEvent ReadingEvent);
        void Edit(int id, ReadingEvent updateReadingEvent);
        void DeleteConfirmed(int id);
        List<ReadingEvent> InvitedTo(string InvitedEmail);
        void AddComment(CommentModel comments);
        List<CommentModel> Comments(int? id);
    }
}