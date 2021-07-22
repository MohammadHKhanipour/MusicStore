﻿using MusicStore.Framework;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    public interface IBaseAdapter<Model, Dto> where Model : BaseModel where Dto : BaseDto
    {
        public Model GetModel(Dto dto);
        public Dto GetDto(Model model);
        public IEnumerable<Model> GetModels(List<Dto> dtos);
        public IEnumerable<Dto> GetDtos(List<Model> models);
    }
}
