using Nutrio.Application.DTOs.BodyMetrix;
using Nutrio.Application.Interfaces;
using Nutrio.Domain.Entities;
using Nutrio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nutrio.Application.Services
{
    public class BodyMetrixService : IBodyMetrixService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BodyMetrixService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AddWeightEntryAsync(Guid userId, WeightEntryDto weightDto)
        {
            var entity = new Bodymetrix
            {
                UserId = userId,
                Weight = weightDto.Weight,
                DateOfEntryMetrix = weightDto.Date != default ? weightDto.Date : DateTime.UtcNow
            };

            await _unitOfWork.Bodymetrix.AddAsync(entity);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateGeneralMetricsAsync(Guid userId, UpdateMetricsDto metricsDto)
        {
            var existingMetrics = await _unitOfWork.Bodymetrix.GetLatestByUserIdAsync(userId);

            if (existingMetrics == null)
            {
                // Створюємо новий запис з усіма твоїми новими полями (Waist, Neck, Hip)
                var newMetrics = new Bodymetrix
                {
                    UserId = userId,
                    Weight = metricsDto.Weight,
                    Height = metricsDto.Height ?? 0,
                    Waist = metricsDto.Waist ?? 0,
                    Neck = metricsDto.Neck ?? 0,
                    Hip = metricsDto.Hip ?? 0,
                    DateOfEntryMetrix = DateTime.UtcNow
                };
                await _unitOfWork.Bodymetrix.AddAsync(newMetrics);
            }
            else
            {
                // Оновлюємо існуючі дані
                existingMetrics.Weight = metricsDto.Weight;
                if (metricsDto.Height.HasValue) existingMetrics.Height = metricsDto.Height.Value;
                if (metricsDto.Waist.HasValue) existingMetrics.Waist = metricsDto.Waist.Value;
                if (metricsDto.Neck.HasValue) existingMetrics.Neck = metricsDto.Neck.Value;
                if (metricsDto.Hip.HasValue) existingMetrics.Hip = metricsDto.Hip.Value;

                existingMetrics.DateOfEntryMetrix = DateTime.UtcNow;

                _unitOfWork.Bodymetrix.Update(existingMetrics);
            }

            return await _unitOfWork.SaveChangesAsync() > 0;
        }


        public async Task<OnboardingDataDto> GetCurrentMetricsAsync(Guid userId)
        {
            var metrics = await _unitOfWork.Bodymetrix.GetLatestByUserIdAsync(userId);

            if (metrics == null)
            {
                throw new KeyNotFoundException($"Метрики для користувача з ID {userId} не знайдені.");
            }

            // Map only available fields from Bodymetrix entity to OnboardingDataDto.
            // Some fields from OnboardingDataDto (Age, TargetWeight, Goal, Sex, Activity)
            // are not stored in Bodymetrix entity; set sensible defaults.
            return new OnboardingDataDto
            {
                Weight = metrics.Weight,
                Height = metrics.Height.HasValue ? (int)metrics.Height.Value : 0,
                Age = 0,
                TargetWeight = 0,
                Goal = 0,
                sex = OnboardingDataDto.Sex.man,
                Activity = OnboardingDataDto.ActivityLevel.Level_1
            };
        }

        public async Task<Bodymetrix> GetLatestByUserIdAsync(Guid userId)
        {
            return await _unitOfWork.Bodymetrix.GetLatestByUserIdAsync(userId);
        }

    }


}
