
var controller = (function () {

    var json_object = model.getJsonObject()

    if (json_object.session === '1') {
        var proceedTrans = model.proceedTrans
        var transType = model.transType
        var transMode = model.transMode
        var transAmount = model.transAmount

        proceedTrans.click(() => {

            var json_object = model.getJsonObject()

            if (transType.val() === '' || transMode.val() === '' || transAmount.val().trim() === '') {
                console.error('validation error')
                error(`Please enter transaction details`, `Insufficient Details`)
            }
            else if (transAmount.val().search('0[0-9]*') === 0 || Number.isNaN(Number(transAmount.val()))) {
                console.error('amount error')
                error(`Please enter amount in proper format`, `Invalid Amount`)
            }
            else {

                switch (transType.val()) {

                    case 'Deposit':

                        json_object.custBalance = (parseInt(json_object.custBalance) + parseInt(transAmount.val())) + ""
                        json_object.custLastDeposit = transAmount.val()

                        if (json_object.statement.length !== 0) {
                            let transId = Number(json_object.statement.substring(0, json_object.statement.indexOf(',')))
                            json_object.statement = `${++transId},${transType.val()},${transMode.val()},${transAmount.val()};` + json_object.statement
                        }
                        else {
                            json_object.statement = `1,${transType.val()},${transMode.val()},${transAmount.val()}`
                        }

                        model.updateJsonObject(json_object)

                        success(`Amount depositted \n Current balance is ${model.getJsonObject().custBalance}`, `Transaction Successful`)

                        break

                    case 'Withdraw':

                        if (parseInt(transAmount.val()) <= parseInt(json_object.custBalance)) {
                            json_object.custBalance = (parseInt(json_object.custBalance) - parseInt(transAmount.val())) + ""
                            json_object.custLastWithdraw = transAmount.val()

                            if (json_object.statement.length !== 0) {
                                let transId = Number(json_object.statement.substring(0, json_object.statement.indexOf(',')))
                                json_object.statement = `${++transId},${transType.val()},${transMode.val()},${transAmount.val()};` + json_object.statement
                            }
                            else {
                                json_object.statement = `1,${transType.val()},${transMode.val()},${transAmount.val()};`
                            }

                            model.updateJsonObject(json_object)

                            success(`Amount withdrawn \n Current balance is ${model.getJsonObject().custBalance}`, `Transaction Successful`)

                        }
                        else {
                            console.error('amount error');
                            error(`Your current balance is ${model.getJsonObject().custBalance}`, `Insufficient Balance`)
                        }

                        break
                }
            }

        })
    }
    else {
        window.location.replace('index.html')
    }

})()
