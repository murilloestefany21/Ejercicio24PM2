using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio24PM2.Models
{
    public class VideoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Uri { get; set; }

        public string Descripcion { get; set; }
    }
}
