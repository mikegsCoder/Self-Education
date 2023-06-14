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

            // Find file in DB:
            // set filter
            var filter1 = Builders<GridFSFileInfo>.Filter.Eq(info => info.Filename, "kitty.jpeg");
            // find all files
            //var fileInfos = await gridFS.FindAsync(filter);
            var fileInfos = gridFS.Find(filter1);
            // take first file
            var fileInfo1 = fileInfos.FirstOrDefault();
            // write information
            Console.WriteLine($"id = {fileInfo1?.Id}\nName: {fileInfo1?.Filename}\n" +
                $"UploadDateTime: {fileInfo1?.UploadDateTime}\nSize: {fileInfo1?.Length}");
            Console.WriteLine(fileInfo1?.BackingDocument);
            Console.WriteLine(new string('-', 50));

            // Replace:
            using FileStream fs4 = File.OpenRead("../../../dog.jpg");
            //var id = await gridFS.UploadFromStreamAsync(
            //        "kitty.jpeg",
            //        fs,
            //        new GridFSUploadOptions { Metadata = new BsonDocument("filename", "kitty.jpeg") });
            var id1 = gridFS.UploadFromStream(
                    "kitty.jpeg",
                    fs4,
                    new GridFSUploadOptions { Metadata = new BsonDocument("filename", "kitty.jpeg") });

            Console.WriteLine($"File replaced. File Id: {id1}");
            Console.WriteLine(new string('-', 50));

            // Delete from DB:
            // set filter
            var filter2 = Builders<GridFSFileInfo>.Filter.Eq(info => info.Filename, "kitty.jpeg");
            // find all files "kitty.jpeg"
            //var fileInfos = await gridFS.FindAsync(filter);
            var fileInfos2 = gridFS.Find(filter2);
            // take first file
            var fileInfo2 = fileInfos2.FirstOrDefault();

            // delete
            if (fileInfo2 != null)
                //await gridFS.DeleteAsync(fileInfo.Id);
                gridFS.Delete(fileInfo2.Id);
        }
    }
}