$(document).ready(function () {
    //where we put our code
    $('.button').on('click', function () {
        var id = $(this).data('id');
        var add = $(this);
        $.post('/Cart/Index' + id, function (data) {
        });
    });
    $('.thumbnail').on('click', function () {
        var src = $(this).attr('src');
        $('.productImg').attr('src', src);
        });
});

