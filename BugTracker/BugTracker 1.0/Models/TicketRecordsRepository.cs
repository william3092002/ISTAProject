using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class TicketRecordsRepository : ITicketRecordRepository
    {
        private readonly AppDbContext _appDbContext;
        public TicketRecordsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<TicketRecord> AllTicketRecords
        {
            get
            {
                return _appDbContext.TicketRecords;
            }
        }

        public void CreateRecord(TicketRecord record)
        {
            _appDbContext.Add(record);
            _appDbContext.SaveChanges();
        }

        public void DeleteLastRecord(TicketRecord record)
        {
            _appDbContext.Remove(record);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<TicketRecord> GetRecordsByTicketId(int TicketId) =>
            _appDbContext.TicketRecords.Where(t => t.TicketId == TicketId);

        public TicketRecord GetRecordByTicketId(int TicketId) =>
            _appDbContext.TicketRecords.OrderByDescending(t => t.RecordId).FirstOrDefault();

    }
}
