$(document).ready(function () {
    $('.rating-submitted').hide();

    $('.rating').click(function () {
        var rate = { newsId: $(this).data('id'), grade: $(this).data('rating') };

        return $.ajax({
            type: 'POST',
            url: '/api/rating/save',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify(rate),
            dataType: 'json',
            success: () => {
                $(".rating").prop('disabled', true);
                $('.rating-submitted').show();
            },
            error: () => {
                console.log('something went wrong.');
            }
        })
    })

    $('.success-text').click(function () {
        $(this).slideUp();
    });

});