using AutoMapper;
using BLL.AbstractServices;
using BLL.Dtos;
using DAL.AbstractRepositories;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ConcreteServices
{
    public class ExtraItemService : IExtraItemService
    {
        private readonly IRepository<ExtraItem> _extraItemRepository;
        private readonly IMapper _mapper;

        public ExtraItemService(IRepository<ExtraItem> extraItemRepository, IMapper mapper)
        {
            _extraItemRepository = extraItemRepository;
            _mapper = mapper;
        }
        public async Task<ExtraItemDto> AddExtraItem(ExtraItemDto extraItemDto)
        {
            var extraItem = _mapper.Map<ExtraItem>(extraItemDto);
            await _extraItemRepository.AddAsync(extraItem);
            await _extraItemRepository.SaveChangesAsync();

            // Eklenen ExtraItem'ı geri döndür
            return _mapper.Map<ExtraItemDto>(extraItem);
        }



        public async Task DeleteExtraItem(int extraItemId)
        {
            if (extraItemId != null)
                await _extraItemRepository.DeleteAsync(extraItemId);
        }

        public async Task<List<ExtraItemDto>> GetAllExtraItems()
        {
            var extraItems = await _extraItemRepository.GetAllAsync();
            return _mapper.Map<List<ExtraItemDto>>(extraItems);
        }

        public async Task<List<ExtraItemDto>> GetAllExtraItemsWithIncludes()
        {
            var extraItems = await _extraItemRepository.GetAllWithIncludes(x => x.MenuDetails).ToListAsync();
            return _mapper.Map<List<ExtraItemDto>>(extraItems);
        }

        public async Task RemoveExtraItem(int extraItemId)
        {
            if (extraItemId != null)
                await _extraItemRepository.RemoveAsync(extraItemId);
        }

        public async Task UpdateExtraItem(int extraItemId, ExtraItemDto extraItemDto)
        {
            var findedExtraItem = await _extraItemRepository.GetByIdAsync(extraItemId);

            findedExtraItem.Name = extraItemDto.Name;
            findedExtraItem.AdditionalPrice = extraItemDto.AdditionalPrice;

            await _extraItemRepository.UpdateAsync(findedExtraItem);
        }
    }
}
