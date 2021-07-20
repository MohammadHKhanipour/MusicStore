using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Framework
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        //public string Name { get; set; }
    }
}
