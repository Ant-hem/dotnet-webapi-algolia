namespace Algolia.WebAPI.Model
{
    public class Actor
    {
        public string Name { get; set; }
        public string ObjectID { get; set; }
        public int Rating { get; set; }
        public string ImagePath { get; set; }
        public string AlternativePath { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\r\nObjectId: {ObjectID}\r\nRating: {Rating}";
        }
    }
}