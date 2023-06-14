using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace FilesAndGridFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");

            var db = client.GetDatabase("test2");
            IGridFSBucket gridFS = new GridFSBucket(db);

            // create stream:
            using Stream fs1 = File.OpenRead("../../../kitty.jpeg");
            // save in DB:
            //ObjectId id = await gridFS.UploadFromStreamAsync("kitty.jpeg", fs);
            ObjectId id = gridFS.UploadFromStream("kitty.jpeg", fs1);
            Console.WriteLine($"Id: {id}");

            Console.WriteLine(new string('-', 50));

            // create stream
            using Stream fs2 = File.OpenWrite("../../../new_kitty1.jpeg");
            // download from DB:
            //await gridFS.DownloadToStreamByNameAsync("cats.jpg", fs2);
            gridFS.DownloadToStreamByName("kitty.jpeg", fs2);

            // create stream
            using Stream fs3 = File.OpenWrite("../../../new_kitty2.jpeg");
            // download from DB:
            //await gridFS.DownloadToStreamAsync("cats.jpg", fs3);
            gridFS.DownloadToStream(id, fs3);
        }
    }
}