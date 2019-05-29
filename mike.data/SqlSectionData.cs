using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using mike.models;
using Microsoft.EntityFrameworkCore;

namespace mike.data
{
    public class SqlSectionData : ISectionData
    {
        public SqlSectionData(PortfolioDbContext db)
        {
            this._db = db;
        }

        public IEnumerable<Section> GetAll()
        {
            return from s in _db.Sections
                        orderby s.Header
                        select s;
        }

        public IEnumerable<Section> GetByContent(string content)
        {
            return from s in _db.Sections
                        where s.Content.Contains(content)
                        orderby s.Header
                        select s;
        }

        private Section Update(Section updatedSection)
        {
            var entity = _db.Sections.Attach(updatedSection);
            entity.State = EntityState.Modified;
            return updatedSection;
        }

        private Section Delete(Section deletedSection)
        {
            var section = _db.Sections.Find(deletedSection.SectionId);
            if (section != null)
            {
                _db.Sections.Remove(deletedSection);
            }
            return section;
        }
        private Section Add(Section newSection)
        {
            _db.Add(newSection);
            return newSection;
        }

        private int Commit()
        {
            return _db.SaveChanges();
        }

        private readonly PortfolioDbContext _db;
    }
}
