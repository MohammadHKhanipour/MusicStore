using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class WalletAdapter : IBaseAdapter<Wallet, WalletDto>
    {
        public WalletDto GetDto(Wallet model)
        {
            if (model == null)
                return null;
            return new WalletDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Total = model.Total,
                ApplicationUserId = model.ApplicationUserId
            };
        }

        public IEnumerable<WalletDto> GetDtos(List<Wallet> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Wallet GetModel(WalletDto dto)
        {
            if (dto == null)
                return null;
            return new Wallet()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Total = dto.Total,
                ApplicationUserId = dto.ApplicationUserId
            };
        }

        public IEnumerable<Wallet> GetModels(List<WalletDto> dtos)
        {
            foreach (var item in dtos)
            {
                if (item == null)
                    continue;
                yield return GetModel(item);
            }
        }
    }
}
