﻿using System;
using MongoDB.Driver;
namespace booking_rdms_api.booking_rdms_api.utls
{
    public class MongoDbDriver
    {
        public MongoDbDriver()
        {
        }

        public IMongoDatabase Connect()
        {

            try
            {
                var client = new MongoClient("mongodb+srv://thokle:1August*@cluster0.8xpxv.azure.mongodb.net/test?retryWrites=true&w=majority");
                client.ListDatabaseNames().ForEachAsync(f =>
                {
                    Console.WriteLine(f);
                });
                var database = client.GetDatabase("test");
                return database;
            }
            catch (MongoException m)
            {
                throw new Exception(message: m.Message);

            }




        }

    }
}
