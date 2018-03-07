function BasketModel() {
    var _self = this;
    this.basketItems = [];

    this.addItem = function (tyreID, description = "") {

        $.ajax({
            url: "Home/AddTyreToBasket",
            type: "post",
            data: { tyreID: tyreID, description: description },
            success: function (response) {
                if (!response.exist) {

                    _self.basketItems.push(tyreID);

                    updateCartCount()

                }
                else {
                    alert("Tyre already added");
                }
            }
        });

    }


    this.getItems = function () {
        $.ajax({
            url: "Home/GetBasketItems",
            type: "get",
            success: function (response) {
                if (response) {
                    _self.basketItems = response;


                }
                updateCartCount();

            }
        });

    }

    this.stergetot = function () {
        $.ajax({
            url: "Home/StergeTot",
            type: "post",
            success: function (response) {
                _self.basketItems = [];
                restartCart(0);

            }
        });

    }

    this.afiseazaCos = function () {
        $.ajax({
            url: "Home/GetBasketHTML",
            type: "get",
            success: function (response) {
                if (response) {
                    $.colorbox({
                        html: response,
                        open: true,
                        iframe: false,
                        height: "80%",
                        width: "80%"


                    });
                    html = response;

                }


            }
        });

    }

    this.adaugaCantitate = function (tyreID) {
        $.ajax({
            url: "Home/AdaugaCantitate",
            type: "post",
            data: { tyreid: tyreID },
            success: function (response) {
                if (response) {
                    $.colorbox.close();
                    $("#afiseaza-cod").click();
                    

                }


            }
        });
    }



}