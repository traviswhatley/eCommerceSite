$(document).ready(function () {
    //swapping thumbnail images
    $('.thumbnail').on('click', function () {
        var src = $(this).attr('src');
        $('.productImg').attr('src', src);
    });

    //add to cart
    $('.cart form').on('submit', function (event) {
        event.preventDefault();
        $.post('/Cart/Add/', $(this).serialize(), function (data) {
            $('.MiniCart').html(data);
        });
    });
});

