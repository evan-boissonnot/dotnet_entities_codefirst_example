﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestEntitiesAvecBaseExistante.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Propriétés
        /// <summary>
        /// Id venant de la base
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numéro à afficher pour le jeu
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// C'est le titre du paragraphe
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        public string Description { get; set; }
        #endregion
    }
}
