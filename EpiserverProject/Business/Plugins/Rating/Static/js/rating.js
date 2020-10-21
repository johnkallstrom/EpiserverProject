$(document).ready(function () {
    getRatings();

    $('#delete-all-button').click(function () {
        deleteAll();
    });

    function getRatings() {
        $('#ratings-table > tbody').empty();

        return $.ajax({
            type: 'GET',
            url: '/api/rating/get',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                let output = '';

                if (data === undefined || data.length === 0) {
                    $("#delete-all-button").prop('disabled', true);
                }

                data.forEach(item => {
                    output += `
                            <tr>
                                <th scope="col">${item.Id.StoreId}</th>
                                <td>${item.Grade}</td>
                                <td><a href="#" class="delete-button" data-id="${item.Id.StoreId}">Delete</a></td>
                            </tr>`;
                });

                $('#ratings-table-body').append(output);

                deleteRate();
            },
            error: function () {
                console.log('failed to fetch ratings data.');
            }
        });
    }

    function deleteAll() {
        return $.ajax({
            type: 'POST',
            url: '/api/rating/deleteall',
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function () {
                getRatings();
            },
            error: function () {
                console.log('failed to delete all ratings data.');
            }
        })
    }

    function deleteRate() {
        $('.delete-button').click(function () {
            return $.ajax({
                type: 'POST',
                url: `/api/rating/delete/${$(this).data('id')}`,
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function () {
                    getRatings();
                },
                error: function () {
                    console.log('delete single rating failed.');
                }
            });
        });
    }
});