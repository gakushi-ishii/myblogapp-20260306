using Microsoft.AspNetCore.Mvc;
using MyBlogApp.Models;

namespace MyBlogApp.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        var posts = BlogRepository.GetAll();
        return View(posts);
    }

    public IActionResult Detail(int id)
    {
        var post = BlogRepository.GetById(id);
        if (post == null) return NotFound();
        return View(post);
    }
}
