﻿using System.Text.Json.Serialization;
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

List<Users> users = new List<Users>()
{
    new Users()
    {
        Id = 1,
        FirstName = "Britnay",
        LastName = "Gore",
        Email = "britnayg@gmail.com",
        Bio = "The Island Gyal",
        Username = "brit268",
        Password = "Glue2Yu",
        CreatedOn = new DateTime(2022, 10, 6),
    },
    new Users()
    {
        Id = 2,
        FirstName = "Felicia",
        LastName = "Mings",
        Email = "feliciam@gmail.com",
        Bio = "Team Vibes",
        Username = "felicia808",
        Password = "CatB3dPoop",
        CreatedOn = new DateTime(2023, 5, 9),
    },
    new Users()
    {
        Id = 3,
        FirstName = "Fletcher",
        LastName = "Moore",
        Email = "fletcherm@gmail.com",
        Bio = "The Young Manager",
        Username = "fletch777",
        Password = "Sl1ckRic",
        CreatedOn = new DateTime(2023, 12, 12),
    },
    new Users()
    {
        Id = 4,
        FirstName = "Zach",
        LastName = "Colbrn",
        Email = "zachm@gmail.com",
        Bio = "The Alcohol King",
        Username = "zach329",
        Password = "Teki11ya",
        CreatedOn = new DateTime(2022, 1, 30),
    },
    new Users()
    {
        Id = 5,
        FirstName = "Odi",
        LastName = "Joseph",
        Email = "odij@gmail.com",
        Bio = "Backend Genius",
        Username = "odi904",
        Password = "Fr0King",
        CreatedOn = new DateTime(2024, 4, 13),
    },
};

List<Subscriptions> subscriptions = new List<Subscriptions>()
{
    new Subscriptions()
    {
        Id = 1,
        FollowerId = 5,
        AuthorId = 3,
        CreatedOn = new DateTime(2023, 11, 22),
    },
    new Subscriptions()
    {
        Id = 2,
        FollowerId = 4,
        AuthorId = 1,
        CreatedOn = new DateTime(2022, 9, 16),
    },
    new Subscriptions()
    {
        Id = 3,
        FollowerId = 2,
        AuthorId = 4,
        CreatedOn = new DateTime(2024, 1, 30),
    },
    new Subscriptions()
    {
        Id = 4,
        FollowerId = 1,
        AuthorId = 2,
        CreatedOn = new DateTime(2022, 5, 5),
    },
    new Subscriptions()
    {
        Id = 5,
        FollowerId = 3,
        AuthorId = 5,
        CreatedOn = new DateTime(2024, 7, 16),
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

List<Reactions> reactions = new List<Reactions>()
{
    new Reactions()
    {
        Id = 1,
        Emoji = true
    },
    new Reactions()
    {
        Id = 2,
        Emoji = false
    },
    new Reactions()
    {
        Id = 3,
        Emoji = true
    },
    new Reactions()
    {
        Id = 4,
        Emoji = false
    },
    new Reactions()
    {
        Id = 5,
        Emoji = true
    },
};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3000", "http://localhost:5003")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});


builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();
app.UseCors();

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
    posts.ForEach(p => p.User = users.FirstOrDefault(u => u.Id == p.UserId));
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
app.MapGet("/posts/{id}", (int id) =>
{
    Posts post = posts.FirstOrDefault(p => p.Id == id);
    post.Category = categories.FirstOrDefault(c => c.Id == post.CategoryId);
    post.User = users.FirstOrDefault(u => u.Id == post.UserId);

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

// GET Posts by Author/User
app.MapGet("/users/{id}/posts/{postId}", (int id, int postId) =>
{
    Users? userId = users.FirstOrDefault(p => p.Id == id);

    List<Posts> usersPost = posts.Where(p => p.UserId == userId?.Id && p.Id == postId).ToList();

    usersPost.ForEach(uP => uP.Category = categories.FirstOrDefault(c => c.Id == uP.CategoryId));

    // Error handling for if the either the id or postId is 0 or null and if id or postId doesn't exist
    if (postId == 0 || id == 0 || id != userId?.Id || !posts.Any(p => p.Id == postId))
    {
        return id != userId?.Id ? Results.BadRequest() : Results.NotFound();
    }

    return Results.Ok(usersPost);
});

// GET Subscriptions
app.MapGet("/subscriptions", () =>
{
    return subscriptions;
});

// POST Subscriptions
app.MapPost("/subscriptions", (Subscriptions subscription) =>
{
    if (subscription.FollowerId == subscription.AuthorId)
        return Results.BadRequest("You cannnot subscribe to yourself");

    if (!users.Any(u => u.Id == subscription.AuthorId) || !users.Any(u => u.Id == subscription.FollowerId))
        return Results.BadRequest("One or both users do not exist");

    subscription.Id = subscriptions.Max(st => st.Id) + 1;
    subscription.CreatedOn = DateTime.Today;
    subscriptions.Add(subscription);
    return Results.Ok(subscription);
});

// DELETE Subscriptions
app.MapDelete("/subscriptions/{id}", (int id) =>
{
    Subscriptions subscriptionId = subscriptions.FirstOrDefault(s => s.Id == id);
    subscriptions.Remove(subscriptionId);
});

// Post PostReactions
app.MapPost("/postreactions", (PostReactions postReaction) =>
{
    postReaction.Id = postReactions.Max(st => st.Id) + 1;
    postReactions.Add(postReaction);
    return postReaction;
});

// GET ALL COMMENTS FOR A SPECIFIC USER POST
app.MapGet("/post/{id}/comments", (int id) =>
{
    List<Comments> postComments = comments.Where(c => c.PostId == id).ToList();
    return postComments;

});

// POST A COMMENT ON A SPECIFIC POST
app.MapPost("/post/{id}/comments", (int id, Comments newComment) =>
{
    newComment.Id = comments.Max(c => c.Id) + 1;
    comments.Add(newComment);
    return newComment;
});


// EDIT/UPDATE A COMMENT ON A POST
app.MapPatch("/post/{postId}/comment/{commentId}", (int commentId, Comments updatedComment) =>
{
    Comments commentToUpdate = comments.FirstOrDefault(c => c.Id == commentId);
    if (commentToUpdate == null)
    {
        return Results.NotFound();
    }

    commentToUpdate.Content = updatedComment.Content;

    return Results.Ok(commentToUpdate);

});

// DELETE A COMMENT ON A POST
app.MapDelete("/post/{postId}/comment/{commentId}", (int postId, int commentId) =>
{
    Comments comment = comments.FirstOrDefault(c => c.Id == commentId);
    comments.Remove(comment);
    return Results.NoContent();
});


// CREATE(POST) A NEW CATEGORY
app.MapPost("/categories", (Categories newCategory) =>
{
    newCategory.Id = categories.Max(c => c.Id) + 1;
    categories.Add(newCategory);
    return newCategory;
});

// GET ALL CATEGORIES
app.MapGet("/categories", () =>
{
    return categories;
});

// Post Reactions
app.MapPost("/reactions", (Reactions reaction) =>
{
   reaction.Id = reactions.Max(pr => pr.Id) + 1;
   reactions.Add(reaction);
    return reaction;
});

// Post Users
 app.MapPost("/users", (Users user) =>
 {
    user.Id = users.Max(u => u.Id) + 1;
    user.CreatedOn = DateTime.Today;
    users.Add(user);
    return user;
});

//Delete Post Reactions
 app.MapDelete("/postreactions/{id}", (int id) =>
 {
    PostReactions? postReaction = postReactions.FirstOrDefault(pr => pr.Id == id);
    int index = postReactions.IndexOf(postReaction);
    postReactions.RemoveAt(index);
 });

// DELETE PostTags by Id
app.MapDelete("/posttags/{id}", (int id) =>
{
    var postTag = postTags.FirstOrDefault(pt => pt.Id == id);
    if (postTag == null)
    {
        return Results.NotFound();
    }
    postTags.Remove(postTag);
    return Results.NoContent();
});

// POST Post Tags 
app.MapPost("/posttags", (PostTags postTag) =>
{
    if (postTag == null)
    {
        return Results.BadRequest("Invalid PostTag object");
    }
    postTag.Id = tags.Max(t => t.Id) + 1;
    postTags.Add(postTag);
    return Results.Created($"/posttags/{postTag.Id}", postTag);
});

// GET ALl Tags
app.MapGet("/tags", () =>
{
    return tags;
});

// GET ALL TAGS FOR A SPECIFIC USER POST
app.MapGet("/post/{id}/tag", (int id) =>
{
    List<PostTags> tagsOfPost = postTags.Where(t => t.PostId == id).ToList();
    return tagsOfPost;

});

// POST Tags
app.MapPost("/tags", (Tags newTag) =>
{
    newTag.Id = tags.Max(t => t.Id) + 1;
    tags.Add(newTag);
    return Results.Created($"/tags/{newTag.Id}", newTag);
});

//DELETE Post
app.MapDelete("/posts/{id}", (int id) =>
{
    var postToRemove = posts.FirstOrDefault(p => p.Id == id);
    if (postToRemove == null)
    {
        return Results.NotFound();
    }

    posts.Remove(postToRemove); 
    return Results.NoContent(); 
});

// POST Post
app.MapPost("/posts", (Posts newPost) =>
{
    newPost.Id = posts.Max(post => post.Id) + 1;
    posts.Add(newPost);
    return newPost;
});

// Get User By Id (Single User) 
app.MapGet("/users/{id}", (int id) =>
{
    var user = users.FirstOrDefault(u => u.Id == id);
    if (user == null)
    {
        return Results.NotFound($"User with ID {id} not found.");
    }
    return Results.Ok(user);
});

// GET All Users
app.MapGet("/users", () =>
{
    return Results.Ok(users);
});

app.Run();