using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal_BusinessLogicLayer.DTOs
{
    public class NewsDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
