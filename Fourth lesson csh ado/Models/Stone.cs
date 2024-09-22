using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_lesson_csh_ado.Models
{
    public class Stone
    {
        public string _Name { get; set; }
        public Color _Color { get; set; }
        public bool IsTransparent { get; set; }
        public EnumType Type { get; set; }
        public string Description { get; set; }
    }
}