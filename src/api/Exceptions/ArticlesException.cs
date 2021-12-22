using System;

namespace Geekiam.Posts.Service.Exceptions;

public class ArticlesException : Exception
{
    public ArticlesException(string title, string message) : base(message) => Title = title;
    public string Title { get; set; }
}