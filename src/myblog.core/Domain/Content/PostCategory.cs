﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myblog.core.Domain.Content
{
    [Table("PostCategories")]
    [Index(nameof(Slug), IsUnique = true)]
    public class PostCategory
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(250)]
        public required string Name { set; get; }

        [Column(TypeName = "varchar(250)")]
        public required string Slug { set; get; }

        public Guid? ParentId { set; get; }
        public bool IsActive { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime? DateModified { set; get; }

        [MaxLength(160)]
        public string? SeoDescription { set; get; }
        public int SortOrder { set; get; }
    }
}
