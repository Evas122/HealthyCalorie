using HealthyCalorie.ConsumptionTracking.CrossCutting.Dtos;

namespace HealthyCalorie.ConsumptionTracking.Api.Extensions
{
    public static class ConsumptionExtension
    {
        public static ConsumptionDto ToDto(this Storage.Entities.Consumption entity)
        {
            return new ConsumptionDto
            {
                Id = entity.Id,
                FdcId = entity.FdcId,
                UserFoodId = entity.UserFoodId,
                Quantity = entity.Quantity,
                Unit = entity.Unit,
                Date = entity.Date
            };
        }
    }
}
