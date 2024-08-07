// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Reflection.Emit;
using rare_BE.Models;

List<Tags> tags = new List<Tags>
{
    {
        Id = 1,
        Label = "#photooftheday"
    },
    {
        Id = 2,
        Label = "#likeforlike"
    },
    {
        Id = 3,
        Label = "#food"
    },
    {
        Id = 4,
        Label = "#music"
    },
    {
        Id = 5,
        Label = "#amazing"
    },
};

List<Categories> categories = new List<Categories>
{
    {
        Id = 1,
        Label = "Comedy"
    },
    {
        Id = 2,
        Label = "Shopping"
    },
    {
        Id = 3,
        Label = "Music"
    },
    {
        Id = 4,
        Label = "Sports"
    },
    {
        Id = 5,
        Label = "Motivational"
    },
};

List<PostReactions> postReactions = new List<PostReactions>
{
    {
        Id = 1,
        ReactionId = 1,
        UserId = 5,
        PostId = 3,
    },
    {
        Id = 2,
        ReactionId = 2,
        UserId = 3,
        PostId = 4,
    },
    {
        Id = 3,
        ReactionId = 3,
        UserId = 2,
        PostId = 2,
    },
    {
        Id = 4,
        ReactionId = 4,
        UserId = 1,
        PostId = 1,
    },
    {
        Id = 5,
        ReactionId = 5,
        UserId = 4,
        PostId = 5,
    },
}