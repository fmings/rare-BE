// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Reflection.Emit;
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
    PostReactions()
    {
        Id = 1,
        ReactionId = 1,
        UserId = 5,
        PostId = 3,
    },
     PostReactions()
    {
        Id = 2,
        ReactionId = 2,
        UserId = 3,
        PostId = 4,
    },
     PostReactions()
    {
        Id = 3,
        ReactionId = 3,
        UserId = 2,
        PostId = 2,
    },
     PostReactions()
    {
        Id = 4,
        ReactionId = 4,
        UserId = 1,
        PostId = 1,
    },
     PostReactions()
    {
        Id = 5,
        ReactionId = 5,
        UserId = 4,
        PostId = 5,
    },
}