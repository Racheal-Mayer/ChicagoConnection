using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    
    namespace project.Models
    {
        public class Comment
        {
            [Key]
            public int CommentId {get; set;}
            public string Comments {get; set;}
            public int MessageId {get; set;}
            public Message Maker {get; set;}
            public int UserId {get; set;}
            public User Writer {get;set;}
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

        }
    }