using mike.models;
using System;
using System.Collections.Generic;

namespace mike.data
{
    public interface ISectionData
    {
        IEnumerable<Section> GetAll();

        IEnumerable<Section> GetByContent(string content);
    }
}
