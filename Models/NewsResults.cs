using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{ 
    public class NewsResult
    {
        public string status {get; set;}
        public int totalResults {get; set;}
        public List <Article> articles {get; set;}
    }
    public class Article
    {
        public Source source {get; set;}
        public string author {get; set;}
        public string title {get; set;}
        public string url {get; set;}
        public string urlToImage {get; set;}
        public string content {get; set;}
        public string description {get; set;}

    }
    public class Source
    {
        public string id {get; set;}
        public string name {get; set;}
    }
}
