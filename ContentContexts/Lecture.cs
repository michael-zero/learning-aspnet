using Zero.ContentContext.Enums;

namespace Zero.ContentContext {
      public class Lecture {
        public int Ordem { get; set; }
        public string Title { get; set; }

        public double DurationInMinutes {get; set;}
        public EContentLevel Level { get; set; }
    }
}