using Book.BL;
using System.Collections.Generic;

namespace Book.BL.EventRepo
{
    public interface IEventOperation
    {
        void AddComment(CommentModel comments);
        List<CommentModel> Comments(int? id);
        void CreateEvent(ReadingEvent ReadingEvent);
        void DeleteConfirmed(int id);
        void Edit(int id, ReadingEvent updateReadingEvent);
        List<ReadingEvent> GetAllEvents();
        ReadingEvent GetEventById(int? id);
        List<ReadingEvent> InvitedTo(string InvitedEmail);
    }
}