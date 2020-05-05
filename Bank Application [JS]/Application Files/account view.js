
var accountView = (function () {

    var json_object = model.getJsonObject()

    if (json_object.session === '1') {
        model.custCrnCard.text(json_object.custCrn)
        model.custAccCard.text(json_object.custAcc)
        model.custNameCard.text(json_object.custName)
    }
    else {
        window.location.replace('index.html')
    }
})()
