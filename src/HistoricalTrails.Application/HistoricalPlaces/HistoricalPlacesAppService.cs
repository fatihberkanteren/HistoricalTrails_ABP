using HistoricalTrails.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HistoricalTrails.HistoricalPlaces;

public class HistoricalPlacesAppService : CrudAppService<
    HistoricalPlace, //The HistoricalPlace entity
    HistoricalPlaceDto, //Used to show HistoricalPlaces
    Guid, //Primary key of the HistoricalPlace entity
    PagedAndSortedResultRequestDto, //Used for paging/sorting
    CreateUpdateHistoricalPlaceDto>, //Used to create/update a HistoricalPlace
IHistoricalPlacesAppService //implement the IHistoricalPlaceAppService
{
    public HistoricalPlacesAppService(IRepository<HistoricalPlace, Guid> repository) : base(repository)
    {
        GetPolicyName = HistoricalTrailsPermissions.HistoricalPlaces.Default;
        GetListPolicyName = HistoricalTrailsPermissions.HistoricalPlaces.Default;
        CreatePolicyName = HistoricalTrailsPermissions.HistoricalPlaces.Create;
        UpdatePolicyName = HistoricalTrailsPermissions.HistoricalPlaces.Edit;
        DeletePolicyName = HistoricalTrailsPermissions.HistoricalPlaces.Delete;
    }
}

