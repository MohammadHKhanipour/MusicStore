using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class BillAdapter : IBaseAdapter<Bill, BillDto>
    {
        public BillDto GetDto(Bill model)
        {
            if (model == null)
                return null;
            return new BillDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                IssueDate = model.IssueDate,
                Amount = model.Amount,
                PaymentState = model.PaymentState,
                PaymentNumber = model.PaymentNumber,
                WalletId = model.WalletId
            };
        }

        public IEnumerable<BillDto> GetDtos(List<Bill> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Bill GetModel(BillDto dto)
        {
            if (dto == null)
                return null;
            return new Bill()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                IssueDate = dto.IssueDate,
                Amount = dto.Amount,
                PaymentState = dto.PaymentState,
                PaymentNumber = dto.PaymentNumber,
                WalletId = dto.WalletId
            };
        }

        public IEnumerable<Bill> GetModels(List<BillDto> dtos)
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
