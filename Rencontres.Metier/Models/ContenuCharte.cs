﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMeetUp.Logic.Modeles
{
    [Table("ContenusChartes")]
    public class ContenuCharte:EntityWithDate
    {
        public ContenuCharte()
        {
            Actif = true;
        }
        [StringLength(80)]
        public string Categorie { get; set; }

        public string Contenu { get; set; }

        [DefaultValue(true)]
        public bool Actif { get; set; }

        public int? RencontreId { get; set; }

        public virtual Rencontre Rencontre { get; set; }

        public int Position { get; set; }
    }
}