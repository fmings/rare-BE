﻿using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using rare_BE.Models;

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

// Where APIs should begin
app.MapGet("/test", () =>
{
    return "sugar";
});

app.Run();
