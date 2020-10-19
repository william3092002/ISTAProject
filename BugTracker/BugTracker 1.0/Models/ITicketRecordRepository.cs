using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface ITicketRecordRepository
    {
        IEnumerable<TicketRecord> AllTicketRecords { get; }
        IEnumerable<TicketRecord> GetRecordsByTicketId(int TicketId);
        TicketRecord GetRecordByTicketId(int TicketId);
        void CreateRecord(TicketRecord record);
        void DeleteLastRecord(TicketRecord record);

    }
}
