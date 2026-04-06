using Nutrio.Application.DTOs.BodyMetrix;
using Nutrio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Nutrio.Application.Interfaces
{
    public interface IBodyMetrixService
    {
        Task<OnboardingDataDto > GetCurrentMetricsAsync(Guid userId);

        Task<bool> AddWeightEntryAsync(Guid userId, WeightEntryDto weightDto);

        Task<bool> UpdateGeneralMetricsAsync(Guid userId, UpdateMetricsDto metricsDto);

        Task<Bodymetrix> GetLatestByUserIdAsync(Guid userId);

    }
}
