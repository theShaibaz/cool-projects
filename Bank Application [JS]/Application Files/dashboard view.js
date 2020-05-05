
var dashboardView = (function () {

    var json_object = model.getJsonObject()

    if (json_object.session === '1') {
        model.custLastDepositCard.text(json_object.custLastDeposit)
        model.custBalanceCard.text(json_object.custBalance)
        model.custLastWithdrawCard.text(json_object.custLastWithdraw)
    }
    else {
        window.location.replace('index.html')
    }

})()
