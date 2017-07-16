"use strict";

$(document).ready(function() {

    //=================Preloader===========//
    $(window).on('load', function () {
        $('.preloader img').fadeOut();
        $('.preloader').fadeOut();
    });
    //=================end of Preloader===========//
    
    /*Background slideshow */

    $('.bg-slider').backstretch([
        "img/pages/lbg-1.jpg", "img/pages/lbg-2.jpg", "img/pages/lbg-3.jpg"
    ], {
        duration: 2500,
        fade: 1050
    });
});
