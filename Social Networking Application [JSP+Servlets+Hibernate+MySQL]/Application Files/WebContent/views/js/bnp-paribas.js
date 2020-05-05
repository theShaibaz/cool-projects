
var encryptData = function (data) {

    var encryptedData = ''

    for (let index = 0; index < data.length; index++) {
        encryptedData += String.fromCharCode(data.charCodeAt(index) + 1)
    }

    return encryptedData
}

var decryptData = function (data) {

    var decryptedData = ''

    for (let index = 0; index < data.length; index++) {
        decryptedData += String.fromCharCode(data.charCodeAt(index) - 1)
    }

    return decryptedData
}

var getJsonObject = function () {

    var json_object = JSON.parse(localStorage.getItem('bnp_paribas'))

    for (const key in json_object) {
        json_object[key] = decryptData(json_object[key])
    }

    return json_object
}

var setJsonObject = function (bnp_paribas) {

    for (const key in bnp_paribas) {
        bnp_paribas[key] = encryptData(bnp_paribas[key])
    }

    var json_object = JSON.stringify(bnp_paribas)
    localStorage.setItem('bnp_paribas', json_object)
}

var addTransaction = function () {

    var json_object = getJsonObject()

    var transType = document.getElementById('transType')
    var transMode = document.getElementById('transMode')
    var transAmount = document.getElementById('transAmount')

    var statement = json_object.statement
    var transId = Number(statement.substring(0, statement.indexOf(',')))

    if (statement.length !== 0) {
        json_object.statement = `${++transId},${transType.value},${transMode.value},${transAmount.value};` + statement
    }
    else {
        json_object.statement = `${++transId},${transType.value},${transMode.value},${transAmount.value}` + statement
    }

    setJsonObject(json_object)

}

var updateStatement = function (json_object) {

    var json_object = getJsonObject()

    var statementBody = document.getElementById('statementBody')

    if (statementBody !== null) {
        var statementAll = json_object.statement.split(';')

        for (let indexRow = 0; indexRow < statementAll.length; indexRow++) {

            let _tr = document.createElement('tr')
            let statement = statementAll[indexRow].split(',')

            for (let indexCol = 0; indexCol < statement.length; indexCol++) {

                let _td = document.createElement('td')
                let _text = document.createTextNode(statement[indexCol])
                _td.appendChild(_text)
                _tr.appendChild(_td)

                if (statement[1] === 'Deposit') {
                    _td.className = 'text-primary'
                }
                else if (statement[1] === 'Withdraw') {
                    _td.className = 'text-danger'
                }
            }

            statementBody.appendChild(_tr)
        }
    }
}

var user_info = (function () {

    if (!localStorage.getItem('bnp_paribas')) {

        var bnp_paribas = {
            username: 'superuser',
            password: 'superpass',
            custCrn: '9812637199011',
            custAcc: '0000054367281',
            custName: 'Vijay Malya',
            custBalance: '0',
            custLastDeposit: '0',
            custLastWithdraw: '0',
            transId: '0',
            statement: '4,Deposit,Cash,10000;3,Deposit,Cheque,5000;2,Withdraw,Cash,11000;1,Deposit,Cash,4500'
        }

        setJsonObject(bnp_paribas)
    }
    else {

        var json_object = JSON.parse(localStorage.getItem('bnp_paribas'))

        console.log(json_object)
        for (const key in json_object) {
            json_object[key] = decryptData(json_object[key])
        }
        console.log(json_object)


        var custLastDepositCard = document.getElementById('custLastDepositCard')
        var custBalanceCard = document.getElementById('custBalanceCard')
        var custLastWithdrawCard = document.getElementById('custLastWithdrawCard')

        if (custLastDepositCard !== null && custBalanceCard !== null && custLastWithdrawCard !== null) {
            custLastDepositCard.innerHTML = json_object.custLastDeposit
            custBalanceCard.innerHTML = json_object.custBalance
            custLastWithdrawCard.innerHTML = json_object.custLastWithdraw
        }

        var custCrnCard = document.getElementById('custCrnCard')
        var custAccCard = document.getElementById('custAccCard')
        var custNameCard = document.getElementById('custNameCard')

        if (custCrnCard !== null && custAccCard !== null && custNameCard !== null) {
            custCrnCard.innerHTML = json_object.custCrn
            custAccCard.innerHTML = json_object.custAcc
            custNameCard.innerHTML = json_object.custName
        }

        var proceedTrans = document.getElementById('proceedTrans')

        if (proceedTrans !== null) {
            proceedTrans.addEventListener('click', addTransaction)
        }

        updateStatement()
    }

    return {
        json_object
    }

})
