window.onload = function () {
    mainModel = new MainModel();
   
};

function updateCartCount() {
    $(".cart-button").html("(" + basketModel.basketItems.length + ")");
}

function restartCart(number) {
    $(".cart-button").html("(" + number + ")");
}

function updateBasketHTML(res) {
    
}

function afiseaza(res) {
    $(".basket").html(res);
}


