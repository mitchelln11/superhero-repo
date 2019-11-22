using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Controls;

namespace SuperheroCreator.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Super Hero Name")]
        public string superHeroName { get; set; }

        [DisplayName("Alias First Name")]
        public string firstName { get; set; }

        [DisplayName("Alias Last Name")]
        public string lastName { get; set; }

        [DisplayName("Primary Ability")]
        public string primaryAbility { get; set;  }

        [DisplayName("Secondary Ability")]
        public string secondaryAbility { get; set; }

        [DisplayName("Catch Phrase")]
        public string catchPhrase { get; set; }

        public string heroImage { get; set; }
    }
}