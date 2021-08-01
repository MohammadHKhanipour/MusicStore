using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Business.Interfaces
{
    public interface IDomainBusiness<Dto> where Dto : BaseDto
    {
    }
}
