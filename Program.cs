using EFCoreQueryData.Context;
using EFCoreQueryData.Entitys;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        BlogContext db = new BlogContext();
        // db.Blogs!.Add(new Blog{Title = "EF Core giriş",Url = "Https://www.celilcavus.com"});
        // db.SaveChanges();
        // Console.WriteLine("İşlem başarili");

        // var query = db.Blogs!.FirstOrDefault();
        // System.Console.WriteLine(query);


        // var UpdateBlog = db.Blogs!.SingleOrDefault(x => x.Id == 1);
        // UpdateBlog!.Title = "Güncellendi";

        // var UpdateBlogState = db.Entry(UpdateBlog).State;
        // db.SaveChanges();


        // var UpdateBlog = db.Blogs!.AsNoTracking().SingleOrDefault(x => x.Id == 1);
        // UpdateBlog!.Title = "Güncellendi";

        // var UpdateBlogState = db.Entry(UpdateBlog).State;
        // db.SaveChanges();
        //  System.Console.WriteLine(UpdateBlogState);


        // var blogs = db.Blogs!.Include(x=>x.Comments).ToList();
        // foreach (var item in blogs)
        // {
        //     System.Console.WriteLine(item.Title);
        //     foreach (var item1 in db.Comments!)
        //     {
        //         System.Console.WriteLine(item1.Content);
        //     }
        // }

        // var blog = db.Blogs!.SingleOrDefault(x=>x.Id == 1);

        // db.Entry(blog).Collection(x=>x.Comments).Load();

        // foreach (var item in blog.Comments)
        // {
        //     System.Console.WriteLine(item.Content);
        // }

    }
}