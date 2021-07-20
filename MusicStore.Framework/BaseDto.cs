using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Framework
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
