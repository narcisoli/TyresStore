var mainModel = null;
var basketModel = null;
function MainModel() {
    
    var _self = this;
    this.showLoadingTyres = false;
    basketModel = new BasketModel();
    basketModel.getItems();
    

    this.updateBuket = function (tyreID) {
        $.ajax({
            type: "get",
            url: "Home/updateBucket",
            data: { tyreId: tyreID },
            success: function (response) { updateBucket(response); },
            error: function () { alert('A error'); }
        });
    }

    this.loadTyres = function (vehicleID) {
        
        $.ajax({
            type: "get",
            url: "Home/getTyres",
            data: { vecID: vehicleID },
            success: function (response) { display(response); },
            error: function () { alert('A error'); }
        });

    }
    function updateBucket(response) {
        $(".bucket").html(response);
    }

    function display(response) {
        $(".das").html(response);
       
    }
}