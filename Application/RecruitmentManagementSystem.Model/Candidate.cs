﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentManagementSystem.Model
{
    public class Candidate : BaseEntity
    {
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string LastName { get; set; }

        [EmailAddress]
        [Index("EmailIndex", IsUnique = true)]
        [StringLength(50, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Email { get; set; }

        [Required]
        [Index("PhoneNumberIndex", IsUnique = true)]
        [StringLength(20, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(3000, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Others { get; set; }

        [Url]
        [StringLength(50, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Website { get; set; }

        public int JobPositionId { get; set; }

        public JobPosition JobPosition { get; set; }

        public ICollection<Education> Educations { get; set; }

        public ICollection<Experience> Experiences { get; set; }

        public ICollection<Skill> Skills { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<File> Files { get; set; }
    }
}