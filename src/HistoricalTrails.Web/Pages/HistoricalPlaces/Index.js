$(function () {
    var l = abp.localization.getResource('HistoricalTrails');

    var dataTable = $('#HistorcalPlacesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(historicalTrails.historicalPlaces.historicalPlace.getList),
            columnDefs: [
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Tarihi'),
                    data: "history"
                },
                {
                    title: l('Image Url'),
                    data: "imageUrl"
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                },
                {
                    title: l('Açıklama'),
                    data: "description"
                },
            ]
        })
    );
});
