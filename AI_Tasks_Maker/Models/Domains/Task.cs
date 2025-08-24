namespace AI_Tasks_Maker.Models.Domains
{
    public class Task
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Term {get; set;}


        public string MyProperty { get; set; }


    }
}
