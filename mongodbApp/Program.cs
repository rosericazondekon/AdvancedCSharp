using System;
using MongoDB.Driver;
using MongoDB.Bson;

string connectionString = GetMongoDBConnectionString();

// MongoDB database name
string databaseName = GetDatabaseName();

// Creating MongoClient and connecting to the server
var client = new MongoClient(connectionString);

// Accessing the database
var database = client.GetDatabase(databaseName);

// Print a list of available databases on the server
Console.WriteLine("Databases on the MongoDB server:");

foreach (var dbName in client.ListDatabaseNames().ToList())
{
    Console.WriteLine(dbName);
}

Console.WriteLine("\nConnecting to MongoDB successful!");

Console.ReadLine(); // Keep console window open

static string GetMongoDBConnectionString()
{
    const string ConnectionStringFilePath = "con";
    string connectionString = string.Empty;
    if (File.Exists(ConnectionStringFilePath))
    {
        connectionString = File.ReadAllText(ConnectionStringFilePath).Trim();
    }
    else
    {
        throw new InvalidOperationException($"The connection string file '{ConnectionStringFilePath}' does not exist.");
    }
    // Console.Write("Enter MongoDB connection string: ");
    // Console.WriteLine(connectionString);
    return connectionString;
}

static string GetDatabaseName()
{
    Console.Write("Enter MongoDB database name: ");
    return Console.ReadLine();
}