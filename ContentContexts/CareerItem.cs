namespace Zero.ContentContext{
      public class CareerItem : Base {

        public IList<String> Notifications {get; set;}
        public  CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course ?? throw new System.Exception("O curso não pode ser nulo");
        }

        public int Order {get; set;}
        public string Title { get; set; }

        public string Description { get; set; }

        public Course Course { get; set; }
    }
}