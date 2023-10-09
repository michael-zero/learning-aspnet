using System;
using Zero.ContentContext;


namespace Zero {
  class Program {
    static void Main(string[] args){
      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre POO", "orientacao-objetos"));

      var coursePOO = new Course("Fundamentos POO", "fundamentos-poo");
      var courseCsharp = new Course("Fundamentos C#", "fundamentos-poo");
      var courseAspNet  = new Course("Fundamentos ASP.NET", "fundamentos-poo");

      var courses = new List<Course>();
      courses.Add(coursePOO);
      courses.Add(courseCsharp);
      courses.Add(courseAspNet);

      var carreiras = new List<Career>();
      var carreira = new Career("Especialista .NET", "especialista-dotnet");
      var carreiraItem = new CareerItem(1,"POO","",coursePOO);
      var carreiraItem2 = new CareerItem(2,"Aprenda csharp","",courseCsharp);
      var carreiraItem3 = new CareerItem(3,".NET","",courseAspNet);

      carreira.Items.Add(carreiraItem);
      carreira.Items.Add(carreiraItem2);
      carreira.Items.Add(carreiraItem3);
      
      carreiras.Add(carreira);

      foreach(var c in carreiras){
        Console.WriteLine(c.Title);
          foreach(var el in c.Items.OrderByDescending(x => x.Order)){
            Console.WriteLine($"{el.Order} - {el.Title}");
            Console.WriteLine(el.Course.Title);
          }
      }


      // foreach(var a in articles){
      //   Console.WriteLine(a.Id);
      //   Console.WriteLine(a.Title);
      //   Console.WriteLine(a.Url);
      // }
    }
  }
}