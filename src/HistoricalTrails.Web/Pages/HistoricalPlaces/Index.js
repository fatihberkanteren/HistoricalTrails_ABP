$(function () {
    var l = abp.localization.getResource('HistoricalTrails');
    var createModal = new abp.ModalManager(abp.appPath + 'HistoricalPlaces/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'HistoricalPlaces/EditModal');

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
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('HistoricalTrails.HistoricalPlaces.Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l('HistoricalPlaceDeletionConfirmationMessage', data.record.name);
                                    },
                                    visible: abp.auth.isGranted('HistoricalTrails.HistoricalPlaces.Delete'),
                                    action: function (data) {
                                        historicalTrails.historicalPlaces.historicalPlace
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('SuccessfullyDeleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
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
    var createModal = new abp.ModalManager(abp.appPath + 'HistoricalPlaces/CreateModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewHistoricalPlaceButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

});
