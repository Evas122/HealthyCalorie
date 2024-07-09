using HealthyCalorie.ConsumptionTracking.CrossCutting.Dtos;

namespace HealthyCalorie.ConsumptionTracking.Api.Extensions
{
    public static class ConsumptionDtoExtension
    {
        public static Storage.Entities.Consumption ToEntity(this ConsumptionDto dto)
        {
            return new Storage.Entities.Consumption
            {
                Id = dto.Id,
                FdcId = dto.FdcId,
                UserFoodId = dto.UserFoodId,
                Quantity = dto.Quantity,
                Unit = dto.Unit,
                Date = dto.Date
            };
        }
    }
}
