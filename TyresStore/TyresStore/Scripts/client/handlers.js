window.onload = function () {
    mainModel = new MainModel();
   
};



function updateCartNumber(number) {
    $(".cart-button").html("(" + number + ")");
}

function updateBasketHTML(res) {
    $("#cboxContent").find(".table-responsive").html(res);
}

function afiseaza(res) {
    $(".basket").html(res);
}


