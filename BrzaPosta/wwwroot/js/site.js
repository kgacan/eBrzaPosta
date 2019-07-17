// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function DodajAjaxEvente() {

    $("button[ajax-poziv='da']").click(function () {

        var btn = $(this);
        btn.attr("ajax-poziv", "dodan");
        event.preventDefault();
        var url = btn.attr("ajax-url");
        //var url2 = btn.attr("href");
        var rez = btn.attr("ajax-rez");

        //var url;
        //if (url1 instanceof String)
        //    url = url1;
        //else
        //    url = url2;

        $.get(url,function (rezultat) {
                $("#" + rez).html(rezultat);
            }
        )
    });

    $("a[ajax-poziv='da']").click(function () {

        event.preventDefault();

        var btn = $(this);
        btn.attr("ajax-poziv", "dodan");
        var url1 = btn.attr("ajax-url");
        //var url2 = btn.attr("href");
        var rez = btn.attr("ajax-rez");

        //var url;
        //if (url1 instanceof String)
        //    url = url1;
        //else
        //    url = url2;

        $.get(url, function (rezultat) {
            $("#" + rez).html(rezultat);
        }
        )
    });

    $("form[ajax-poziv='da']").submit(function () {

        event.preventDefault();

        var forma = $(this);
        forma.attr("ajax-poziv", "dodan");
        var url1 = forma.attr("ajax-url");
        var url2 = forma.attr("action");
        var rez = forma.attr("ajax-rez");

        var url;

        if (url1 instanceof String)
            url = url1;
        else
            url = url2;

        $.ajax({
            async: true,
            type: "POST",
            url: url,
            data: forma.serialize(),
            success: function (rezultat) {
                $("#" + rez).html(rezultat);
            }
        });
    });
}

$(document).ready(function () {

    DodajAjaxEvente();

    window.setTimeout(function () {
        $("#porukaBox").fadeTo(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 4000);

});

$(document).ajaxComplete(function () {

    DodajAjaxEvente();

});


//function DodajAjaxEvente() {

//    $("button[ajax-poziv='da']").click(function () {

//        var btn = $(this);
//        var url = btn.attr("ajax-url");
//        var rez = btn.attr("ajax-rez");

//        $.get(url,
//            function (rezultat) {
//                $("#" + rez).html(rezultat);
//            }
//        )
//    });

//    $("form[ajax-poziv='da']").submit(function () {

//        event.preventDefault();

//        var forma = $(this);
//        var url = forma.attr("action");
//        var rez = forma.attr("ajax-rez");

//        $.ajax({
//            async: true,
//            type: "POST",
//            url: url,
//            data: forma.serialize(),
//            success: function (rezultat) {
//                $("#" + rez).html(rezultat);
//            }
//        });
//    });
//}

//$(document).ready(function () {

//    DodajAjaxEvente();

//    window.setTimeout(function () {
//        $("#porukaBox").fadeTo(500, 0).slideUp(500, function () {
//            $(this).remove();
//        });
//    }, 4000);

//});

//$(document).ajaxComplete(function () {

//    DodajAjaxEvente();

//});



