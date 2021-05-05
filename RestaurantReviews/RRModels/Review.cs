namespace RRModels
{
    public class Review
    {
        public int Rating {get; set;}

        public string Description { get; set; }

        public override string ToString()
        {
            return $"\tRating: {this.Rating}\n\tDescription: {this.Description}";
        }
    }
}