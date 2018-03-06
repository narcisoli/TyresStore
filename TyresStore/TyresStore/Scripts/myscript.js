
$(window).on('scroll', function () {
    if (!$(window).scrollTop()) {
        $('nav').removeClass('white');
        $('nav').addClass('black');
    }
    else {
        $('nav').addClass('white');
        $('nav').removeClass('black');
       
    }
})