﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public String Title { get; set; }
        [Required]
        [MaxLength(2048)]
        public String Description { get; set; }
        [Required]
        [MaxLength(1024)]
        public String Url { get; set; }
        [Required]
        [MaxLength(1024)]
        public String ImageUrl { get; set; }
        [AllowHtml]
        public String HTML { get; set; }
        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }
        public string HTMLShort { get { return HTML == null || HTML.Length < 50 ? HTML : HTML.Substring(0, 50); } }
        public int ItemTyped { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }
        [DisplayName("Is Free")]
        public bool IsFree { get; set; }
        [DisplayName("Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}