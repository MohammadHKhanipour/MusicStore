using MusicStore.Business.Interfaces;
using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Business.Classes
{
    public class DomainBusiness<Dto> : IDomainBusiness<Dto> where Dto : BaseDto
    {
    }
}
