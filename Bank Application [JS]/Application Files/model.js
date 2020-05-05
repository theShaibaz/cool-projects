
var model = (function () {

    var bnp_paribas

    if (!localStorage.getItem('bnp_paribas')) {

        bnp_paribas = {
            username: 'superuser',
            password: 'superpass',
            custCrn: '9812637199011',
            custAcc: '0000054367281',
            custName: 'Vijay Malya',
            custBalance: '5000',
            custLastDeposit: '5000',
            custLastWithdraw: '0',
            transId: '1',
            statement: '1,Deposit,Cash,5000',
            // statement: '6,Withdraw,Cheque,5000;5,Deposit,Cash,5000;4,Deposit,Cash,5000;3,Withdraw,Cash,5000;2,Deposit,Cash,5000;1,Deposit,Cash,5000',
            session: '0'
        }

        setJsonObject(bnp_paribas)
        bnp_paribas = getJsonObject()
    }
    else {

        bnp_paribas = getJsonObject()
    }

    $('#logout').click(() => {
        var json_object = getJsonObject()
        json_object.session = '0'
        setJsonObject(json_object)
        window.location.replace('index.html')
    })

    return {

        username: $('#username'),
        password: $('#password'),
        login: $('#login'),
        custLastDepositCard: $('#custLastDepositCard'),
        custBalanceCard: $('#custBalanceCard'),
        custLastWithdrawCard: $('#custLastWithdrawCard'),
        custCrnCard: $('#custCrnCard'),
        custAccCard: $('#custAccCard'),
        custNameCard: $('#custNameCard'),
        transType: $('#transType'),
        transMode: $('#transMode'),
        transAmount: $('#transAmount'),
        proceedTrans: $('#proceedTrans'),
        statementBody: $('#statementBody'),

        updateJsonObject: function (json_object) {
            setJsonObject(json_object)
        },
        getJsonObject: function () {
            return getJsonObject()
        }
    }

})()

function getJsonObject() {

    var json_object = localStorage.getItem('bnp_paribas')
    json_object = JSON.parse(json_object)

    for (const key in json_object) {
        json_object[key] = decryptData(json_object[key])
    }

    return json_object
}

function setJsonObject(json_object) {

    for (const key in json_object) {
        json_object[key] = encryptData(json_object[key])
    }

    json_object = JSON.stringify(json_object)
    localStorage.setItem('bnp_paribas', json_object)
}

function encryptData(data) {

    var encryptedData = ''

    for (let index = 0; index < data.length; index++) {
        encryptedData += String.fromCharCode(data.charCodeAt(index) + 1)
    }

    return encryptedData
}

function decryptData(data) {

    var decryptedData = ''

    for (let index = 0; index < data.length; index++) {
        decryptedData += String.fromCharCode(data.charCodeAt(index) - 1)
    }

    return decryptedData
}

