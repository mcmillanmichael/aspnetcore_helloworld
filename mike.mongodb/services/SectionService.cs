using Microsoft.Extensions.Configuration;
using mike.mongodb.models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace mike.mongodb.services
{
    //public class SectionService
    //{
    //    public SectionService(IConfiguration config)
    //    {
    //        var connectionString = config.GetConnectionString("MongoDbAtlas");
    //        var client = new MongoClient(connectionString);
    //        var db = client.GetDatabase("portfolio");
    //        _sections = db.GetCollection<Section>("portfolio.section");
    //    }

    //    public List<Section> Get()
    //    {
    //        try
    //        {
    //            //return new List<Section> {
    //            //    new Section() { Header = "Header1", Content = "Content 1"},
    //            //    new Section() { Header = "Header2", Content = "Content 2"},
    //            //};
    //            return _sections
    //                .Find(s => true)
    //                .ToList();
    //        }
    //        catch
    //        {
    //            return new List<Section>(0);
    //        }
    //    }

    //    private IMongoCollection<Section> _sections;
    //}
}
