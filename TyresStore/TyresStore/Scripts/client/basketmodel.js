function BasketModel() {
    var _self = this;
    this.basketItems = [];

    this.addItem = function (tyreID, description = "") {

        $.ajax({
            url: "Home/AddTyreToBasket",
            type: "post",
            data: { tyreID: tyreID, description: description },
            success: function (response) {
                _self.getItems();
            }
        });

    }


    this.getItems = function () {
        $.ajax({
            url: "Home/GetBasketItems",
            type: "get",
            success: function (response) {
                if (response) {
                    updateCartNumber(parseInt(response));

                }
                

            }
        });

    }
    

    this.stergetot = function () {
        $.ajax({
            url: "Home/StergeTot",
            type: "post",
            success: function (response) {
                _self.getItems();

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
                   

                }


            }
        });

    }

    this.adaugaCantitate = function (tyreID) {
        $.ajax({
            url: "Home/AdaugaCantitate",
            type: "get",
            data: { tyreid: tyreID },
            success: function (response) {
                if (response) {
                    updateBasketHTML(response);
                    _self.getItems();
                }


            }
        });
    }

    this.stergeCantitate = function (tyreID) {
        $.ajax({
            url: "Home/StergeCantitate",
            type: "get",
            data: { tyreid: tyreID },
            success: function (response) {
                if (response) {
                   
                    updateBasketHTML(response);
                    _self.getItems();
                }


            }
        });
    }

    



}