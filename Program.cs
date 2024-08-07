using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using rare_BE.Models;

List<Tags> tags = new List<Tags>
{
new Tags()
    {
        Id = 1,
        Label = "#photooftheday"
    },
new Tags()
{
        Id = 2,
        Label = "#likeforlike"
    },
new Tags()
{
        Id = 3,
        Label = "#food"
    },
new Tags()
{
        Id = 4,
        Label = "#music"
    },
new Tags()
{
        Id = 5,
        Label = "#amazing"
    },
};

List<Categories> categories = new List<Categories>
{
new Categories()
    {
        Id = 1,
        Label = "Comedy"
    },
new Categories()
{
        Id = 2,
        Label = "Shopping"
    },
new Categories()
{
        Id = 3,
        Label = "Music"
    },
new Categories()
{
        Id = 4,
        Label = "Sports"
    },
new Categories()
{
        Id = 5,
        Label = "Motivational"
    },
};

List<PostReactions> postReactions = new List<PostReactions>
{
new PostReactions()
    {
        Id = 1,
        ReactionId = 1,
        UserId = 5,
        PostId = 3,
    },
new PostReactions()
    {
        Id = 2,
        ReactionId = 2,
        UserId = 3,
        PostId = 4,
    },
new PostReactions()
    {
        Id = 3,
        ReactionId = 3,
        UserId = 2,
        PostId = 2,
    },
new PostReactions()
    {
        Id = 4,
        ReactionId = 4,
        UserId = 1,
        PostId = 1,
    },
new PostReactions()
    {
        Id = 5,
        ReactionId = 5,
        UserId = 4,
        PostId = 5,
    },
};

List<Posts> posts = new List<Posts>()
{
    new Posts()
    {
        Id = 1,
        UserId = 1,
        CategoryId = 1,
        Title = "Hello World",
        PublicationDate = new DateTime(2024, 7, 19),
        ImageUrl = "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w",
        Content = "Hello World, how are you today?",
        Approved = true
    },
    new Posts()
    {
        Id = 2,
        UserId = 2,
        CategoryId = 2,
        Title = "Hello Zach",
        PublicationDate = new DateTime(2024, 8, 5),
        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Zach_Galifianakis_2012_%28cropped%29.jpg",
        Content = "Hello Zach, doing well?",
        Approved = false
    },
    new Posts()
    {
        Id = 3,
        UserId = 3,
        CategoryId = 3,
        Title = "Hello Brit",
        PublicationDate = new DateTime(2024, 6, 23),
        ImageUrl = "https://www.rollingstone.com/wp-content/uploads/2022/02/AdeleBritsRedCarpet-1.jpeg",
        Content = "Hello Brit, how's work?",
        Approved = true
    },
    new Posts()
    {
        Id = 4,
        UserId = 4,
        CategoryId = 4,
        Title = "Hello Fletcher",
        PublicationDate = new DateTime(2024, 1, 1),
        ImageUrl = "https://www.denofgeek.com/wp-content/uploads/2020/08/chevy-chase-fletch-universal-pictures.jpg?fit=1200%2C680",
        Content = "Hello Fletcher, you are turning 21 this year!",
        Approved = true
    },
    new Posts()
    {
        Id = 5,
        UserId = 5,
        CategoryId = 5,
        Title = "Hello Lola",
        PublicationDate = new DateTime(2024, 6, 30),
        ImageUrl = "https://i.imgur.com/bS6aYJ5.jpg",
        Content = "Hello Lola, stop pooping on the bed",
        Approved = false
    },
    new Posts()
    {
        Id = 6,
        UserId = 1,
        CategoryId = 1,
        Title = "Hello World 2",
        PublicationDate = new DateTime(2024, 8, 3),
        ImageUrl = "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w",
        Content = "Hello World2, how are you today?",
        Approved = true
    },
};


List<Comments> comments = new List<Comments>()
{
    new Comments()
    {
        Id = 1,
        AuthorId = 2,
        PostId = 1,
        Content = "Oh hi!",
    },
    new Comments()
    {
        Id = 2,
        AuthorId = 3,
        PostId = 5,
        Content = "You shouldn't do that, Lola...",
    },
    new Comments()
    {
        Id = 3,
        AuthorId = 4,
        PostId = 4,
        Content = "21!!!!!!!!!!!!! Cheers!",
    }
};

List<PostTags> postTags = new List<PostTags>()
{
    new PostTags()
    {
        Id = 1,
        PostId = 1,
        TagId = 2
    },
     new PostTags()
    {
        Id = 2,
        PostId = 2,
        TagId = 3
    },
      new PostTags()
    {
        Id = 3,
        PostId = 3,
        TagId = 4
    },
       new PostTags()
    {
        Id = 4,
        PostId = 4,
        TagId = 5
    },
        new PostTags()
    {
        Id = 5,
        PostId = 4,
        TagId = 1
    }
};
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// GET All Posts
app.MapGet("/posts", () =>
{
    posts.ForEach(p => p.Category = categories.FirstOrDefault(c => c.Id == p.CategoryId));
    // posts.ForEach(p => p.User = users.FirstOrDefault(u => u.Id == p.CategoryId));
    return posts;
});

// PUT Post
app.MapPut("/posts/{id}", (int id, Posts post) =>
{
    Posts postToUpdate = posts.FirstOrDefault(p => p.Id == id);

    int postIndex = posts.IndexOf(postToUpdate);
    if (postToUpdate == null || id != post.Id)
    {
        // If the id is not the id in post data, it returns bad request (400) but if it could not find an post with the id given, it returns not found (404)
        return id != post.Id ? Results.BadRequest() : Results.NotFound();
    }
    posts[postIndex] = post;
    return Results.Ok();
});

// GET Post Details
app.MapGet("/users/{id}/", (int id) =>
{
    Posts post = posts.FirstOrDefault(p => p.Id == id);
    post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
    //post.User = users.FirstOrDefault(u => u.Id == post.UserId);

    return post == null ? Results.NotFound() : Results.Ok(post);
});

// GET Posts by Category
app.MapGet("/categories/{id}/posts", (int id) =>
{
    Categories? categoriesId = categories.FirstOrDefault(c => c.Id == id);

    List<Posts> categoryPosts = posts.Where(p => p.CategoryId == categoriesId?.Id).ToList();

    if (categoriesId == null || categoriesId?.Id == null || id != categoriesId.Id)
    {
        return id != categoriesId?.Id ? Results.BadRequest() : Results.NotFound();
    }
    return Results.Ok(categoryPosts);

});

app.Run();
